using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageViewerCh7.Commands 
{
    class OpenImageFileCommand : ICommand
    {
        private ImageData _imageData;

        public OpenImageFileCommand(ImageData imageData)
        {
            _imageData = imageData;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.gif"
            };
            if (dlg.ShowDialog() == true)
            {
                _imageData.ImagePath = dlg.FileName;
            }
        }
    }
}
