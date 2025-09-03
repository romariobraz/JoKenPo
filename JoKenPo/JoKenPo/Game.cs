using System;
using System.Drawing;

namespace JoKenPo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public enum Opcao
        {
            Pedra = 0,
            Tesoura = 1,
            Papel = 2
        }

        private static readonly Random rnd = new Random();

        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(Opcao jogador)
        {
            Opcao pc = JogadaPC();

            ImgJogador = imagens[(int)jogador];
            ImgPC = imagens[(int)pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == Opcao.Pedra && pc == Opcao.Tesoura) ||
                     (jogador == Opcao.Tesoura && pc == Opcao.Papel) ||
                     (jogador == Opcao.Papel && pc == Opcao.Pedra))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }
        private Opcao JogadaPC()
        {
            return (Opcao)rnd.Next(0, 3); // 0 = Pedra, 1 = Tesoura, 2 = Papel
        }



        // Melhor usar Resources, mas mantendo a sua lógica:
        public static Image[] imagens =
        {
            Image.FromFile("images/Pedra.png"),
            Image.FromFile("images/Tesoura.png"),
            Image.FromFile("images/Papel.png")
        };
    }
}
