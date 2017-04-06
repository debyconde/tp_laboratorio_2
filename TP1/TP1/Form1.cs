using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
           double resultado;
           string auxOp;

            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);
            auxOp = cmbOperacion.SelectedIndex.ToString();

            if (numero2.getNumero() == 0 & auxOp =="3")
            {
                MessageBox.Show("NO SE PUEDE DIVIDIR POR CERO, EL RESULTADO ES 0","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
             
            }
            resultado = Calculadora.operar(numero1, numero2, cmbOperacion.Text);

            this.lblResultado.Text = resultado.ToString();

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// limpia textbox y label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";

        }


        }
    }

