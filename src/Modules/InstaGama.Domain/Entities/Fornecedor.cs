using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor(string nome,
                          string cnpj,
                          DateTime dataFundacao)
        {
            Nome = nome;
            Cnpj = cnpj;
            DataFundacao = dataFundacao;

        }

        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataFundacao { get; private set; }

        public bool VerificaTempoFundacao() 
        {
            var validado = true;
            var anos = DateTime.Now.Year - DataFundacao.Year;
            
            if (anos < 25)
            {
                validado = false;
            }
            return validado;
        }
    
    
    
    
    }


}
