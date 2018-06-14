using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev2.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;
        private ILogger<NullMailService> logger;

        public NullMailService (ILogger<NullMailService> logger)
        {
            _logger = logger;
        }


        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation($"to: {to} subject: {subject} body:{body}");
            //log
        }
    }
}
