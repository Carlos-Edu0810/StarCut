using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCut_Library.Models;

namespace StarCut_API.Data.Configuration
{
    public class ClienteConfigurantion : IEntityTypeConfiguration<Cliente>
    {

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CADCLI");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("CLI_CODCLI").ValueGeneratedOnAdd();
            builder.Property(c => c.Nome).HasColumnName("CLI_NOME").IsRequired().HasMaxLength(100);
            builder.Property(c => c.Telefone).HasColumnName("CLI_TELEFONE").IsRequired().HasMaxLength(15);
            builder.Property(c => c.Email).HasColumnName("CLI_EMAIL").IsRequired().HasMaxLength(100);
            builder.Property(c => c.Endereco).HasColumnName("CLI_ENDERECO").HasMaxLength(200);
            builder.Property(c => c.CPF).HasColumnName("CLI_CPF").IsRequired().HasMaxLength(11);
            builder.Property(c => c.DataNascimento).HasColumnName("CLI_DATANASCIMENTO").IsRequired().HasColumnType("datetime2");
            builder.Property(c => c.DataCadastro).HasColumnName("CLI_DATACADASTRO").HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.Status).HasColumnName("CLI_STATUS").HasDefaultValue(true);

            builder.HasIndex(c => c.CPF).IsUnique().HasDatabaseName("IX_CLI_CPF");
            builder.HasIndex(c => c.Telefone).HasFillFactor(80).HasDatabaseName("IX_CLI_TELEFONE");
        }
    }
}
