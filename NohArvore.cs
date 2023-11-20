using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreAVL
{
    internal class NohArvore
    {
        private int valor;
        private int altura;
        private NohArvore noEsquerda, noDireita;

        public NohArvore() { }
        public NohArvore(int valor)
        {
            this.valor = valor;
            altura = 1; // Inicializa a altura do nó como 1
            noEsquerda = noDireita = null;
        }

        public int Valor { get => valor; set => valor = value; }
        public int Altura { get => altura; set => altura = value; }
        internal NohArvore NoEsquerda { get => noEsquerda; set => noEsquerda = value; }
        internal NohArvore NoDireita { get => noDireita; set => noDireita = value; }
    }
}
