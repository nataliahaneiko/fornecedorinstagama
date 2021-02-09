using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        int Insert(Fornecedor fornecedor);
    }
}
