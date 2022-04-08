using MediatR;

using Ordering.Core.Entities;

namespace Ordering.Application.Queries;

public class GetCustomerByIdQuery : IRequest<Customer>
{
    public GetCustomerByIdQuery(Int64 Id)
    {
        this.Id = Id;
    }

    public Int64 Id { get; private set; }
}