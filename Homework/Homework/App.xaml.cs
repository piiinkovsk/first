using System;
using System.IO;
using Xamarin.Forms;

namespace Homework
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new FirstPage());
            
        }

    }
}
