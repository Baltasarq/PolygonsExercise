using System;

namespace PolygonsExercise.Core {
	/// <summary>
	/// Represents triangles.
	/// </summary>
	public class Triangle: Figure {
		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Triangle"/> class.
		/// </summary>
		/// <param name="p1">A Point object.</param>
		/// <param name="p2">A Point object.</param>
		/// <param name="p3">A Point object.</param>
		public Triangle(Point p1, Point p2, Point p3)
			:base( new Point[]{ p1, p2, p3 } )
		{
		}
	}
}


