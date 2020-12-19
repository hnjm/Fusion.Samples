using System;
using System.Threading;
using System.Threading.Tasks;
using Stl.Fusion;
using Templates.Blazor2.Abstractions;

namespace Templates.Blazor2.Services
{
    [ComputeService(typeof(ITimeService))]
    public class TimeService : ITimeService
    {
        private DateTime _startTime = DateTime.UtcNow;

        [ComputeMethod(AutoInvalidateTime = 0.25, KeepAliveTime = 1)]
        public virtual Task<DateTime> GetTimeAsync(CancellationToken cancellationToken = default)
            => Task.FromResult(DateTime.Now);
    }
}
