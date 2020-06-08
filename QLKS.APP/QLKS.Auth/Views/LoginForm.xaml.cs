using System.Windows;

namespace QLKS.Auth.Views
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
