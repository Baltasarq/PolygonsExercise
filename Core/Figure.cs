using System;

namespace PolygonsExercise.Core {
	public class Figure: Polygon {
		public Figure(Point[] ps) {
			this.FigureNeededPoints = ps.Length;
			base.AddRange( ps );
		}

		public override void Add(Point p) {
			throw new Exception( "Not possible for figures" );
		}

		public override void AddRange(Point[] ps) {
			if ( ps.Length != this.FigureNeededPoints ) {
				throw new Exception( "Not possible for figures" );
			}

			base.AddRange( ps );
		}

		public int FigureNeededPoints {
			get; private set;
		}
	}
}

