using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CloudyApi;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>

    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            loaduserdata();
        }

        private void loaduserdata()
        {
            // this aint cookie stealer, it uses roblox`s appdata to show username and api avatar
            string username = Api.GetUsername();
            user.Content = username;

            BitmapImage img =   Api.GetAvatar(username);
            avatar.Source = img;
        }
    }
}
