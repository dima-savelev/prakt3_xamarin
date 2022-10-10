using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await Navigation.PushModalAsync(new RegPage());
            base.OnAppearing();
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
