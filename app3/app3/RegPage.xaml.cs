using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }


        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (loginEntry.Text == null || passwordEntry.Text == null)
            {
                await DisplayAlert("Ошибка", "Введите логин и пароль", "Ok");
                return;
            }
            if (loginEntry.Text.ToLower() == "admin" && passwordEntry.Text == "123")
            {
                await Navigation.PopModalAsync();
            }
            if (loginEntry.Text.ToLower() == "user" && passwordEntry.Text == "12345")
            {
                await Navigation.PopModalAsync();
            }
            else
            {
                await DisplayAlert("Ошибка", "Введенный логин или пароль неверны", "Ok");
                return;
            }
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}