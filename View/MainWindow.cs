﻿using System;
using PolygonsExercise.Core;

namespace PolygonsExercise.View {
	public class MainWindow: Gtk.Window {
		public MainWindow()
			:base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		/// <summary>
		/// Invoked when the Gtk.DrawingArea needs repainting.
		/// </summary>
		private void OnExposed() {
			var p1 = new Polygon( new Point[] {
				new Point( 10, 10 ),
				new Point( 100, 100 ),
				new Point( 150, 10 )
			} );

			var t1 = new Triangle(
				new Point( 10, 210 ),
				new Point( 100, 300 ),
				new Point( 150, 210 )
			);

			var r1 = new Rectangle(
				new Point( 300, 10 ),
				new Point( 450, 10 ),
				new Point( 450, 100 ),
				new Point( 300, 100 )
			);

			var c1 = new Square(
				new Point( 300, 210 ),
				new Point( 400, 300 )
			);

			using (var canvas = Gdk.CairoHelper.Create( this.drawingArea.GdkWindow ))
			{
				canvas.LineWidth = 4;
				canvas.SetSourceRGBA( 0, 0, 255, 244 );
				canvas.LineJoin = Cairo.LineJoin.Miter;

				this.Paint( canvas, p1 );
				this.Paint( canvas, r1 );
				this.Paint( canvas, t1 );
				this.Paint( canvas, c1 );

				canvas.GetTarget().Dispose();
			}

			return;
		}

		/// <summary>
		/// Paint the specified Figure (or Polygon) object in the given Cairo.Context canvas.
		/// </summary>
		/// <param name="canvas">The canvas to paint in, as a Cairo.Context.</param>
		/// <param name="p">A Figure or Polygon object, as long as it has the Point[] Points property</param>
		private void Paint(Cairo.Context canvas, dynamic p)
		{
			Point[] points = p.Points;

			canvas.MoveTo( points[ 0 ].X, points[ 0 ].Y );
			for (int i = 1; i < points.Length; ++i) {
				canvas.LineTo( points[ i ].X, points[ i ].Y );
			}

			canvas.ClosePath();
			canvas.Stroke();
		}

		/// <summary>
		/// Build the UI
		/// </summary>
		private void Build()
		{
			var swScroll = new Gtk.ScrolledWindow();

			this.drawingArea = new Gtk.DrawingArea();
			this.drawingArea.SetSizeRequest( 640, 480 );
			swScroll.AddWithViewport( this.drawingArea );
			this.Add( swScroll );

			// Polish
			this.SetGeometryHints(
				this,
				new Gdk.Geometry() {
					MinWidth = 500,
					MinHeight = 350
				},
				Gdk.WindowHints.MinSize );

			// Events
			this.DeleteEvent += (o, args) => Gtk.Application.Quit();
			this.drawingArea.ExposeEvent += (o, args) => this.OnExposed();
			this.ShowAll();
		}

		private Gtk.DrawingArea drawingArea;
	}
}

