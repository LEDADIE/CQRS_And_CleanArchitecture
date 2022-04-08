﻿namespace Ordering.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : Controller
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<CustomerResponse>> CreateCustomer([FromBody] CreateCustomerCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("DeleteCustomer/{id}")]
    public async Task<ActionResult> DeleteCustomer(int id)
    {
        try
        {
            string result = string.Empty;
            result = await _mediator.Send(new DeleteCustomerCommand(id));
            return Ok(result);
        }
        catch (Exception exp)
        {
            return BadRequest(exp.Message);
        }
    }

    [HttpPut("EditCustomer/{id}")]
    public async Task<ActionResult> EditCustomer(int id, [FromBody] EditCustomerCommand command)
    {
        try
        {
            if (command.Id == id)
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        catch (Exception exp)
        {
            return BadRequest(exp.Message);
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<List<Customer>> Get()
    {
        return await _mediator.Send(new GetAllCustomerQuery());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<Customer> Get(Int64 id)
    {
        return await _mediator.Send(new GetCustomerByIdQuery(id));
    }

    [HttpGet("email")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<Customer> GetByEmail(string email)
    {
        return await _mediator.Send(new GetCustomerByEmailQuery(email));
    }
}