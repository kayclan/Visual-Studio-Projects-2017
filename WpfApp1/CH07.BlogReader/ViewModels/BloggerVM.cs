using CH07.BlogReader.Models;
using CH07.CookbookMVVM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CH07.BlogReader.ViewModels
{
    class BloggerVM : ViewModelBase<Blogger>
    {
        ICommand _sendEmailCommand;
        public ImageSource Picture
        {
            get
            {
                if (Model.Picture == null)
                {
                    return new BitmapImage(new Uri("/Images/bart.png", UriKind.Relative));
                }
                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = Model.Picture;
                bmp.EndInit();
                return bmp;
            }
        }

        public ICommand SendEmailCommand
        {
            get
            {
                return _sendEmailCommand ?? (_sendEmailCommand = new RelayCommand<string>(email => Process.Start("mailto:" + email)));
            }
        }
    }
}
