using System;

namespace PolygonsExercise.Core {
	/// <summary>
	/// Represents all kind of figures.
	/// In this case, the Figure has a Polygon.
	/// It could be possible to design it using inheritance, though
	/// composition is a better pattern here.
	/// </summary>
	public class Figure {
		/// <summary>
		/// Initializes a new instance of the <see cref="PolygonsExercise.Core.Figure"/> class.
		/// Uses a Point[] to define the needed points. The number of points is saved as a future
		/// requisite (<see cref="NeededPointsForFigure"/>).
		/// </summary>
		/// <param name="ps">A Point[] with a given number of Point objects.</param>
		public Figure(Point[] ps) {
			this.polygon = new Polygon( ps );
			this.NeededPointsForFigure = ps.Length;
		}

		/// <summary>
		/// Modifies the original set of Point objects.
		/// It is checked that the number of Point's remains the same.
		/// </summary>
		/// <param name="ps">A Point[] with <see cref="NeededPointsForFigure"/> elements.</param>
		/// <exception cref="System.ArgumentExcetion">When the number of points does not match the original one.</exception>
		public virtual void Set(Point[] ps) {
			if ( ps.Length != this.NeededPointsForFigure ) {
				throw new ArgumentException( "Impossible to arbitrarily set points for figures" );
			}

			this.polygon.AddRange( ps );
		}

		/// <summary>
		/// Gets or sets the points for this figure.
		/// </summary>
		/// <value>The points, as a Point[]</value>
		/// <seealso cref="Figure.Set"/>
		public Point[] Points {
			get {
				return this.polygon.Points;
			}
			set {
				this.Set( value );
			}
		}

		/// <summary>
		/// Gets or sets the needed points for this figure.
		/// </summary>
		/// <value>An integer with the needed points for this figure.</value>
		public int NeededPointsForFigure {
			get; private set;
		}

		private Polygon polygon;
	}
}

