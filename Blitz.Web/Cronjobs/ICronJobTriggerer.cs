﻿using System;
using System.Threading.Tasks;
using Blitz.Web.Hangfire;
using Hangfire;
using Microsoft.Extensions.Logging;

namespace Blitz.Web.Cronjobs
{
    public interface ICronjobTriggerer
    {
        Task<Guid> TriggerAsync(Cronjob cronjob);
    }

    public class HangfireCronjobTriggerer : ICronjobTriggerer
    {
        private readonly IBackgroundJobClient _backgroundJobClient;
        private readonly ILogger<HangfireCronjobTriggerer> _logger;

        public HangfireCronjobTriggerer(IBackgroundJobClient backgroundJobClient, ILogger<HangfireCronjobTriggerer> logger)
        {
            _backgroundJobClient = backgroundJobClient;
            _logger = logger;
        }

        public Task<Guid> TriggerAsync(Cronjob cronjob)
        {
            var executionId = Guid.NewGuid();
            _logger.LogInformation("Triggering '{CronjobTitle}' ({CronjobId}) manually with id={ExecutionId}", cronjob.Title, cronjob.Id, executionId);
            _backgroundJobClient.Enqueue<HttpRequestJob>(job => job.SendRequestAsync(cronjob.Id, executionId, default));
            return Task.FromResult(executionId);
        }
    }
}