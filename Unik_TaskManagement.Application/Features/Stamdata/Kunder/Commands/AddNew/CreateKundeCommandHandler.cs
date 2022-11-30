using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew
{
    
    public class CreateKundeCommandHandler : IRequestHandler<CreateKundeCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CreateKundeCommandHandler (IUnitOfWork unitOfWork,IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle ( CreateKundeCommand request, CancellationToken cancellationToken )
        {
            Kunde kunde = _mapper.Map<Kunde>(request);

            CreateKundeCommandValidator validator = new CreateKundeCommandValidator( );
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any( ))
            {
                throw new Exception("Kunde Info is not valid");
            }

            await _unitOfWork.Kunde.CreateAsync(kunde);
            await _unitOfWork.Save( );

            return kunde.KundeId;
        }
    }
}
