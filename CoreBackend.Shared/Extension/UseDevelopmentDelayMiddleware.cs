﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBackend.Shared.Extension
{
    public static class UseDevelopmentDelayMiddleware
    {
        public static void UseDelayRequestDevelopment(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await Task.Delay(1000);
                await next.Invoke();
            });
        }
    }
}
