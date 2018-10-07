﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RequestResponseFlow.Web.Extensions
{
    public class TraceHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Trace.WriteLine("Trace Handler start");
            Trace.WriteLine(request);

            var response = await base.SendAsync(request, cancellationToken);

            Trace.WriteLine(response);
            Trace.WriteLine("Trace Handler end");

            return response;
        }
    }
}