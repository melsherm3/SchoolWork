package edu.frontrange.csc241.a2;

import java.awt.Point;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

import static java.lang.Math.abs;
import static java.lang.Math.max;
import static java.lang.Math.min;
import static java.lang.Math.signum;

/**
 * A collection of methods for computing various characteristics of a polygon. A
 * polygon is a 2D shape with some number, say <i>n</i>, of vertex points, where
 * the points are connected by <i>n</i> straight lines. For this class, all the
 * vertex points are assumed to lie on the intersections of an integral grid,
 * that is, the values of the co-ordinates are integers.
 *
 * @author	Dr. Bruce K. Haddon, Instructor
 * @version	2.0, 2015-08-20, CSC-241 Assignment 2, Exercise 9.8
 */
public class PolygonSupport
{
/**
 * Message that there are insufficient points in the polygon.
 */
private static final String INDICES_NOT_IN_RANGE = "Indices not in range.";

/**
 * Message that there are insufficient points in the polygon.
 */
private static final String INSUFFICIENT_POINTS_MESSAGE =
									"Insufficient points in the polygon.";

/**
 * Minimum number of points for convexity test.
 */
private static final int MINIMUM_CONVEXITY_POINTS = 3;

/**
 * Message that the given points do not define two vectors.
 */
private static final String NOT_TWO_VECTORS_MESSAGE =
									"Points do not define two vectors.";

/**
 * Number of points for vectors.
 */
private static final int VECTOR_POINTS = 2;

/**
 * Private constructor to prevent instantiation. All the methods of this
 * class are static.
 */
private PolygonSupport() {}

/**
 * Determine the area of the polygon specified by the array of points.
 * <p>
 * This is done by computing the crossproduct of the vectors formed by each pair
 * of points, with an (assumed) origin as the common point, which represents
 * double the (signed) area of the triangle formed by those three points. The
 * result for the area of the polygon is formed by summing all those areas, and
 * taking one-half of the absolute value. </p>
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order), or as a list of arguments (in order, separated by commas).
 *
 * @param points	the points of the polygon, in order around the polygon
 * @return			the area of the polygon, or zero if there are no points
 * @see				#crossproduct(java.awt.Point... points)
 */
public static double area(Point... points)
{
	/* Initialize the sum.  */
	int sum = 0;

	/* A nominal point to use for the assumed common point. */
	Point origin = new Point(0, 0);

	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points != null && (length = points.length) != 0 )
		for( int i = 0; i != length; ++i )
			sum += crossproduct(origin, points[i], 
									origin, points[(i + 1) % length]);
	return abs((double) sum) / 2.0;
}

/**
 * Determine if the polygon specified by the array of points is convex.
 * <p>
 * This is done by computing the sign of the z-component of the cross-product at
 * each point around the polygon. The value is positive if the rotation is
 * anticlockwise, zero if there is no rotation (i.e., the point is on a straight
 * line), negative if the rotation is clockwise. (The other components of the
 * cross-product are zero, since the points all lie in an x-y plane.) The
 * polygon is convex if none of the rotations are in opposite directions. </p>
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order), or as a list of arguments (in order, separated by commas).
 *
 * @param points	the points of the polygon.
 * @return			true if the polygon is convex.
 * @throws PolygonErrorException if there are insufficient points to conduct
 *					a convexity test
 * @see				#crossproduct(java.awt.Point...)
 */
public static boolean isConvex(Point... points) throws PolygonErrorException
{
	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points == null || (length = points.length) == 0 )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* The length of the array (i.e., the number of points on the polygon. */
	if( pointsCount(points) < MINIMUM_CONVEXITY_POINTS )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* If non-zero, this establishes a known rotation. */
	int known_rotation = 0;

	for( int i = 0; i != length; ++i )
	{
		/* h indexes the point before the point indexed by i. */
		int h = (i + length - 1) % length;
		/* j indexes the point after the point indexed by i. */
		int j = (i + 1) % length;

		/* Compute the direction of the rotation, -1, 0, or +1. */
		int rotation = (int) signum((double) crossproduct(points[i], points[j],
														points[i], points[h]));

		/* If a rotation is not established, attempt to establish a rotation. */
		if( known_rotation == 0 ) known_rotation = rotation;
		/* If this rotation has a definite direction, check that it is the same
		   as any previously established direction of rotation. If not, inform
		   the user that the polygon is not convex. */
		if( rotation != 0 && rotation != known_rotation ) return false;
	}
	return known_rotation != 0;
}

/**
 * Given four points, defining two vectors (from the first point to the second
 * point, and from the third point to the fourth point), determine whether they
 * are parallel to each other.
 * <p>
 * They are parallel if their crossproduct is 0. </p>
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param points	four points, defining two vectors (from the first point to 
 *					the second point, and from the third point to the fourth 
 *					point)
 * @return			true if the two specified vectors are parallel
 * @throws PolygonErrorException if the array of points does not define two
 *					vectors
 * @see				#crossproduct(java.awt.Point...) 
 */
public static boolean isParallel(Point... points) throws PolygonErrorException
{
	/* Check that there is the correct number of points. */
	if( pointsCount(points[0], points[1]) != VECTOR_POINTS ||
			pointsCount(points[2], points[3]) != VECTOR_POINTS )
		throw new PolygonErrorException(NOT_TWO_VECTORS_MESSAGE);
	/* Parallel if there is no rotation from one to the other vector. */
	return crossproduct(points) == 0;
}

/**
 * Given four points, defining two vectors (from the first point to the second
 * point, and from the third point to the fourth point), determine whether they
 * are perpendicular to each other.
 * <p>
 * They are perpendicular if their dot product is 0. </p>
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param points	four points, defining two vectors (from the first point to 
 *					the	second point, and from the third point to the fourth 
 *					point)
 * @return			true if the two vectors are perpendicular
 * @throws PolygonErrorException if the array of points does not define two
 *					vectors
 * @see				#dotproduct(java.awt.Point[])
 */
public static boolean isPerpendicular(Point... points) throws
		PolygonErrorException
{
	/* Check that there is the correct number of points. */
	if( pointsCount(points[0], points[1]) != VECTOR_POINTS &&
			pointsCount(points[2], points[3]) != VECTOR_POINTS )
		throw new PolygonErrorException(NOT_TWO_VECTORS_MESSAGE);
	/* The result is equivalent to the product of the slopes of the two lines
	   being equal to -1. */
	return dotproduct(points) == 0;
}

/**
 * Given the index of a point on a polygon, determine if the two sides meeting
 * at that point are perpendicular. The two sides are treated as vectors.
 * <p>
 * They are perpendicular if their dot product is 0. </p>
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param index		the point at which it is to be determined whether the sides
 *					meeting there are perpendicular
 * @param points	the points of the polygon
 * @return			true if the two sides meeting at that point are perpendicular.
 * @throws PolygonErrorException if the polygon has no points
 * @see				#isPerpendicular(java.awt.Point...) 
 */
public static boolean isPerpendicularAt(int index, Point... points)
		throws PolygonErrorException
{
	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points == null || (length = points.length) == 0 )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	if( index < 0 || index >= length )
		throw new PolygonErrorException(INDICES_NOT_IN_RANGE);

	/* h indexes the point before the indexed point. */
	int h = (index + length - 1) % length;

	/* i indexes the indexed point. */
	int i = index;

	/* j indexes the point after the indexed point. */
	int j = (index + 1) % length;

	/* They are perpendicular if this evaluation is true. */
	return isPerpendicular(points[i], points[h], points[i], points[j]);
}

/**
 * Determine if the given sides of a polygon are parallel. The sides are
 * specified by giving the index of the starting points of each of the sides in
 * question. The two sides are treated as vectors.
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param first		the first side starts at this point, and goes to the point 
 *					at first + 1 (modulo the closure of the polygon)
 * @param second	the second side starts at this point, and goes to the point at
 *					second + 1 (modulo the closure of the polygon)
 * @param points	the points of the polygon
 * @return			true if the two specified sides of the polygon are parallel
 * @throws	PolygonErrorException if the indices specifying sides are out of
 *					range or if points defining sides are not distinct
 * @see				#isParallel(java.awt.Point...) 
 *
 */
public static boolean isSidesParallel(int first, int second, Point... points)
		throws PolygonErrorException
{
	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points == null || (length = points.length) == 0 )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* i0 and j0 represent the indices of the beginning and end of the first
	   specified side of the polygon. */
	int i0 = first;
	int j0 = (first + 1) % length;

	/* i1 and j1 represent the indices of the beginning and end of the second
	   specified side of the polygon. */
	int i1 = second;
	int j1 = (second + 1) % length;

	/* Check that the given starting indices are within the polygon. */
	if( min(first, second) < 0 || max(first, second) >= length )
		throw new PolygonErrorException(INDICES_NOT_IN_RANGE);

	if( (pointsCount(points[i0], points[j0]) != VECTOR_POINTS ||
			pointsCount(points[i1], points[j1]) != VECTOR_POINTS) )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* Parallel if this evaluation is true. */
	return isParallel(points[i0], points[j0], points[i1], points[j1]);
}

/**
 * Determine the perimeter of the polygon specified by the array of points. This
 * is done by finding the distance from one point on the polygon to the next,
 * and summing those distances.
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param points	the points of the polygon.
 * @return			the distance around the points of the polygon.
 */
public static double perimeter(Point... points)
{
	/* Initialize the sum. */
	double sum = 0.0;

	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points != null && (length = points.length) != 0 )
		for( int i = 0; i != length; ++i )
			sum += points[i].distance(points[(i + 1) % length]);
	return sum;
}

/**
 * Check number of points for polygon and vector purposes.
 *
 * @param points	an array of points representing a set of connected points
 * @return			the number of distinct points in the connection
 * @throws PolygonErrorException if the alleged connection is null or has no
 *					points
 */
public static int pointsCount(Point... points)
		throws PolygonErrorException
{
	if( points == null || points.length == 0 )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);
	Set<Point> set = new HashSet<>();
	/* The set will only keep unique Points. */
	set.addAll(Arrays.asList(points));
	return set.size();
}

/**
 * Determine the perpendicular separation between a given point, and a side of a
 * polygon. The point is specified as the index of one of the points of the
 * polygon; the side is specified by giving the index of the starting point of
 * the side in question.
 * <p>
 * The perpendicular separation is determined as the height of the triangle
 * formed by the point with the base being the length of the side.
 * <p>
 * The ... notation allows the points to be either given as an array of the
 * points (in order within the array), or as a list of arguments (in order,
 * separated by commas).
 *
 * @param index		index of the given point
 * @param side		 the side starts at this point, and goes to the point at 
 *					side + 1 (modulo the closure of the polygon)
 * @param points	the points of the polygon
 * @return			the perpendicular distance from the point to the side
 * @throws	PolygonErrorException if the polygon has insufficient points to
 *					support separation
 * @see				#area(java.awt.Point...) 
 */
public static double separation(int index, int side, Point... points) throws
		PolygonErrorException
{
	/* The length of the array (i.e., the number of points on the polygon. */
	int length;
	if( points == null || (length = points.length) == 0 )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* Check that the given starting indices are within the polygon. */
	if( min(index, side) < 0 || max(index, side) >= length )
		throw new PolygonErrorException(INDICES_NOT_IN_RANGE);

	/* i0 represents the index of point. */
	int i0 = index;

	/* i1 and j1 represent the indices of the beginning and end of the second
	   specified side of the polygon. */
	int i1 = side;
	int j1 = (side + 1) % length;

	/* This is the triangle formed by the point and having as its base the full
	   length of the specified side. */
	Point[] triangle = new Point[3];
	triangle[0] = points[i0];
	triangle[1] = points[i1];
	triangle[2] = points[j1];

	/* Check that there is the correct number of points. */
	if( pointsCount(triangle) != MINIMUM_CONVEXITY_POINTS )
		throw new PolygonErrorException(INSUFFICIENT_POINTS_MESSAGE);

	/* The area of the triangle is computed by the area method. The height of
	   the triangle (which is the separation sought) is equal to the twice the
	   area, divided by the base of distance of the triangle. */
	return 2.0 * area(triangle) / triangle[1].distance(triangle[2]);
}

/**
 * Given four points, defining two vectors (point0-point1, and point2-point3),
 * determine the crossproduct of the two vectors.
 * <p>
 * In mathematics, the cross product, also known as the vector product or the
 * Gibbs vector product, is a binary operation on two vectors in
 * three-dimensional space. It results in a vector which is perpendicular to
 * both of the vectors being multiplied and hence normal to the plane containing
 * them. It has many applications in mathematics, engineering and physics.</p>
 * <p>
 * If <i>v</i>&nbsp;=&nbsp;(<i>v<sub>1</sub></i>, <i>v<sub>2</sub></i>), and
 * <i>w</i>&nbsp;=&nbsp;(<i>w<sub>1</sub></i>, <i>w<sub>2</sub></i>) are two
 * vectors in the (mathematical) (<i>x</i>,<i>y</i>) plane, then the
 * cross-product is the vector in the <i>z</i>-direction, the length of which is
 * <i>v<sub>1</sub></i><i>w<sub>2</sub></i>&nbsp;-&nbsp;
 * <i>v<sub>2</sub></i><i>w<sub>1</sub></i>. This will be zero if <i>v</i>
 * and <i>w</i> are parallel to each other, positive if the rotation from
 * <i>v</i> to <i>w</i> is anticlockwise, and negative if the rotation is
 * clockwise. (These signs are reversed if the (<i>x</i>,<i>y</i>) plane being
 * used is the graphics system where the direction of the
 * <i>y</i>-axis is reversed.) </p>
 *
 * @param points	four points, defining two vectors (from the first point to 
 *					the second point, and from the third point to the fourth 
 *					point)
 * @return			the crossproduct of the two vectors
 * @see				<a href="http://en.wikipedia.org/wiki/Cross_product">
 *					Cross Product</a>
 */
private static int crossproduct(Point... points)
{
	assert points.length == 4 : NOT_TWO_VECTORS_MESSAGE;

	int v1 = points[0].x - points[1].x;
	int v2 = points[0].y - points[1].y;
	int w1 = points[2].x - points[3].x;
	int w2 = points[2].y - points[3].y;

	return v1 * w2 - v2 * w1;
}

/**
 * Given four points, defining two vectors (point0-point1, and point2-point3),
 * determine the dot product of the two vectors.
 * <p>
 * In mathematics, the dot product is an algebraic operation that takes two
 * equal-length sequences of numbers (usually coordinate vectors) and returns a
 * single number obtained by multiplying corresponding entries and adding up
 * those products. The name is derived from the centered dot "·" that is often
 * used to designate this operation; the alternative name of scalar product (or
 * inner product) emphasizes the scalar (rather than vector) nature of the
 * result.</p>
 * <p>
 * If <i>v</i>&nbsp;=&nbsp;(<i>v<sub>1</sub></i>, <i>v<sub>2</sub></i>), and
 * <i>w</i>&nbsp;=&nbsp;(<i>w<sub>1</sub></i>, <i>w<sub>2</sub></i>) are two
 * vectors in the (mathematical) (<i>x</i>,<i>y</i>) plane, then the dot-product
 * is the scalar value
 * <i>v<sub>1</sub></i><i>w<sub>1</sub></i>&nbsp;+&nbsp;
 * <i>v<sub>2</sub></i><i>w<sub>2</sub></i>. This will be zero if <i>v</i>
 * and <i>w</i> are perpendicular to each other. (The sign of the dot product is
 * not changed if the (<i>x</i>,<i>y</i>) plane being used is the graphics
 * system where the direction of the <i>y</i>-axis is reversed.)
 *
 * @param points	four points, defining two vectors (from the first point to 
 *					the second point, and from the third point to the fourth 
 *					point)
 * @return			the dot product of the two vectors
 * @see				<a href="http://en.wikipedia.org/wiki/Dot_product">
 *					Dot Product</a>
 */
private static int dotproduct(Point... points)
{
	assert points.length == 4 : NOT_TWO_VECTORS_MESSAGE;

	int v1 = points[0].x - points[1].x;
	int v2 = points[0].y - points[1].y;
	int w1 = points[2].x - points[3].x;
	int w2 = points[2].y - points[3].y;

	return v1 * w1 + v2 * w2;
}

/**
 * Exception for reporting errors in polygons. This class is basically a wrapper
 * of the superclass Exception, and has the same constructors, and inherits the
 * same methods.
 *
 * @author	Dr. Bruce K. Haddon, Instructor
 * @version	2015-08-20, CSC-241 Assignment 2, Exercise 9.8
 *
 */
@SuppressWarnings( { "PublicInnerClass" })
public static class PolygonErrorException extends Exception
{
/**
 * SerialVerionUID
 */
private static final long serialVersionUID = 2311070738920082113L;

/**
 * Constructs a new exception with <code>null</code> as its detail message. The
 * cause is not initialized, and may subsequently be initialized by a call to
 * {@link #initCause}.
 *
 * @see	Exception
 */
public PolygonErrorException()
{
	super();
}

/**
 * Constructs a new exception with the specified detail message. The cause is
 * not initialized, and may subsequently be initialized by a call to
 * {@link #initCause}.
 *
 * @param message	the detail message. The detail message is saved for later
 *					retrieval by the {@link #getMessage()} method.
 * @see				Exception
 */
public PolygonErrorException(String message)
{
	super(message);
}

/**
 * Constructs a new exception with the specified detail message and cause.
 * <p>
 * Note that the detail message associated with <code>cause</code> is
 * <i>not</i> automatically incorporated into this exception's detail message.
 *
 * @param message	the detail message (which is saved for later retrieval by 
 *					the {@link #getMessage()} method).
 * @param cause		the cause (which is saved for later retrieval by the
 *					{@link #getCause()} method). (A <tt>null</tt> value is
 *					permitted, and indicates that the cause is nonexistent or
 *					unknown.)
 * @see	Exception
 */
public PolygonErrorException(String message, Throwable cause)
{
	super(message, cause);
}

/**
 * Constructs a new exception with the specified cause and a detail message of
 * <tt>(cause==null ? null : cause.toString())</tt> (which typically contains
 * the class and detail message of <tt>cause</tt>). This constructor is useful
 * for exceptions that are little more than wrappers for other throwables.
 *
 * @param cause		the cause (which is saved for later retrieval by the
 *					{@link #getCause()} method). (A <tt>null</tt> value is
 *					 permitted, and indicates that the cause is nonexistent or
 *					unknown.)
 * @see	Exception
 */
public PolygonErrorException(Throwable cause)
{
	super(cause);
}

}

///**
// * This main method is used to test the methods of the PolygonSupport class.
// *
// * @param args		not used
// * @throws edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException
// */
//public static void main(String[] args) throws PolygonErrorException
//{
//	/* Two vectors at right angles to each other, with positive rotation. */
//	Point[] trial1 =
//	{
//		new Point(1, 1), new Point(2, 2), new Point(3, 3), new Point(2, 4)
//	};
//	/* Two vectors parallel to each other. */
//	Point[] trial2 =
//	{
//		new Point(1, 1), new Point(2, 2), new Point(2, 3), new Point(3, 4)
//	};
//
//	/* Two vectors at 45 degrees, negative rotation. */
//	Point[] trial3 =
//	{
//		new Point(1, 1), new Point(2, 2), new Point(1, 1), new Point(2, 1)
//	};
//
//	int result = crossproduct(trial1);
//	if( result != 2 ) System.out.println("trial1/crossproduct");
//	result = dotproduct(trial1);
//	if( result != 0 ) System.out.println("trial1/dotproduct");
//
//	result = crossproduct(trial2);
//	if( result != 0 ) System.out.println("trial2/crossproduct");
//	result = dotproduct(trial2);
//	if( result != 2 ) System.out.println("trial2/dotproduct");
//
//	result = crossproduct(trial3);
//	if( result != -1 ) System.out.println("trial3/crossproduct");
//	result = dotproduct(trial3);
//	if( result != 1 ) System.out.println("trial3/dotproduct");
//
//	/* Check the area computation. */
//	double value = area(new Point(1, 1));
//	if( value != 0.0 ) System.out.println("one point area");
//	value = area(new Point(1, 1), new Point(2, 2));
//	if( value != 0.0 ) System.out.println("two point area");
//	value = area(new Point(1, 1), new Point(1, 2), new Point(2, 2));
//	if( value != 0.5 ) System.out.println("three point area");
//	
//	value = perimeter(new Point(2,2), new Point(2,3), new Point(3,4), new Point(3,3));
//	if( value != 4.82842712474619 ) System.out.println("perimeter");
//}

}
