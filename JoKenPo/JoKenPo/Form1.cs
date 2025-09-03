using System;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(Game.Opcao.Pedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(Game.Opcao.Papel);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(Game.Opcao.Tesoura);
        }

        private void StartGame(Game.Opcao opcao)
        {
            picResultado.Visible = false;
            Game jogo = new Game();

            var resultado = jogo.Jogar(opcao);

            switch (resultado)
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Properties.Resources.Ganhar;
                    break;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Properties.Resources.Perder;
                    break;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Properties.Resources.Empatar;
                    break;
            }

            // Mostrar imagens escolhidas
            pictureBox1.Image = jogo.ImgJogador;
            pictureBox2.Image = jogo.ImgPC;
            picResultado.Visible = true;
        }
    }
}
