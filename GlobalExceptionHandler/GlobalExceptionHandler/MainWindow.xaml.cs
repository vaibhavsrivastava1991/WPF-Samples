using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GlobalExceptionHandler
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			//Get Current Domain In Constructor...
			AppDomain currentDomain = AppDomain.CurrentDomain;
			//Add UnhandlerExceptionHandler -> MyExceptionHandlerGlobally
			currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyExceptionHandlerGlobally);
		}
		void MyExceptionHandlerGlobally(object sender, UnhandledExceptionEventArgs args)
		{
			Exception e = (Exception)args.ExceptionObject;
			if (args.IsTerminating)
			{
				try
				{
					//Do Your Work On Terminating..


				}
				catch (Exception ex)
				{
					
				}
			}
		}
	}
}
