using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Delete;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Notifications;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KunderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public KunderController ( IMediator mediator )
        {
            this._mediator = mediator;
        }
        // GET: api/<KunderController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<KundeViewModel>>> Kunder ( )
        {
            var dtos = await _mediator.Send(new GetAllKunderQuery( ));
            return Ok(dtos);
        }


        // GET api/<KunderController>/5
        [HttpGet("{id:Guid}", Name = "GetDetails")]
        public async Task<ActionResult<KundeViewModel>> GetById ( Guid id )
        {
            var getEventDetailQuery = new GetKundeDetailQuery( ) { KundeId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        // POST api/<KunderController>
        [HttpPost("CraeteKunde")]
        public async Task<ActionResult<Guid>> Kunde ( [FromBody] CreateKundeCommand request )
        {
            Guid id = await _mediator.Send(request);
            //send Notification to kunde
            await _mediator.Publish(new NotifyKunder( ));
            return Ok(id);
            //return CreatedAtAction(nameof(GetById), new { id = id }, request);
        }

        // PUT api/<KunderController>/5
        [HttpPut("Update_Kunde")]
        public async Task<ActionResult> UpdateKunde ( [FromBody] UpdateKundeCommand updateKundeCommand )
        {
            await _mediator.Send(updateKundeCommand);
            return NoContent( );
        }

        // DELETE api/<KunderController>/5
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteKunde ( Guid id )
        {
            var deleteKundeCommand = new DeleteKundeCommand( ) { KundeId = id };
            await _mediator.Send(deleteKundeCommand);
            return NoContent( );
        }
    }
}
