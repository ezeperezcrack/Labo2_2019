using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //cmb1.Items.Add("562"); ---> para agregar una lista de items a seleccionar 
      string sexo, aux = "Desactivado";
      
      if (rdb1.Checked)
      {
        sexo = "Masculino";
      }
      else if (rdb2.Checked)
      {
        sexo = "Femenino";
      }
      else
      {
        sexo = "Otro";
      }
      if (chk1.CheckState == CheckState.Indeterminate)
      {
        aux = "No se completo";
      }
      else if(chk1.CheckState == CheckState.Checked)
      {
        aux = "Chequeado";
      }
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Apellido: " + txt1.Text);
      sb.AppendLine("Nombre: " + txt2.Text);
      sb.AppendLine("Correo: " + txt3.Text);
      sb.AppendLine("Contraseña: " + txt4.Text);
      sb.AppendLine("Numero celular: "+ cmb1.Text + " " + txt5.Text);//Contenedores-groupBox-> sirve para agrupar chekbox o radiobu sin que se excluyan. 
      sb.AppendLine("Fecha de Nacimiento: " + dateTimePicker1.Text);
      sb.AppendLine("Sexo: " + sexo);
      sb.AppendLine(aux);
      

      if (MessageBox.Show(sb.ToString()) == DialogResult.OK)
      {
        txt1.Text = "";
        txt2.Text = "";
        txt3.Text = "";
        txt4.Text = "";
        txt5.Text = "";
        cmb1.Text = "";

      }

    }


  }
}
