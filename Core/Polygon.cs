using System;
using System.Text;
using System.Collections.Generic;

namespace PolygonsExercise.Core {
	public class Polygon {
		public Polygon(Point[] pts)
			:this()
		{
			this.AddRange( pts );
		}

		public Polygon() {
			this.points = new List<Point>();
		}

		public void Add(Point p)
		{
			this.points.Add( p );
		}

		public void AddRange(Point[] p)
		{
			this.points.AddRange( p );
		}

		public Point[] Points {
			get { return this.points.ToArray(); }
			set { this.points.Clear(); this.points.AddRange( value ); }
		}

		public int GetNumPoints {
			get { return this.points.Count; }
		}

		public override string ToString() {
			var toret = new StringBuilder();

			foreach(var p in this.points )
			{
				toret.Append( p.ToString() );
			}

			return toret.ToString();
		}

		private List<Point> points;
	}
}

