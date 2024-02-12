namespace Food_App.View;

public partial class DetailPage : ContentPage
{
    int count;
	public DetailPage()
	{
		InitializeComponent();
        count = 1;
	}
    private void Substract_Tapped(object sender, EventArgs e)
    {
        if (count <= 1) return;
        this.CountLabel.Text = Convert.ToString(--count);
    }
    private void Add_Tapped(object sender, EventArgs e)
    {
        this.CountLabel.Text = Convert.ToString(++count);
    }
}