using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity // Obriga que o acesso de dados seja feita por uma classe filha de Entity
    {

    }
}
