using Ordering.Core.Entities.Base;

namespace Ordering.Core.Entities;

public class Customer : BaseEntity
{
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}