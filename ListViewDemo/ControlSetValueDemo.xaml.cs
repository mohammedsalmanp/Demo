namespace ListViewDemo;

public partial class ControlSetValueDemo : ContentPage
{
	public ControlSetValueDemo()
	{
        InitializeComponent();
        BindingContext = new ViewModel();
    }
}