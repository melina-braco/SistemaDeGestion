using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Mensaje : Form
    {
        public Mensaje(string msje, int tipo)
        {
            InitializeComponent();

            tbMensaje.Text = msje;

            this.SetImg(tipo);
        }

        private void SetImg(int tipo)
        {
            if (tipo == 1)
            {
                pbImg.Image = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/brac.png");
            }
            if (tipo == 2)
            {
                pbImg.Image = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/checkok.png");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
