using AutoMapper;
using MediatR;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetDetails
{
	public class GetAllProjectQueryHandler : IRequestHandler<GetProjectDetailQuery, ProjectDetailVieModel>
	{
		private readonly IUnitOfWork _unitOfwork;
		private readonly IMapper _mapper;

		public GetAllProjectQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
		{
			this._unitOfwork = unitOfwork;
			this._mapper = mapper;
		}
		public async Task<ProjectDetailVieModel> Handle ( GetProjectDetailQuery request, CancellationToken cancellationToken )
		{
			//Get from Db
			var Project = await _unitOfwork.Project.GetByIdAsync(P =>P.ProjectId == request.ProjectId,includeProperties:"Kunde");
			//Mapping Properties
			return _mapper.Map<ProjectDetailVieModel>(Project);
		}
	}
}
