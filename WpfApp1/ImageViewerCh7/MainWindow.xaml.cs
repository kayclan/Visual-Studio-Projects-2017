
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ImageViewerCh7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageData _image;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.gif"
            };
            if (dlg.ShowDialog() == true)
            {
                _image = new ImageData(dlg.FileName);
                DataContext = _image;
            }
        }

        private void OnIsImageExist(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (_image != null);
        }

        private void OnZoomIn(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom *= 1.2;
        }

        private void OnZoomOut(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom /= 1.2;
        }

        private void OnZoomNormal(object sender, ExecutedRoutedEventArgs e)
        {
            _image.Zoom = 1.0;
        }
    }
}
