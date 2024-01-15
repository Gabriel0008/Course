using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);

            //1 : N => Fornecedor : Produtos

            builder.HasMany(f => f.Produtos) //Atributo IEnumerable
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId); //Chave Estrangeira

            //A classe que possui as outras é responsável pelo mapeamento 

            builder.ToTable("Fornecedores");


        }
    }

}
