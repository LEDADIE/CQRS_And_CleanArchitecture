global using MediatR;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;

global using Ordering.Application.Commands;
global using Ordering.Application.Handlers.CommandHandlers;
global using Ordering.Application.Queries;
global using Ordering.Application.Response;
global using Ordering.Core.Entities;
global using Ordering.Core.Repositories.Command;
global using Ordering.Core.Repositories.Command.Base;
global using Ordering.Core.Repositories.Query;
global using Ordering.Core.Repositories.Query.Base;
global using Ordering.Infrastructure.Data;
global using Ordering.Infrastructure.Repositories.Command;
global using Ordering.Infrastructure.Repositories.Command.Base;
global using Ordering.Infrastructure.Repositories.Query;
global using Ordering.Infrastructure.Repositories.Query.Base;

global using System.Reflection;