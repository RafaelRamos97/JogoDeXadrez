namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.qteMovimentos = 0;
            this.Tab = tab;
        }

       
    }
}
