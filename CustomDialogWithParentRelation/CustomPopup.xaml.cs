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
	/// Interaction logic for CustomPopup.xaml
	/// </summary>
	public partial class CustomPopup : UserControl
	{
		public CustomPopup()
		{
			InitializeComponent();
		}
		public CustomPopup(string Text, bool isRemove)
		{
			InitializeComponent();
			if (isRemove)
				parentChild.Text = "With out Parent Child Relation ship";
			else if (!isRemove)
				parentChild.Text = "With Parent Child Relation ship";
		}
		void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void OK_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Window parentWindow = (Window)this.Parent;
				if (parentWindow.Title == "PopUPWindow")
				{
					parentWindow.Close();
				}
			}
			catch (Exception ex)
			{
				//
			}
			//this.Close();
		}

	}
}
