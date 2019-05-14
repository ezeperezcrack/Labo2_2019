using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
  public partial class Form1 : Form
  {
    DirectorTecnico directorTecnico;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.directorTecnico = new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, (int)this.edad.Value, (int)this.dni.Value, (int)this.experiencia.Value);
      MessageBox.Show("Se ha creado el DT!");
    }
    private void LimpiarForm()
    {
      this.txtNombre.Clear();
      this.txtApellido.Clear();
      this.dni.Value = 0;
      this.experiencia.Value = 0;
      this.edad.Value = 0;
      this.directorTecnico = null;
    }

    private void btnValidar_Click(object sender, EventArgs e)
    {
      if(this.directorTecnico == null)
      {
        MessageBox.Show("Aun no se ha creado el DT del formulario!");
      }
      else if (this.directorTecnico.ValidarAptitud())
      {
        MessageBox.Show("El DT es apto!");
      }
      else
      {
        MessageBox.Show("El DT NO es apto!");
      }
      this.LimpiarForm();
    }
  }
}
