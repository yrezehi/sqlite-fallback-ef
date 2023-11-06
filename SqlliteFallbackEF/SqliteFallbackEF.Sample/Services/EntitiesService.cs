using Microsoft.EntityFrameworkCore;
using SqliteFallbackEF.Sample.Models;
using SqliteFallbackEF.Sample.Repositories.Abstracts.Interfaces;

namespace SqliteFallbackEF.Sample.Services
{
    public class EntitiesService
    {
        protected internal IUnitOfWork UnitOfWork { get; set; }
        protected DbSet<Entity> DBSet { get; set; }

        public EntitiesService(IUnitOfWork unitOfWork) =>
            (DBSet, UnitOfWork) = (unitOfWork.Repository<Entity>().DBSet, unitOfWork);

        public async Task<Entity> Create(Entity entity)
        {
            await DBSet.AddAsync(entity);

            await UnitOfWork.CompletedAsync();

            return entity;
        }
    }
}
