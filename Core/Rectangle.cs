using System;

namespace PolygonsExercise.Core {
	/// <summary>
	/// Represents rectangle figures.
	/// </summary>
	public class Rectangle: Figure {
		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Rectangle"/> class.
		/// </summary>
		/// <param name="p1">A Point object.</param>
		/// <param name="p2">A Point object.</param>
		/// <param name="p3">A Point object.</param>
		/// <param name="p4">A Point object.</param>
		public Rectangle(Point p1, Point p2, Point p3, Point p4)
			:this( new Point[]{ p1, p2, p3, p4 } )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Rectangle"/> class.
		/// </summary>
		/// <param name="ps">A Point[] that should have four Point objects.</param>
		/// <exception cref="System.ArgumentException">When a different number of Point objects is passed.</exception>
		public Rectangle(Point[] ps)
			:base( ps )
		{
			if ( ps.Length != 4 ) {
				throw new ArgumentException( "rectangles need four points" ); 
			}
		}
	}
}

