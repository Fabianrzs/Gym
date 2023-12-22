using Gym.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Site
{
    public partial class ViewUser : Form
    {
        private readonly UsuarioService _services;
        public ViewUser()
        {
            _services = new UsuarioService();
            InitializeComponent();
            LoaderTablet();
        }

        private void LoaderTablet()
        {
            var response = _services.GetAllUsuarios();

            if (response.Success)
            {
                dataGridView1.DataSource = response.Data.ToList();
            }
            else
            {
                MessageBox.Show(response.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
