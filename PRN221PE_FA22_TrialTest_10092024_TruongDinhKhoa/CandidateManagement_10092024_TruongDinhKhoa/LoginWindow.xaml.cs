using Candidate_BusinessObjects;
using Candidate_Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_10092024_TruongDinhKhoa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class LoginWindow : Window
    {
        private IHRAccountService hRAccountService;
        public LoginWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }



        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            //Nếu để hraccount.Password.Equals(txtPassword.Password) thì có khả năng bị NULL do người ko nhập vào
            //Nên để ngược lại vì lấy từ database lên sẽ ko bị null
            //1: full quyền
            //2: Dont' Add
            Hraccount hraccount = hRAccountService.GetHraccountByEmail(txtEmail.Text);
            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password))
            {
                int? roleID = hraccount.MemberRole;
                CandidateProfileWindow candidateScren = new CandidateProfileWindow(roleID);
                candidateScren.ShowDialog();


            }
            else
            {
                MessageBox.Show("Not valid account!!");
            }
        }
    }
}