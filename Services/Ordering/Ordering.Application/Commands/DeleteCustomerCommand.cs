using MediatR;

namespace Ordering.Application.Commands;

public class DeleteCustomerCommand : IRequest<String>
{
    public DeleteCustomerCommand(Int64 Id)
    {
        this.Id = Id;
    }

    public Int64 Id { get; private set; }
}