﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application
{
    public static class RegisterApplicationServices
    {
        public static IServiceCollection AddApplicationServices ( this IServiceCollection services )
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly( ));
            services.AddMediatR(Assembly.GetExecutingAssembly( ));
            return services;
        }
    }
}
