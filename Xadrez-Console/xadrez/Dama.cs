using tabuleiro;



namespace xadrez
{



    class Dama : Peca
    {



        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }



        public override string ToString()
        {

            return "D";

        }



        private bool podeMover(Posicao pos)
        {

            Peca p = Tab.peca(pos);

            return p == null || p.Cor != Cor;

        }



        public override bool[,] movimentosPossiveis()
        {

            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];



            Posicao pos = new Posicao(0, 0);



            // Esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha, pos.Coluna - 1);

            }



            // Direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha, pos.Coluna + 1);

            }



            // Acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha - 1, pos.Coluna);

            }



            // Abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha + 1, pos.Coluna);

            }


            // NO
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);

            }


            // NE
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);

            }


            // SE
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);

            }


            // SO
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);

            }



            return mat;

        }

    }
}