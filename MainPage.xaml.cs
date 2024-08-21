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
            this.Resources["ConfirmationLabel"] = "Changes have been updated!";
        }
        private void OnChangeColorThemeClicked(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Color.FromArgb("#ea4c89");
            this.Resources["SecondaryColor"] = Color.FromArgb("#9f4869");
        }

    }

}
