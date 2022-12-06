using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetAll
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectVieModel>>
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        public GetAllProjectsQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
        {
            this._unitOfwork = unitOfwork;
            this._mapper = mapper;
        }

        public async Task<List<ProjectVieModel>> Handle ( GetAllProjectsQuery request, CancellationToken cancellationToken )
        {
            //Get all from db
            var allProject = await _unitOfwork.Project.GetAllDataAsync();
            //Then Aumap Them>> Target VM
            return _mapper.Map<List<ProjectVieModel>>(allProject);
        }
    }
}
