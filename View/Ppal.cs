using System;

namespace PolygonsExercise.View {
	public class Ppal {
		public static void Main(String[] args)
		{
			Gtk.Application.Init();
			var window = new MainWindow();
			Gtk.Application.Run();
		}
	}
}

