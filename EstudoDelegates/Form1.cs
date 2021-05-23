using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoDelegates
{
    public partial class frmCalculadora : Form
    {
        private delegate int ExecutarOperacao(int a, int b );

        private ExecutarOperacao minhaOperacao;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private int Somar(int a, int b )
        {
            return a + b;
        }

        private int Subitrai(int a, int b)
        {
            return a - b;
        }
        private int Multiply(int a, int b)
        {
            return a * b;
        }
        private int Divisao(int a , int b )
        {
            return a / b; 
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacao(Somar);
            txbResultado.Text = Calcular().ToString();
        }
        private int Calcular()
        {
            int a = Convert.ToInt32(txbNumeroUm.Text);
            int b = Convert.ToInt32(txbNumeroUm.Text);
            return minhaOperacao(a, b);

        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacao(Subitrai);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacao(Multiply);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacao(Divisao);
            txbResultado.Text = Calcular().ToString();
        }
    }
}
