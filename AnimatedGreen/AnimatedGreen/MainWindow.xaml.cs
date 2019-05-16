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
using System.Windows.Threading;

namespace AnimatedGreen
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{public delegate void ReadyToShowDelegate(object sender, EventArgs args);

        public event ReadyToShowDelegate ReadyToShow;

        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
			//Dispatcher.BeginInvoke(new Action(() =>
			//{
			    
				//for (int i = 0; i < 1900; i++)
				//{
				//	i = 10;
				//}
			//}));
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // This timer imitates a time-consuming operation (or a whole bunch of
            // such operations).
            // When done, it raises a custom event to let the splash screen know that its time is up.

            timer.Stop();

            if (ReadyToShow != null)
            {
                ReadyToShow(this, null);
            }
        }
	}
}
