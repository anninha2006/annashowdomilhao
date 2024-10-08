namespace ShowDoMilhao;

public partial class InicialPage : ContentPage
{
    public InicialPage()
    {
        InitializeComponent();
    }

    public void botaoComecar(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}