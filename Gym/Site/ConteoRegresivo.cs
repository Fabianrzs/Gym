using Gym.Entity;
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
    public partial class ConteoRegresivo : Form
    {
        private readonly UsuarioService _usuarioService;
        public ConteoRegresivo(string usuario)
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            loadInitial(usuario);
        }
        private void loadInitial(string usuario)
        {
            var response = _usuarioService.GetUsuarioByCredencial(usuario);
            if (response.Success)
            {
                userNameLbl.Text = $"{response.Data.Nombre} {response.Data.Apellido}";
                dayDisponibleLbl.Text = $"{calculaterestantes(response.Data.UltimoPago)}";
            }

        }

        private string calculaterestantes(DateTime fechaInicial)
        {
            DateTime fechaSiguienteMes = fechaInicial.AddMonths(1);

            TimeSpan diferencia = fechaSiguienteMes - fechaInicial;
            int diasRestantes = diferencia.Days;
            int horasRestantes = diferencia.Hours;

            string resultado = $"{diasRestantes} Días y {horasRestantes} Horas";
            return resultado;
        }
    }
}
