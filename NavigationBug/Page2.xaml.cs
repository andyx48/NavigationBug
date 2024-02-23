namespace NavigationBug;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Page3());
    }
}