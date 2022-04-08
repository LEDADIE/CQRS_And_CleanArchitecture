﻿using Ordering.Core.Entities;
using Ordering.Core.Repositories.Command;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Command.Base;

namespace Ordering.Infrastructure.Repositories.Command;

public class CustomerCommandRepository : CommandRepository<Customer>, ICustomerCommandRepository
{
    public CustomerCommandRepository(OrderingContext context) : base(context)
    {
    }
}