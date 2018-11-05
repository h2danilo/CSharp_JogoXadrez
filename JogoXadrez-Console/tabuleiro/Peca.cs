﻿
namespace tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.QtdeMovimentos = 0;

        }

    }
}