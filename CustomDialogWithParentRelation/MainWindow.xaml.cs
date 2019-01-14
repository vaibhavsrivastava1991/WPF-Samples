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

namespace CustomDialogWithParentRelation
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void ShowModeless_Click(object sender, RoutedEventArgs e)
		{
			Button btnCli = sender as Button;
			if (btnCli != null && btnCli.Name != null)
			{
				CustomPopup pop = null;
				if (btnCli.Name == "one")
				{
					pop = new CustomPopup("Without", true);
					pop.ShowPopUpWindow(200, 300);
				}
				else
				{
					pop = new CustomPopup("Without", false);
					pop.ShowPopUpWindow();
				}

			}
		}

	}
}
