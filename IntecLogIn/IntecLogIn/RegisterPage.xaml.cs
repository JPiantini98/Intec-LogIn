using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecLogIn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : MasterDetailPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            
        }

        async void RegisterClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userName.Text) || String.IsNullOrEmpty(userEmail.Text) || String.IsNullOrEmpty(userPassword.Text) || String.IsNullOrEmpty(userPasswordVerify.Text))
            {
                await DisplayAlert("Error", "There is an empty field. Please complete it and try again", "OK");
            }else if (userPassword.Text == userPasswordVerify.Text)
            {
                await DisplayAlert("Success!", "You had being succesfully registered", "OK");
                await Navigation.PopAsync();
            }else
            {
                await DisplayAlert("Error", "Password mismatch, please try againg", "OK");
            }
        }
    }
}