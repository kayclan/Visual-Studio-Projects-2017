﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageViewerCh7
{
    class Commands
    {
        static readonly RoutedUICommand _zoomNormalCommand = new RoutedUICommand("Zoom Normal", "Normal", typeof(Commands));
        public static RoutedUICommand ZoomNormalCommand
        {
            get { return _zoomNormalCommand; }
        }
    }
}
