using SepSampleCodeBase.Domain.Common;
using System.Threading.Tasks;

namespace SepSampleCodeBase.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
