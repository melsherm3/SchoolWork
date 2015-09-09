
package quadrilateraltest;

import java.awt.Point;
import edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException;
import static edu.frontrange.csc241.a2.PolygonSupport.isConvex;
import static edu.frontrange.csc241.a2.PolygonSupport.pointsCount;
import static edu.frontrange.csc241.a2.PolygonSupport.area;
import static edu.frontrange.csc241.a2.PolygonSupport.perimeter;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * This class creates a quadrilateral. <p> It uses the PolygonSupport class to 
 * calculate the area and perimeter of the shape. It also will return the 
 * coordinates of each point and dictates that there must only be 4 points 
 * and a convex quadrilateral.</p>
 * <p>The Quadrilateral Hierarchy follows this pattern:</p>
 * <p>Quadrilateral (convex, 4 points only)<br />
 *		<- Trapezoid (at least one set of parallel sides)<br />
 *			<- Parallelogram (two parallel sides)<br />
 *				<- Rectangle (all sides intersect at 90 degree angles)<br />
 *					<- Square (all sides are equal in length)<br />
 * </p>
 * 
 * @author Melissa Cunningham, S02018492
 * @version 2015-9-1, CSC-241 Assignment 2
 */
public class Quadrilateral
{
	//Declare variables for area, perimeter, each point, and the max points allowed
	private double area;
	private double perimeter;
	private Point point1;
	private Point point2;
	private Point point3;
	private Point point4;
	private final int POINT_COUNT = 4;
	
	//Constructor with Point array as parameter
	public Quadrilateral(Point[] pointsArray) throws PolygonErrorException
	{
		//Make sure there are only 4 points in the pointsArray
		if(pointsCount(pointsArray) == POINT_COUNT)
		{
			//Make sure shape is convex
			if(isConvex(pointsArray))
			{
				//Assign the points to the points array
				point1 = pointsArray[0];
				point2 = pointsArray[1];
				point3 = pointsArray[2];
				point4 = pointsArray[3];
				//Calculate the area and perimeter using formulas in PolygonSupport
				area = area(pointsArray);
				perimeter = perimeter(pointsArray);
			}
			//If shape is not convex, throw an error
			else
				throw new PolygonErrorException("Quadrilateral must be convex");
		}
		//If shape has more or less than 4 points, throw an error
		else
			throw new PolygonErrorException("You must have only 4 points");
	}
	
	//Return area of quadrilateral
	public double getArea()
	{
		return area;
	}
	
	//Return perimeter of quadrilateral
	public double getPerimeter()
	{
		return perimeter;
	}
	
	//Return the first Point
	public Point getPoint1()
	{
		return point1;
	}
	
	//Return the second point
	public Point getPoint2()
	{
		return point2;
	}
	
	//Return the third point
	public Point getPoint3()
	{
		return point3;
	}
	
	//Return the fourth point
	public Point getPoint4()
	{
		return point4;
	}
	
	//Override the toString() method to return the details of the quadrilateral
	@Override
	public String toString()
	{
		return String.format("%s%n%s: %.2f%n%s: %.2f%n%n", 
				"Quadrilateral", "Area", getArea(), "Perimeter", getPerimeter());
	}
}
