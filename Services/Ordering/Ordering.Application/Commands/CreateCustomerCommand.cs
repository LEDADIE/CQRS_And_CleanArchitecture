using MediatR;

using Ordering.Application.Response;

namespace Ordering.Application.Commands;

public class CreateCustomerCommand : IRequest<CustomerResponse>
{
    public CreateCustomerCommand()
    {
        this.CreatedDate = DateTime.Now;
    }

    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}