using Business.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity // Obriga que o acesso de dados seja feita por uma classe filha de Entity
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover (Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity,bool>> predicate); //Possibilita a pesquisa por expressões lambda
        Task<int> SaveChanges();
    }
}
