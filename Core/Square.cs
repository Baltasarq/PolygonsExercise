using System;

namespace PolygonsExercise.Core {
	// The only way to ensure that the square will always remain as a square,
	// is to accept two points only, and build the rectangle for them.
	public class Square: Rectangle {
		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Square"/> class.
		/// Uses two points.
		/// </summary>
		/// <param name="p1">A Point object.</param>
		/// <param name="p2">A Point object.</param>
		/// <exception cref="System.ArgumentException">When a different number of two points is used.</exception>
		public Square(Point p1, Point p2)
			:this( new Point[] { p1, p2 } )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Square"/> class.
		/// Uses a Point[] that should have two Point objects.
		/// </summary>
		/// <param name="ps">A Point[] with two Point objects.</param>
		/// <exception cref="System.ArgumentException">When a different number of two points is used.</exception>
		public Square(Point[] ps)
			:base( ConvertPointsSquareToRectangle( ps ) )
		{
		}

		/// <summary>
		/// Converts two points that define a square to the needed four points for the rectangle.
		/// </summary>
		/// <returns>A Point[] with four Point objects.</returns>
		/// <param name="ps">A Point[] with two Point objects.</param>
		/// <exception cref="System.ArgumentException">When a different number of two points is used.</exception>
		public static Point[] ConvertPointsSquareToRectangle(Point[] ps) {
			if ( ps.Length != 2 ) {
				throw new ArgumentException( "squares need just two points" );
			}

			var p1 = ps[ 0 ];
			var p2 = ps[ 1 ];

			return new Point[] {
				p1, new Point( p2.X, p1.Y ), p2, new Point( p1.X, p2.Y )
			};
		}

		/// <summary>
		/// Sets the new points for the square.
		/// It is needed to translate it to four points for the parent class (Rectangle).
		/// </summary>
		/// <param name="ps">A Point[] with two Point objects.</param>
		public override void Set(Point[] ps) {
			if ( ps.Length != 2 ) {
				throw new ArgumentException( "squares need just two points" );
			}

			base.Set( ConvertPointsSquareToRectangle( ps ) );
		}
	}
}

