namespace Bookit.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IBookItDbContext : IDisposable
    {
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;

        int SaveChanges();
    }
}
