using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.BusinessLogic.ProductHandler;
using Utility;
using MediatR;
using Application.DTO.Response;
using Application.DTO.Request;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<ActionResult<Result<List<ProductBranchResponse>>>> Get()
        //{
        //    //return await _mediator.Send(new ProductBranchRequest());
        //}

        [ProducesResponseType(typeof(Result<ProductBranchDTOResponse>), StatusCodes.Status200OK)]
        [HttpPost]
        public async Task<ActionResult<Result<int>>> Create(CreateProductBranchRequestCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
