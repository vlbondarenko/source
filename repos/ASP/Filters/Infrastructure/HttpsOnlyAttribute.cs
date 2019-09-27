﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Filters.Infrastructure
{
    //Класс с реализицией фильтра авторизации
    public class HttpsOnlyAttribute:Attribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.IsHttps)
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
        }
    }
}