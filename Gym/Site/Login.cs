using Gym.Logic;

namespace Gym
{
    public partial class Login : Form
    {
        private readonly CredentialService service;
        public Login()
        {
            service = new CredentialService();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var s = service.ValidateUsuario("admin");
        }
    }
}
