namespace AM26_E6_Rejestracja
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;

            bool isEmail = false;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@') isEmail = true;
            }

            string password1 = passwordEntry.Text;
            string password2 = repeatPasswordEntry.Text;

            bool isPasswordCorrect = false;
            if (password1 == password2)
            {
                isPasswordCorrect = true;
            }

            if (!isEmail)
            {
                outputLabel.Text = "e-mail jest niepoprawny";
            }
            else if (!isPasswordCorrect)
            {
                outputLabel.Text = "hasła się różnią";
            }
            else
            {
                outputLabel.Text = $"witaj {email}";
            }
        }
    }
}
