using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{
    public partial class frmMatriz : Form
    {
        
        private int[,] matriz = new int[3, 3]
        {
            {1,5,-2},
            {8,3,0 },
            {4,-1,2 }
        };
        
        public frmMatriz()
        {
            InitializeComponent();
        }

        private void btnMostrarMatriz_Click(object sender, EventArgs e)
        {
            

            for (int i = 0;  i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    txtMostrarMatriz.AppendText(matriz[i, j] + "   ");
                }
                // Adiciona uma quebra de linha no final de cada linha da matriz
                txtMostrarMatriz.AppendText(Environment.NewLine);
            }

        }

        private void btnMaiorValor_Click(object sender, EventArgs e)
        {
            int maiorValor = int.MinValue;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                }
            }
            MessageBox.Show("O maior valor na matriz é: " + maiorValor, "Maior Valor");
        }
            
    }
}
