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
    public partial class frmLlamador : Form
    {
        Centralita centralitaLlamador;
        frmCentralTelefonica n = new frmCentralTelefonica();

        public frmLlamador(Centralita c)
        {
            this.centralitaLlamador = c;
            InitializeComponent();
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
            this.txtOrigen.Text = "UTN";
        }
        public Centralita CentralitaLlamador { get { return this.centralitaLlamador; } }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Marcar("1");
        }

        private void Marcar(string numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(txtDestino.Text);
            sb.Append(numero);
            txtDestino.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Marcar("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Marcar("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Marcar("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Marcar("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Marcar("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Marcar("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Marcar("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Marcar("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.Marcar("0");
        }

        private void buttonAST_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "")
            {
                this.Marcar("*");
            }
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {

            if (txtDestino.Text == "")
            {
                this.Marcar("#");
                this.cmbFranja.Enabled = true;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.txtDestino.Clear();
            this.cmbFranja.Enabled = false;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Random costo = new Random();
            Random duracion = new Random();
            string destino = "";
            Provincial.Franja franjas;

            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            foreach (char c in this.txtDestino.Text)
            {
                if (c.ToString() != "#")
                {
                    destino += c;
                }
            }
            if (this.txtDestino.Text[0].ToString() == "#")
            {
                Provincial p = new Provincial("UTN", franjas, duracion.Next(1, 50), destino);
                this.centralitaLlamador += p;
                
                MessageBox.Show("Llamada provincial realizada " + p.CostoLlamada);
            }
            else
            {
                Local l = new Local("UTN", duracion.Next(1, 50), destino,costo.Next((int)0.5, (int)5.6));
                this.centralitaLlamador += l;
                MessageBox.Show("Llamada local realizada " + l.CostoLlamada);
            }

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.centralitaLlamador.GananciasPorLocal.ToString() +"\n" + this.centralitaLlamador.GananciasPorProvincial.ToString());
            this.Close();//NO MUESTRA LA SUMA DE TODAS  
        }
    }
}
