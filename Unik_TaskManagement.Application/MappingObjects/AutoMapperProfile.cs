using AutoMapper;
using Unik_TaskManagement.Application.Features.Stamdata.Bookings.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Medarbejder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Opgaver.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetDetails;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.MappingObjects
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile ( )
        {

            CreateMap<Kunde, CreateKundeCommand>( ).ReverseMap( );
            CreateMap<Kunde, UpdateKundeCommand>( ).ReverseMap( );
            CreateMap<Kunde, KundeViewModel>( ).ReverseMap( );

			CreateMap<Project, ProjectVieModel>( ).ReverseMap( );
			CreateMap<Project, ProjectDetailVieModel>( ).ReverseMap( );

			CreateMap<Booking, CreateBookingCommand>( ).ReverseMap( );

			CreateMap<Opgave, OpgaverVM>( ).ReverseMap( );

			CreateMap<Medarbejde, MedarbejderVM>( ).ReverseMap( );
			
			//CreateMap<Project, KundeViewModel>( ).ReverseMap( );
		}
    }
}
