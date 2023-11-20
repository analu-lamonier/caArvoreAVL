using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreAVL
{
    internal class ArvoreAVL
    {
        private NohArvore root;

        public ArvoreAVL()
        {
            root = null;
        }

        public int fatorBalanceamento()
        {
            return fatorBalanceamento(root);
        }

        public int fatorBalanceamento(NohArvore node)
        {
            if(node == null)
            {
                return 0;
            }
            return node.NoEsquerda.Altura - node.NoDireita.Altura;
        }





















    }
}
