using System;

namespace PolygonsExercise.Core {
	public class Point {
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public int X {
			get; set;
		}

		public int Y {
			get; set;
		}

		public override string ToString()
		{
			return string.Format( "({0}, {1})", this.X, this.Y );
		}
	}
}

