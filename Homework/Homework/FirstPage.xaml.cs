using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Homework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
                                  
        }

        async void ButtonChange(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePage
            {
                BindingContext = Label1
            }) ;
        }


        async void ButtonHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage
            {
                
            });
        }
    }
}