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
using Microsoft.Win32;
using System.IO;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Inject_Click(object sender, RoutedEventArgs e)
        {
            CloudyApi.Api.inject();
        }
        
        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            CloudyApi.Api.execute(editor.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            editor.Text = string.Empty;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Files of Text (*.txt;*.lua)|*.txt;*.lua",
                Title = "Select a Lua or Text file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                editor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Files of Text (*.txt;*.lua)|*.txt;*.lua",
                Title = "Save code"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, editor.Text);
            }
        }

    }
}
