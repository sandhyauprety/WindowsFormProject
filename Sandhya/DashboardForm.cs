namespace Sandhya;

public partial class DashboardForm : Form
{
    public DashboardForm(string username)
    {
        InitializeComponent();
        Lwelcome.Text ="Welcome  " + username + " !";
    }
}