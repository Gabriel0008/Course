using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>,IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id) //Obtem fornecedores + Endereço
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(x => x.Endereco)
                .FirstOrDefaultAsync(c=> c.Id == id);
        }

        public async Task<Fornecedor> ObterFornecerProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(x => x.Endereco)
                .Include(x => x.Produtos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
