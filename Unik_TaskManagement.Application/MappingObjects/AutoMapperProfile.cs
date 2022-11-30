using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.MappingObjects
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile ( )
        {
            CreateMap<Kunde, CreateKundeCommand>( ).ReverseMap( );
            CreateMap<Kunde, GetKunderListViewModel>( ).ReverseMap( );
            CreateMap<Kunde, GetKundeDetailViewModel>( ).ReverseMap( );
            CreateMap<Kunde, UpdateKundeCommand>( ).ReverseMap( );
            CreateMap<Project, ProjectsDto>( ).ReverseMap( );
        }
    }
}
