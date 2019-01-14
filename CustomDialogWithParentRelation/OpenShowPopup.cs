using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shell;


namespace CustomDialogWithParentRelation
{
	public static class OpenShowPopup
	{
		private static Window window;
		public static void ShowPopUpWindow<T>(this T UserControl, int Width, int Height)
		{
			try
			{
				Window ownerWindow = null;
				foreach (Window window in Application.Current.Windows)
				{
					if (window.Title == "MainWindow")
					{
						ownerWindow = window;

					}
				}
				window = new Window
				{
					Content = UserControl,
					ResizeMode = ResizeMode.CanResize,
					//WindowStyle = WindowStyle.ThreeDBorderWindow,
					WindowStyle = WindowStyle.None,
					ShowInTaskbar = true,
					AllowsTransparency = true,
					WindowState = WindowState.Normal,
					WindowStartupLocation = WindowStartupLocation.CenterScreen,
					Width = Width + 20,
					Height = Height + 20,
					Title = "PopUPWindow",
					Owner = ownerWindow,
					Opacity = 1,
					IsEnabled = true
				};
				WindowChrome wc = new WindowChrome();
				wc.CornerRadius = new CornerRadius(0, 0, 0, 0);
				wc.GlassFrameThickness = new Thickness(1);
				wc.UseAeroCaptionButtons = false;
				WindowChrome.SetWindowChrome(window, wc);
				window.Background = Brushes.Transparent;
				window.Closed += new EventHandler(Window1_Closed);
				window.IsEnabled = true;
				ownerWindow.IsHitTestVisible = true;
				ownerWindow.IsEnabled = true;
				window.ShowDialog();
			}
			catch (Exception)
			{

			}
		}
		public static void ShowPopUpWindow<T>(this T UserControl)
		{
			try
			{
				Window ownerWindow = null;
				foreach (Window window in Application.Current.Windows)
				{
					if (window.Title == "MainWindow")
					{
						ownerWindow = window;

					}
				}
				window = new Window
				{
					Content = UserControl,
					ResizeMode = ResizeMode.CanResize,
					//WindowStyle = WindowStyle.ThreeDBorderWindow,
					WindowStyle = WindowStyle.None,
					ShowInTaskbar = true,
					AllowsTransparency = true,
					WindowState = WindowState.Normal,
					WindowStartupLocation = WindowStartupLocation.CenterScreen,
					Width = 300,
					Height = 300,
					Title = "PopUPWindow",
					Owner = ownerWindow,
					Opacity = 1,
					IsEnabled = true
				};
				WindowChrome wc = new WindowChrome();
				wc.CornerRadius = new CornerRadius(0, 0, 0, 0);
				wc.GlassFrameThickness = new Thickness(1);
				wc.UseAeroCaptionButtons = false;
				WindowChrome.SetWindowChrome(window, wc);
				window.Background = Brushes.Transparent;
				window.Closed += new EventHandler(Window1_Closed);
				window.IsEnabled = true;
				ownerWindow.IsHitTestVisible = true;
				ownerWindow.IsEnabled = true;
				window.Show();
			}
			catch (Exception)
			{

			}
		}
		private static void Window1_Closed(object sender, EventArgs e)
		{
			(((System.Windows.Window)sender).Owner).IsEnabled = true;
		}
	}
}
