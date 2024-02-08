namespace Food_App.Control;

public partial class ControlView : ContentView
{
    int count;
    public ControlView()
    {
        InitializeComponent();
        count = 0;
    }
    private void Substract_Tapped(object sender, EventArgs e)
    {
        if (count <= 0) return;
        this.CountLabel.Text = Convert.ToString(--count);
    }
    private void Add_Tapped(object sender, EventArgs e)
    {
        this.CountLabel.Text = Convert.ToString(++count);
    }
}