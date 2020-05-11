using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Image_Resource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Btn0_1_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
                return;
            Uri resourceUri = new Uri("pack://application:,,,/ImgResDll;component/ImageFolder/1.png");
            BitmapImage bimg = new BitmapImage(resourceUri);
            Image img = new Image();
            img.Source = bimg;
            Btn0_1.Content = img;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
                return;
            if (!(button.Content is Image img))
                return;
            img.Source = new BitmapImage(new Uri("pack://application:,,,/ImgResDll;component/ImageFolder/1.png"));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
                return;
            if (!(button.Content is Image ))
                {
                button.Content= new Image();
                    }
                

            Uri fileUri = new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, "ImageFolder/0-9.png"));
            (button.Content as Image).Source = new BitmapImage(fileUri);
            
        }

    }
    
}

