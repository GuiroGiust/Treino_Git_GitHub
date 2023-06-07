using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino_Git_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAug_Click(object sender, EventArgs e)
        {

        }

        private void btnCarlos_Click(object sender, EventArgs e)
        {
            // TODO: gerar popup com os 10 primeiros numeros da sequencia de fibonacci separados por ;
            int i = 0;
            int lastNumber = 0;
            int currentNumber = 1;
            while (i < 10)
            {
                MessageBox.Show(currentNumber.ToString());
                currentNumber += lastNumber;
                lastNumber *= currentNumber;
            }

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // TODO: gerar popup com os 10 primeiros numeros da sequencia de fibonacci separados por ;
            int i = 0;
            int lastNumber = 0;
            int currentNumber = 1;
            while (i < 10)
            {
                MessageBox.Show(currentNumber.ToString());
                currentNumber += lastNumber;
                lastNumber *= currentNumber;
            }
        }

        private void btnConflito1_Click(object sender, EventArgs e)
        {

        }

        private void btnConflito2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
