/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package quadrilateraltest;

import edu.frontrange.csc241.a2.PolygonSupport;
import java.awt.Point;

/**
 * This program tests using inheritance with quadrilaterals.
 * <p>10 points are used to create different types of quadrilaterals. 
 * Errors will be thrown for each scenario that doesn't fit the requirements
 * of the class.
 * </p> 
 * <p>The Quadrilateral Hierarchy follows this pattern:</p>
 * <p>Quadrilateral (convex, 4 points only)<br />
 *		<- Trapezoid (at least one set of parallel sides)<br />
 *			<- Parallelogram (two parallel sides)<br />
 *				<- Rectangle (all sides intersect at 90 degree angles)<br />
 *					<- Square (all sides are equal in length)<br />
 * </p>
 * @author Melissa Cunningham, S02018492
 * @version 2015-9-1, CSC-241 Assignment 2
 */
public class QuadrilateralTest
{

/**
 * Main entry point.
 * <p>
 * Execute:</p>
 * <pre>java quadrilateraltest.QuadrilateralTest</pre>
 *
 * @param args   not used.
	 * @throws edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException
 */
public static void main(String[] args) //throws PolygonSupport.PolygonErrorException
{
	/*Create some random points*/
	/*
	1 * 8 * 10 * 3 * * *
	* * 6 * * * * * * 5 
	2 * 9 7 * * 4 * * *
	*/
	Point point1 = new Point(1,1);
	Point point2 = new Point(1,3);
	Point point3 = new Point(7,1);
	Point point4 = new Point(7,3);
	Point point5 = new Point(10,2);
	Point point6 = new Point(3,2);
	Point point7 = new Point(4,3);
	Point point8 = new Point(3,1);
	Point point9 = new Point(3,3);
	Point point10 = new Point(5,1);
	
	/*Create arrays of points*/
	/*Array with too many points*/
	Point[] moreThanFour = new Point[5];
	moreThanFour[0] = point1;
	moreThanFour[1] = point2;
	moreThanFour[2] = point3;
	moreThanFour[3] = point4;
	moreThanFour[4] = point5;
	
	/*Not convex in shape*/
	Point[] notConvex = new Point[4];
	notConvex[0] = point1;
	notConvex[1] = point2;
	notConvex[2] = point3;
	notConvex[3] = point4;
	
	/*Square shape*/
	Point[] square = new Point[4];
	square[0] = point1;
	square[1] = point8;
	square[2] = point9;
	square[3] = point2;
	
	/*Shape with no parallel sides*/
	Point[] noParallel = new Point[4];
	noParallel[0] = point1;
	noParallel[1] = point3;
	noParallel[2] = point4;
	noParallel[3] = point6;
	
	/*Shape with only one parallel side*/
	Point[] oneParallel = new Point[4];
	oneParallel[0] = point1;
	oneParallel[1] = point3;
	oneParallel[2] = point4;
	oneParallel[3] = point7;
	
	/*Shape with two parallel sides*/
	Point[] parallelogram = new Point[4];
	parallelogram[0] = point8;
	parallelogram[1] = point10;
	parallelogram[2] = point9;
	parallelogram[3] = point2;
	
	/*Rectangle*/
	Point[] rectangle = new Point[4];
	rectangle[0] = point1;
	rectangle[1] = point3;
	rectangle[2] = point4;
	rectangle[3] = point2;
	
	/*Test Quadrailateral Class*/
	
	/*Should throw errors:*/
	try
	{
		Quadrilateral quad1 = new Quadrilateral(moreThanFour);
		System.out.print(quad1.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}
	try
	{
		Quadrilateral notConvexQ = new Quadrilateral(notConvex);
		System.out.print(notConvexQ.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}
	
	/*Should work:*/
	try
	{
		Quadrilateral quad2 = new Quadrilateral(square);
		System.out.print(quad2.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Test Trapezoid Class*/

	/*Should throw errors:*/
	try
	{
		Trapezoid trap1 = new Trapezoid(noParallel);
		System.out.print(trap1.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Should work:*/
	try
	{
		Trapezoid trap2 = new Trapezoid(oneParallel);
		System.out.print(trap2.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Test Parallelogram Class*/

	/*Should throw errors:*/
	try
	{
		Parallelogram para1 = new Parallelogram(oneParallel);
		System.out.print(para1.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Should work:*/
	try
	{
		Parallelogram para2 = new Parallelogram(parallelogram);
		System.out.print(para2.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Test Rectangle Class*/

	/*Should throw errors:*/
	try
	{
		Rectangle rect1 = new Rectangle(parallelogram);
		System.out.print(rect1.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Should work*/
	try
	{
		Rectangle rect2 = new Rectangle(rectangle);
		System.out.print(rect2.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Test Square Class*/

	/*Should throw errors: */
	try
	{
		Square square1 = new Square(rectangle);
		System.out.print(square1.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}

	/*Should work*/
	try
	{
		Square square2 = new Square(square);
		System.out.print(square2.toString());
	}
	catch (PolygonSupport.PolygonErrorException ex)
	{
		System.err.println(ex.getMessage());
	}
}

}
