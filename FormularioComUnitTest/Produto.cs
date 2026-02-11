using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioComUnitTest
{
    public class Produto
    {
        string nome;
        decimal preco;
        string categoria;
        float iva;
        float quantidade;

        public Produto(string nome, decimal preco, string categoria, float iva, float quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.categoria = categoria;
            this.iva = iva;
            this.quantidade = quantidade;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(nome))
                erros.Add("Nome tem de estar preenchido");
            if (nome.Length < 5 && erros.Count==0)
                erros.Add("Nome tem de ter pelo menos 5 letras");
            if (preco < 0)
                erros.Add("Preço tem de ser zero ou maior");
            if (preco > 1000)
                erros.Add("Preço não pode ser superior a mil");
            if (string.IsNullOrEmpty(categoria))
                erros.Add("Categoria tem de estar preenchida");
            if (iva != 0 && iva != 0.06f && iva != 0.13 && iva != 0.23)
                erros.Add("Iva tem de ser um de: 0; 0.06; 0.13 ou 0.23");
            if (quantidade < 0)
                erros.Add("Quantidade não pode ser inferior a zero");
            return erros;
        }
    }
}
