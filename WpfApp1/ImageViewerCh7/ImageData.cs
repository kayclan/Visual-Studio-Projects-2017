using ImageViewerCh7.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageViewerCh7
{
    class ImageData : INotifyPropertyChanged
    {
        string _imagePath;
        double _zoom = 1.0;
        ICommand _openImageFileCommand, _zoomCommand;

        public ImageData()
        {
            _openImageFileCommand = new OpenImageFileCommand(this);
            _zoomCommand = new ZoomCommand(this);
        }

        public String ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                OnPropertyChanged("Zoom");
            }
        }

        public ICommand OpenImageFileCommand
        {
            get { return _openImageFileCommand; }
        }

        public ICommand ZoomCommand
        {
            get { return _zoomCommand;  }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(name));
        }
    }
}
