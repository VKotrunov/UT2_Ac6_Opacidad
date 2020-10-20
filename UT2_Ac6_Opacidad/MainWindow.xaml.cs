using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UT2_Ac6_Opacidad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 0.5;
        }
    }
}
