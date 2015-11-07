using System;

namespace PolygonsExercise.Core {
	public class Triangle: Figure {
		public Triangle(Point p1, Point p2, Point p3)
			:base( new Point[]{ p1, p2, p3 } )
		{
		}
	}
}


