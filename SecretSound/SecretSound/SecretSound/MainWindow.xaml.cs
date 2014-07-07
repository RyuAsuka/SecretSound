using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SecretSound.Core;

namespace SecretSound
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
			// Insert code required on object creation below this point.
            this.ResizeMode = ResizeMode.CanMinimize;
		}

        private void BT_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BT_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Keeper.AllExit();
        }

        private void BT_Deciphering_Click(object sender, RoutedEventArgs e)
        {
            DWindow DW = new DWindow();
            DW.Show();
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void BT_Enciphering_Click(object sender, RoutedEventArgs e)
        {
            DecipheringWindow DW = new DecipheringWindow();
            DW.Show();
            this.Close();
        }


	}
}