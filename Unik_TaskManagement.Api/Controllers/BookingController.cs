using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_TaskManagement.Application.Features.Stamdata.Bookings.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Notifications;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_TaskManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IMediator _mediator;
		public BookingController ( IMediator mediator )
		{
			this._mediator = mediator;
		}
		// GET: api/<BookingController>
		[HttpGet]
		public IEnumerable<string> Get ( )
		{
			return new string[ ] { "value1", "value2" };
		}

		// GET api/<BookingController>/5
		[HttpGet("{id}")]
		public string Get ( int id )
		{
			return "value";
		}

		// POST api/<BookingController>
		[HttpPost()]
		public async Task<ActionResult<Guid>> Post ( [FromBody] CreateBookingCommand request )
		{
			Guid id = await _mediator.Send(request);
			//send Notification to kunde
			//await _mediator.Publish(new NotifyKunder( ));
			return Ok(id);
			//return CreatedAtAction(nameof(GetById), new { id = id }, request);
		}

		// PUT api/<BookingController>/5
		[HttpPut("{id}")]
		public void Put ( int id, [FromBody] string value )
		{
		}

		// DELETE api/<BookingController>/5
		[HttpDelete("{id}")]
		public void Delete ( int id )
		{
		}
	}
}
