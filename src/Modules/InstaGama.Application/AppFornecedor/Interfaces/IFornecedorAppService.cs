using InstaGama.Application.AppFornecedor.Input;
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Application.AppFornecedor.Interfaces
{
    public interface IFornecedorAppService
    {
        Fornecedor Insert(FornecedorInput fornecedorInput);
    }
}
