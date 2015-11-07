using System;

namespace PolygonsExercise.Core {
	/// <summary>
	/// The classic Point, revisited.
	/// </summary>
	public class Point {
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		/// <summary>
		/// Gets or sets the x coordinate.
		/// </summary>
		/// <value>The x coordinate, as an int.</value>
		public int X {
			get; set;
		}

		/// <summary>
		/// Gets or sets the y coordinate.
		/// </summary>
		/// <value>The y coordinate, as an int.</value>
		public int Y {
			get; set;
		}

		public override string ToString()
		{
			return string.Format( "({0}, {1})", this.X, this.Y );
		}
	}
}

