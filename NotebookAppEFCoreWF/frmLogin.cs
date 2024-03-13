using Microsoft.VisualBasic.ApplicationServices;
using NotebookAppEFCoreWF.Context;

namespace NotebookAppEFCoreWF
{
    public partial class frmLogin : Form
    {
        NotebookContext db = new NotebookContext();
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            var userNameCheck = db.Users.Where(u => u.UserName == txtUsername.Text);
            var passwordCheck= db.Users.Where(u=>u.Password == txtPassword.Text);
            if (userNameCheck!=null&&passwordCheck!=null)
            {
                   
            }
        }
    }
}
