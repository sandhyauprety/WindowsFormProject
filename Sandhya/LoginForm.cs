namespace Sandhya;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }


    private void btnsubmit_Click(object sender, EventArgs e)
    {
        var username=txtusername.Text;
        var password=txtpassword.Text;
        if (username == "admin" || password == "admin")
        {
            var dashboard = new DashboardForm(username);
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
        }
        else
        {
            MessageBox.Show("Username or password is invalid.");
        }
    }
}