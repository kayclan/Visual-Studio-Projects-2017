using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageViewerCh7.Commands
{
    enum ZoomType
    {
        ZoomIn,
        ZoomOut,
        ZoomNormal
    }

    class ZoomCommand : ICommand
    {
        private ImageData _imageData;

        public ZoomCommand(ImageData imageData)
        {
            _imageData = imageData;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return (_imageData != null);
        }

        public void Execute(object parameter)
        {
            var zoomType = (ZoomType)Enum.Parse(typeof(ZoomType), (string)parameter, true);
            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    _imageData.Zoom *= 1.2;
                    break;
                case ZoomType.ZoomOut:
                    _imageData.Zoom /= 1.2;
                    break;
                case ZoomType.ZoomNormal:
                    _imageData.Zoom = 1.0;
                    break;
            }
        }
    }
}
