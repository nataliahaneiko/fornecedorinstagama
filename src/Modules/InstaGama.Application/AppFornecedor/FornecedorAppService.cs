using InstaGama.Application.AppFornecedor.Input;
using InstaGama.Application.AppFornecedor.Interfaces;
using InstaGama.Domain.Entities;
using InstaGama.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Application.AppFornecedor
{
    public class FornecedorAppService : IFornecedorAppService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorAppService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public Fornecedor Insert(FornecedorInput fornecedorInput)
        {
            var fornecedor = new Fornecedor(fornecedorInput.Nome,
                                            fornecedorInput.Cnpj,
                                            fornecedorInput.DataFundacao);

            if (!fornecedor.VerificaTempoFundacao())
            {
                throw new ArgumentException("O fornecedor não pode ser cadastrado pois não tem mais de 25 anos de fundação");
            }

            _fornecedorRepository.Insert(fornecedor);

            return fornecedor;

        }

    }
}
