using System;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MyDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Context.Fornecedores.AsNoTracking()
                        .Include(cd => cd.Endereco)
                        .FirstOrDefaultAsync(cd => cd.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Context.Fornecedores.AsNoTracking()
                         .Include(cd => cd.Endereco)
                         .Include(cd => cd.Produtos)
                         .FirstOrDefaultAsync(cd => cd.Id == id);
        }
    }
}