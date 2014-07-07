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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SecretSound
{
	/// <summary>
	/// Interaction logic for Rank.xaml
	/// </summary>
	public partial class Rank : UserControl
	{

		public Rank()
		{
			this.InitializeComponent();
		}

        public void SetValue(int x)
        {
            switch (x)
            {
                case 1:
                    VisualStateManager.GoToState(this, "_1", true);
                    break;
                case 2:
                    VisualStateManager.GoToState(this, "_2", true);
                    break;
                case 4:
                    VisualStateManager.GoToState(this, "_4", true);
                    break;
                case 8:
                    VisualStateManager.GoToState(this, "_8", true);
                    break;
            }
        }
	}
}