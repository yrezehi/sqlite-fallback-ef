using SqliteFallbackEF.Sample.Models;
using SqliteFallbackEF.Sample.Repositories.Abstracts.Interfaces;

namespace SqliteFallbackEF.Sample.Services
{
    public class EntitiesService : ServiceBase<Entity>
    {
        public EntitiesService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
