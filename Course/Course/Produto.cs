using System.Globalization;

namespace Course
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValortotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade  += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " ,"
                + Quantidade
                + " Unidade, Total: $ "
                + ValortotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
