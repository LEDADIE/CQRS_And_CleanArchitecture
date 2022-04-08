using MediatR;

using Ordering.Application.Response;

namespace Ordering.Application.Commands;

public class EditCustomerCommand : IRequest<CustomerResponse>
{
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public Int64 Id { get; set; }
    public string LastName { get; set; }
}