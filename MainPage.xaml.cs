namespace _132321213213
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                polubienia.Text = $"Polubienia:  {count}";
            else
                polubienia.Text = $"Polubione:  {count}";

            SemanticScreenReader.Announce(polubienia.Text);
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            count++;
            if (count == 0)
                polubienia.Text = $"Polubień: {count}";
            else if (count == 1)
                polubienia.Text = $"Polubień {count}";

            SemanticScreenReader.Announce(polubienia.Text);
        } 
    }

}
