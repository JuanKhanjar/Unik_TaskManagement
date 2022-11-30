using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update
{
    public class UpdateKundeCommandHandler : IRequestHandler<UpdateKundeCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateKundeCommandHandler ( IUnitOfWork unitOfWork, IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle ( UpdateKundeCommand request, CancellationToken cancellationToken )
        {
            try
            {
                Kunde kundeToUpdate = _mapper.Map<Kunde>(request);

                await _unitOfWork.Kunde.Update(kundeToUpdate);
                await _unitOfWork.Save( );

            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine($"Something Gose Wrong!(Concurrency) Please Try Agin Later : The Error Is:\n {ex.Message}");
            }
            return Unit.Value;
        }
    }
}
