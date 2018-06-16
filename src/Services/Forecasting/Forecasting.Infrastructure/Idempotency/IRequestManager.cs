using System;
using System.Threading.Tasks;

namespace EY.Digital.Services.Forecasting.Infrastructure.Idempotency
{
    public interface IRequestManager
    {
        Task<bool> ExistAsync(Guid id);

        Task CreateRequestForCommandAsync<T>(Guid id);
    }
}
