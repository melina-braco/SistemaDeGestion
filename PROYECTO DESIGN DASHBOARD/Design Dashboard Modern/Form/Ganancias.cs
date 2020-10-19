using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Clases;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern
{
    public partial class Ganancias : Form
    {
        private string strContextoDB;

        private GraficoGanancia graficoGanancia;

        private GrillaEstadisticas grillaEstadisticas;

        public Ganancias(string strContextoDB)
        {
            InitializeComponent();

            this.strContextoDB = strContextoDB;

            graficoGanancia = new GraficoGanancia(strContextoDB);

            grillaEstadisticas = new GrillaEstadisticas(strContextoDB);
        }

        private void Home_Load(object sender, EventArgs e)
        {        
            int intAño = DateTime.Today.Year;

            graficoGanancia.EstilosGrafico(chGanancias);

            graficoGanancia.SetDatos(intAño, chGanancias);

            grillaEstadisticas.GetGrillaEstadisticas(intAño, dgvEstadisticas);
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intAño = Convert.ToInt32(cbFiltro.SelectedItem.ToString());

            graficoGanancia.SetDatos(intAño, chGanancias);

            grillaEstadisticas.GetGrillaEstadisticas(intAño, dgvEstadisticas);
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            graficoGanancia.SaveImg(chGanancias);
        }
    }
}
