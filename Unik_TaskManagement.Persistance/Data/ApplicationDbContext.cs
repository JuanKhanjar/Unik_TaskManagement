using Microsoft.EntityFrameworkCore;
using Unik_TaskManagement.Domain;
using Unik_TaskManagement.Persistence.EntitiesConfigurations;

namespace Unik_TaskManagement.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
        }
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Opgave> Opgaver { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Medarbejde> Medarbejder { get; set; }
        public DbSet<Booking> Booking { get; set; }

       // Data Seeding

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
			//modelBuilder.ApplyConfiguration(new KunderConfiguration( ));
			#region Kunder>Project
			var kunder1Id = Guid.Parse("{2d56c6f9-da4d-4907-9c1a-634de7e7281e}");
			var kunder2Id = Guid.Parse("{344e120b-12fc-4ded-8f45-52d60604460c}");

			var p1Id = Guid.Parse("{ddb63550-022c-4d35-88d6-c3ab0b3d1d1f}");
			var p2Id = Guid.Parse("{344c5b73-5d01-4ece-8d34-b10ba6daaa19}");
			var p3Id = Guid.Parse("{6024788a-8bce-4c7d-ae34-2beafbf0a2d2}");

			var listProject = new List<Project>( );
			modelBuilder.Entity<Kunde>( ).HasData(
				new Kunde
				{
					KundeId = kunder1Id,
					FullName = "AAb Vejle",
					Email = "aabv@gmail.com",
					Phone = "82838435"
				},
				new Kunde
				{
					KundeId = kunder2Id,
					FullName = "Lejer Bo Vejle",
					Email = "lejerbo@gmail.com",
					Phone = "82838444"

				});
			modelBuilder.Entity<Project>( ).HasData (

				new Project
			    {
			        ProjectId = p1Id,
			        ProjectTitle = "Pt1",
			        Location="Vejle",
			        KundeId = kunder1Id,
			    },
			    new Project
			    {
			        ProjectId = p2Id,
			        ProjectTitle = "Pt2",
			        Location="Kolding",
			        KundeId = kunder1Id,
			    },
			    new Project
				{
					ProjectId = p3Id,
					ProjectTitle = "Pt3",
					Location = "Herning",
					KundeId = kunder2Id,
				});
			#endregion Kunder > Project
			#region Medarbejder
			var medarbejde1 = Guid.Parse("{580c5ae7-5eaa-4918-bbea-9e5a53124699}");
			var medarbejde2 = Guid.Parse("{970ad7e2-c5a8-441b-bd34-f9e68cbe11d2}");
			var medarbejde3 = Guid.Parse("{0104f406-58a9-457a-af8c-e0712c8577b5}");
			modelBuilder.Entity<Medarbejde>( ).HasData(

				new Medarbejde
				{
					MedarbejdeId = medarbejde1,
					FirstName = "med1",
					LastName = "med1L",
					Email = "med1@gmail.com",
					Phone = "12345678",
					Job = JobeType.Technical,
				},
				new Medarbejde
				{
					MedarbejdeId = medarbejde2,
					FirstName = "med1",
					LastName = "med2L",
					Email = "med2@gmail.com",
					Phone = "12345679",
					Job = JobeType.Technical
				},
				new Medarbejde
				{
					MedarbejdeId = medarbejde3,
					FirstName = "med3",
					LastName = "med3L",
					Email = "med3@gmail.com",
					Phone = "12345630",
					Job = JobeType.Converter
				});
			;
			#endregion Medarbejder
			#region Skills
			var skil1 = Guid.Parse("{65384c2c-9000-435a-bd94-abadc2d5107e}");
			var skil2 = Guid.Parse("{97ce53b1-f23a-4930-b4bf-67e419949ae1}");
			var skil3 = Guid.Parse("{a29731a6-c039-4a3d-898f-bd6236a4a101}");
			var skil4 = Guid.Parse("{0d3243bb-fb8a-4323-a9fd-362bfe23165d}");
			modelBuilder.Entity<Skill>( ).HasData(

					new Skill
					{
						SkillId = skil1,
						SkillTitle = "Sql Server",
						Description="some des."
						
					},
					new Skill
					{
						SkillId = skil2,
						SkillTitle = "Programming",
						Description = "some des."
					},
					new Skill
					{
						SkillId = skil3,
						SkillTitle = "Consultant",
						Description = "some des."
					},
					new Skill
					{
						SkillId = skil4,
						SkillTitle = "Sikkehed",
						Description = "some des."
					});
			#endregion Skils
			#region Opgaver
			var opgave1 = Guid.Parse("{08fc43ea-0283-4371-900e-e22028bb721e}");
			var opgave2 = Guid.Parse("{3b6db15f-0120-4b6c-bb54-dff6b0faf466}");
			var opgave3 = Guid.Parse("{f6b0b0d5-b5dc-4677-bd45-cbd4c6925401}");
			var opgave4 = Guid.Parse("{04b8af31-28b6-4b14-91d1-f5c7f62f4496}");
			modelBuilder.Entity<Opgave>( ).HasData(

					new Opgave
					{
						OpgaveId = opgave1,
						Title = " Installing Sql Server",
						Description=""
					},
					new Opgave
					{
						OpgaveId = opgave2,
						Title = "Make Database net working",
						Description = ""
					},
					new Opgave
					{
						OpgaveId = opgave3,
						Title = "Programming ",
						Description = ""
					},
					new Opgave
					{
						OpgaveId = opgave4,
						Title = "testing systems",
						Description = ""
					});
			#endregion
		}
	}
}
