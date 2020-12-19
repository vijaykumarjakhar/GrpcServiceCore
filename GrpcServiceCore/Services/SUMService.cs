using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceCore
{
    public class SUMService :SumCalculator.SumCalculatorBase
    {
        private readonly ILogger<SUMService> _logger;
        public SUMService(ILogger<SUMService> logger)
        {
            _logger = logger;
        }

        public override Task<SumReply> sum(SumRequest request, ServerCallContext context)
        {
            return Task.FromResult(new SumReply
            {
                Result = request.A + request.B 
            }); ;

        }
    }
}
