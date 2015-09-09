
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
 * This class creates a Parallelogram based on the Trapezoid class but makes
 * sure that all sides are parallel.
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
public class Parallelogram extends Trapezoid
{
	//Width of parallelogram for calculating the area
	private double width;
	
	//Constructor with Point array as parameter
	public Parallelogram(Point[] pointsArray) throws PolygonErrorException
	{
		//Inherit pointsArray from Trapezoid -> Quadrilateral
		super(pointsArray);
		
		//Check that both sides are parallel and then assign the width
		if (isParallel(pointsArray) && 
				isParallel(getPoint2(), getPoint3(), getPoint4(), getPoint1()))
		{
			/* Height was calculated by first two parallel lines, 
			so width is the other ones*/
			width = separation(1, 3, pointsArray);
		}	
		//If it's not a parallelogram, throw an error
		else
			throw new PolygonErrorException("Both sides are not parallel.");
	}
	
	//Return width of parallelogram
	public double getWidth()
	{
		return width;
	}
	
	//Override the toString() method to return the details of the parallelogram
	@Override
	public String toString()
	{
		return String.format("%s%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%n", 
				"Parallelogram", "Area", getArea(), "Perimeter", getPerimeter(), 
				"Height", getHeight(), "Width", getWidth());
	}
	
}
