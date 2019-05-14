using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_40;

namespace Ejercicio_40_WFA
{
  public partial class frmCentralTelefonica : Form
  {
    public Centralita c;
    public frmCentralTelefonica()
    {
      c = new Centralita("UTN");
      InitializeComponent();
    }

    private void frmCentralTelefonica_Load(object sender, EventArgs e)
    {
      //btnFacturacionLocal.Enabled = false; PARA QUE NO ROMPA CUANDO NO HAY DATOS QUE MOSTRAR
    }

    private void btnFacturacionTotal_Click(object sender, EventArgs e)
    {
      MessageBox.Show(c.GananciasPorTotal.ToString());   
    }

    private void btnFacturacionLocal_Click(object sender, EventArgs e)
    {
      MessageBox.Show(c.GananciasPorLocal.ToString());
    }

    private void btnFacturacionProvincial_Click(object sender, EventArgs e)
    {
      MessageBox.Show(c.GananciasPorProvincial.ToString());
    }

    private void btnGenerarLlamada_Click(object sender, EventArgs e)
    {
      frmLlamador frmLlamador = new frmLlamador(this.c);
      frmLlamador.ShowDialog();
    }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
