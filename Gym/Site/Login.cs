using Gym.Logic;

namespace Gym
{
    public partial class Login : Form
    {
        private readonly CredentialService _service;
        public Login()
        {
            _service = new CredentialService();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private bool validade()
        {
            if (txtUser.Text.Equals("") ||  txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Verifique los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validade())
            {
                var respuesta = _service.Login(txtUser.Text, txtPassword.Text);
                if (respuesta.Success) {
                    MessageBox.Show(respuesta.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(respuesta.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            }
            txtUser.Focus();
        }

    }
}
