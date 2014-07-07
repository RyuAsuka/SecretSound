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
using System.Runtime.InteropServices;
using SecretSound.Core;
using System.Threading;
using System.Windows.Media.Animation;

namespace SecretSound
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class LoadingWindow : Window
	{
        public LoadingWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Keeper.CheckDll())
            {
                LoadingAnimation();
            }
            else
            {
                MessageBox.Show("未找到DLL文件，请确保程序文件完整");
                this.Close();
                Keeper.AllExit();
            }
        }

        private void LoadingAnimation()
        {

            LayoutRoot.Name = "LayoutRoot";

            //NameScope.SetNameScope(this, new NameScope());
            //this.RegisterName(LayoutRoot.Name, LayoutRoot); // .Name, myRectangle);

            DoubleAnimation da = new DoubleAnimation();
            da.From = 1;
            da.To = 1;
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            
            Storyboard.SetTargetName(da, "LayoutRoot");
            Storyboard.SetTargetProperty(da, new PropertyPath(UIElement.OpacityProperty));

            Storyboard sb = new Storyboard();
            
            sb.Children.Add(da);

            sb.Completed += new EventHandler(sb_Completed);
            sb.Begin(this);
        }

        void sb_Completed(object sender, EventArgs e)
        {
            
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }
	}
}