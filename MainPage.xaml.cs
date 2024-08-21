namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveChangesClicked(object sender, EventArgs e)
        {
            string enteredName = NameEntry.Text;
            string enteredEmail = EmailEntry.Text;
            DateTime enteredDate = DateofBirthEntry.Date;
            string enteredBio = BioEntry.Text;

            string confirmationMessage = $"Name: {enteredName}\nEmail: {enteredEmail}\nDate of Birth: {enteredDate.ToShortDateString()} \nBio: {enteredBio}";
            
            await DisplayAlert("User Profile Updated!", confirmationMessage, "OK");
        }
        private void OnChangeColorThemeClicked(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Color.FromArgb("#ea4c89");
            this.Resources["SecondaryColor"] = Color.FromArgb("#9f4869");
        }

    }

}
