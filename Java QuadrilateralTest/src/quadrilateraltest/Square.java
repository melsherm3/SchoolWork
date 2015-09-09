
package quadrilateraltest;

import edu.frontrange.csc241.a2.PolygonSupport.PolygonErrorException;
import java.awt.Point;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * This class creates a Square based on the Rectangle class but makes sure
 * that the height and width are equal.
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
public class Square extends Rectangle
{
	//Constructor with Point array as parameter
	public Square(Point[] pointsArray) throws PolygonErrorException
	{
		//Inherit from Rectange -> Parallelogram -> Trapezoid -> Quadrilateral
		super(pointsArray);
		
		//Check if height and width are equal
		if(getHeight() != getWidth())
			//If they are not equal, throw an error
			throw new PolygonErrorException("This is not a square.");
	}
	
	//Override the toString() method to return the details of the square
	@Override
	public String toString()
	{
		return String.format("%s%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%s: %.2f%n%n", 
				"Square", "Area", getArea(), "Perimeter", getPerimeter(), 
				"Height", getHeight(), "Width", getWidth());
	}
}
