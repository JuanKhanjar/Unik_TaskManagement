using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Persistence.EntitiesConfigurations
{
	public class KunderConfiguration : IEntityTypeConfiguration<Kunde>
	{
		public void Configure ( EntityTypeBuilder<Kunde> builder )
		{
			builder.ToTable("Kunder","Unik");
			builder.HasKey(k => k.KundeId);
			builder.Property(k => k.FullName)
				.IsRequired(true)
				.HasMaxLength(100);
			builder.Property(k => k.Email).
				IsRequired(true);
			builder.Property(k => k.Phone).
				IsRequired(true);
			builder.HasData
			(
				new Kunde
				{
					KundeId = Guid.NewGuid( ),
					FullName = "AAB Vejle",
					Email = "aab@gmail.com",
					Phone="+4591747629"
				},
				new Kunde
				{
					KundeId = Guid.NewGuid( ),
					FullName = "Lejer Bo",
					Email = "lejerbo@gmail.com",
					Phone = "+4591747630"
				},
				new Kunde
				{
					KundeId = Guid.NewGuid( ),
					FullName = "Bo Ikast",
					Email = "bo@gmail.com",
					Phone = "+4591747631"
				}
			);
		}
	}
}
