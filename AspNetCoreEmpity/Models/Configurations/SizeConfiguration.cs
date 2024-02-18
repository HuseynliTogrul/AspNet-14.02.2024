using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace AspNetCoreEmpity.Models.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.SmallName).HasColumnType("varchar").HasMaxLength(5).IsRequired();

            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int");

            builder.Property(m => m.ModifiedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.ModifiedBy).HasColumnType("int");

            builder.Property(m => m.DeletedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int");

            builder.HasKey(m => m.Id);
            builder.ToTable("Sizes");
        }
    }
}
