using AutoMapper;
using Unik_TaskManagement.web.Models.KunderModels;

namespace Unik_TaskManagement.web.MappingOpjects
{
    public class Mapping:Profile
    {
        public Mapping ( )
        {
            CreateMap<KunderDto, CreateKundeDto>( ).ReverseMap( );
            CreateMap<GetKunderListViewModel, GetKunderListViewModel>( ).ReverseMap( );

            CreateMap<KunderDto, GetKundeDetailViewModel>( ).ReverseMap( );
            CreateMap<KunderDto, UpdateKundeDto>( ).ReverseMap( );
            //CreateMap<ProjectDto, ProjectsDto>( ).ReverseMap( );
        }
    }
}
