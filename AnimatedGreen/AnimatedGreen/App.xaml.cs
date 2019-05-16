using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AnimatedGreen
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static Thread thread;
		public static SplashWindow w;
		protected override void OnStartup(StartupEventArgs e)
		{
			try
			{
				//var splashScreen = new SplashWindow();
				////this.MainWindow = splashScreen;
				////this.MainWindow.Close();
				//splashScreen.Show();
				OnCreateNewWindow(null,null);
			}
			catch (Exception ex)
			{

			}

		}
		private void OnCreateNewWindow(object sender, RoutedEventArgs e)
		{
			thread = new Thread(() =>
			{
				w = new SplashWindow();
				w.Show();

				w.Closed += (sender2, e2) =>
					w.Dispatcher.InvokeShutdown();

				System.Windows.Threading.Dispatcher.Run();
			});

			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
	}
}
