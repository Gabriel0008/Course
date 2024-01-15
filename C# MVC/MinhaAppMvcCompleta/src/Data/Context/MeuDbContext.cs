using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";
            //Setta o padrão de strings não mapeadas para varchar(100)
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            //Evitar a deleção de uma classe filha ao excluir a passe pai
            //Ex: Deletar o fornecedor resultaria na deleção de todos os produtos dele

            base.OnModelCreating(modelBuilder);
        }
    }
}
