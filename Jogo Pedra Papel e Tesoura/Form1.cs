using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Pedra_Papel_e_Tesoura
{
    public partial class Form1 : Form
    {
        enum Opcoes { Pedra, Papel, Tesoura };
        Opcoes jogador = new Opcoes();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
        }

        void EscolhaJogador(jogador)
        {
            
            switch(jogador)
            {
                case Opcoes.Pedra:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("c:/imagens/pedra.jpeg");
                    break;
            }
        }

    }
}
