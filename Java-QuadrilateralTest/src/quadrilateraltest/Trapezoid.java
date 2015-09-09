
package quadrilateraltest;

import java.awt.Point;
import edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException;
import static edu.frontrange.csc241.a2.PolygonSupport.isParallel;
import static edu.frontrange.csc241.a2.PolygonSupport.separation;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * This class makes a Trapezoid based on the Quadrilateral class but makes sure
 * that at least two sides are parallel.
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
public class Trapezoid extends Quadrilateral
{
	//Height of trapezoid for calculating the area
	private double height;
	
	//Constructor with Point array as parameter
	public Trapezoid(Point[] pointsArray) throws PolygonErrorException
	{
		//Inherit pointsArray from Quadrilateral
		super(pointsArray);
		
		//Check if first and third side are parallel
		if (isParallel(pointsArray))
		{
			//Assign height based on first and third sides
			height = separation(0, 2, pointsArray);
		}
		//Check if second and fourth sides are parallel
		else if (isParallel(getPoint2(), getPoint3(), getPoint4(), getPoint1()))
		{
			//Assign the height based on the second and fourth sides
			height = separation(1, 3, pointsArray);
		}
		//If no sides are parallel, throw an exception
		else
			throw new PolygonErrorException("There are no parallel sides "
					+ "in this shape.");
	}
	
	//Return height of trapezoid
	public double getHeight()
	{
		return height;
	}
	
	//Override the toString() method to return the details of the trapezoid
	@Override
	public String toString()
	{
		return String.format("%s%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%n", 
				"Trapezoid", "Area", getArea(), "Perimeter", getPerimeter(), 
				"Height", getHeight());
	}
}
