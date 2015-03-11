using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;
        Random r = new Random();
        public int[] bubble = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();

        }

        private void InicializarLista(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Random r = new Random();
            //r.Next(1,100) + (2 * DateTime.Now.Second)
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
        }

        private void AdicionarElementoEspecifico(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            int pos = int.Parse(Posicao.Text);
            lista.AdicionaElementoEspecifico(elemento, pos);
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                bubble[i] = r.Next(0,10);
            }

            for (int i = 0; i < bubble.Length-1; i++)
            {
                Console.WriteLine(bubble[i]);
            }
        }

        private void Organizarbublle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bubble.Length - 1; i++)
            {
                for (int j = i + 1; j < bubble.Length; j++)
                {
                    if (bubble[i] > bubble[j])
                    {
                        int temp = bubble[i];
                        bubble[i] = bubble[j];
                        bubble[j] = temp;
                    }
                }
            }
            Console.WriteLine("--------------");
            for (int i = 0; i < bubble.Length; i++)
            {
                Console.WriteLine(bubble[i]);
            }
        }

       
    }
}
