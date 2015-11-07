using System;

namespace PolygonsExercise.Core {
	public class Rectangle: Figure {
		public Rectangle(Point p1, Point p2, Point p3, Point p4)
			:base( new Point[]{ p1, p2, p3, p4 } )
		{
		}
	}
}

