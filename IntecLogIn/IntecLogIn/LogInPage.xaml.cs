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
    public partial class LogInPage : TabbedPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userEmail.Text) || String.IsNullOrEmpty(userPassword.Text))
            {
                DisplayAlert("Error", "There is an empty field. Please complete it and try again", "OK");
            }else
            {
                DisplayAlert("Welcome", "Nice to meet you " + userEmail.Text, "Thanks");
            }
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}