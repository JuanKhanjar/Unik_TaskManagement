using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Bookings.Commands.AddNew
{
	public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, Guid>
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;
		public CreateBookingCommandHandler ( IUnitOfWork unitOfWork, IMapper mapper )
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<Guid> Handle ( CreateBookingCommand request, CancellationToken cancellationToken )
		{
			Booking bookingFromDb=_mapper.Map<Booking>( request );
			await _unitOfWork.Booking.CreateAsync( bookingFromDb );
			await _unitOfWork.Save( );
			return bookingFromDb.BookId;
		}
	}
}
