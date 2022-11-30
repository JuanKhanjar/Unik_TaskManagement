using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Delete
{
    public class DeleteKundeCommandHandler : IRequestHandler<DeleteKundeCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteKundeCommandHandler ( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle ( DeleteKundeCommand request, CancellationToken cancellationToken )
        {
            var KundeFromDb = await _unitOfWork.Kunde.GetByIdAsync(k=>k.KundeId==request.KundeId);
            if (KundeFromDb != null)
            {
                 _unitOfWork.Kunde.Delete(KundeFromDb);
                await _unitOfWork.Save( );
            }

            return Unit.Value;
        }
    }
}
