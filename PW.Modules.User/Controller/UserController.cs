using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.Modules.User.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        private IMediator _mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        //[Authorize("get:api/Device")]
        [HttpGet]
        public async Task<ActionResult<ApiResponse<PaginationResult<IAsyncEnumerable<DeviceListDto>>>>> GetDeviceList([FromQuery] DeviceSearchCriteria searchParams)
        {
            var dtos = await _deviceService.GetDeviceList(searchParams);
            return Ok(ApiResponse(dtos));
        }
    }
}
