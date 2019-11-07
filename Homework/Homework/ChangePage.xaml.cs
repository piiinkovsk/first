using System;
using System.IO;
using Xamarin.Forms;

namespace Homework
{
     
    
    public partial class ChangePage : ContentPage
    {
        public ChangePage()
        {
            InitializeComponent();
        }
        async void ButtonSave(object sender, EventArgs e)
        {
            string k = editor.Text;
            var l= (Label)BindingContext;
            l.Text = k;
                        
            await Navigation.PopAsync();
        }
    }
}