
package quadrilateraltest;

import java.awt.Point;
import edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException;
import static edu.frontrange.csc241.a2.PolygonSupport.isPerpendicularAt;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * This class creates a Rectangle based on the Parallelogram class but makes sure
 * that all points are perpendicular.
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
public class Rectangle extends Parallelogram
{
	//Constructor with Point array as parameter
	public Rectangle(Point[] pointsArray) throws PolygonErrorException
	{
		//Inherit pointsArray from Parallelogram -> Trapezoid -> Quadrilateral
		super(pointsArray);
		
		if (!isPerpendicularAt(0, pointsArray) 
				|| !isPerpendicularAt(2, pointsArray))
			throw new PolygonErrorException("The sides of this shape are not at "
					+ "90 degree angles.");
	}
	
	//Override the toString() method to return the details of the rectangle
	@Override
	public String toString()
	{
		return String.format("%s%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%n", 
				"Rectangle", "Area", getArea(), "Perimeter", getPerimeter(), 
				"Height", getHeight(), "Width", getWidth());
	}
}
