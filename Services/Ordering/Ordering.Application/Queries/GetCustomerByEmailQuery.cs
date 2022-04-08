using MediatR;

using Ordering.Core.Entities;

namespace Ordering.Application.Queries;

public class GetCustomerByEmailQuery : IRequest<Customer>
{
    public GetCustomerByEmailQuery(string email)
    {
        this.Email = email;
    }

    public string Email { get; private set; }
}