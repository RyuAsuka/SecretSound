using Microsoft.Win32;
using SecretSound.Core;
using SecretSound.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SecretSound
{
	/// <summary>
	/// Interaction logic for DWindow.xaml
	/// </summary>
	public partial class DWindow : Window
	{
		public DWindow()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void BT_FileInput_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OFD = new System.Windows.Forms.OpenFileDialog();

            OFD.Title = @"请选择已加密过的音频文件";
            OFD.Filter = "无损音频文件(*wav)|*.wav";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            OFD.Multiselect = false;
            
            if (OFD.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                ViewLeader.EncipheringView.FileInput_Path = OFD.FileName;
            }
        }

        private void BT_FileOutput_Copy_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewLeader.EncipheringView.FileOutput_Path = FBD.SelectedPath;
            }

        }

        private void BT_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Keeper.AllExit();
        }

        private void BT_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LayoutRoot.DataContext = ViewLeader.EncipheringView;
            MixBitRank.SetValue(2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ViewLeader.EncipheringView.Check())
            {
                ViewLeader.EncipheringView.Extract();
                PB.Visibility = Visibility.Visible;
            }
        }

        private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }



	}
}