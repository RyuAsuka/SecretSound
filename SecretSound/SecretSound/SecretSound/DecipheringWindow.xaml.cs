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
using SecretSound.View;

namespace SecretSound
{
	/// <summary>
	/// Interaction logic for DecipheringWindow.xaml
	/// </summary>
	public partial class DecipheringWindow : Window
	{
		public DecipheringWindow()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LayoutRoot.DataContext = ViewLeader.DecipheringView;
            MixBitRank.SetValue(2);
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

        private void BT_FileSource_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OFD = new System.Windows.Forms.OpenFileDialog();

            OFD.Title = @"请选择用于伪装的音频文件";
            OFD.Filter = "无损音频文件(*wav)|*.wav";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            OFD.Multiselect = false;

            if (OFD.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                ViewLeader.DecipheringView.FileSource_Path = OFD.FileName;
            }
        }

        private void BT_FileInput_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OFD = new System.Windows.Forms.OpenFileDialog();

            OFD.Title = @"请选择需要伪装的文件";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            OFD.Multiselect = false;

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewLeader.DecipheringView.FileInput_Path = OFD.FileName;
            }
        }

        private void BT_FileOutput_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog SFD = new System.Windows.Forms.SaveFileDialog();

            SFD.AddExtension = true;
            SFD.CheckPathExists = true;

            SFD.OverwritePrompt = true;
            SFD.Title = @"输出文件位置";
            SFD.Filter = @"无损音频文件(*wav)|*.wav";
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewLeader.DecipheringView.FileOutput_Path = SFD.FileName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ViewLeader.DecipheringView.Check())
            {
                ViewLeader.DecipheringView.Mix();
                PB.Visibility = Visibility.Visible;
            }
            
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void BT_Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        
    }
}