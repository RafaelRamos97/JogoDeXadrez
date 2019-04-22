namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[Linhas,Colunas];
        }

        public Peca peca(int Linhas, int Colunas)
        {
            return Pecas[Linhas,Colunas];
        }
    }
}
