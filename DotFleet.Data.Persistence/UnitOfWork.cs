using System.Data.Common;
using DotFleet.Data.Common.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DotFleet.Data.Persistence;

public abstract class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _appDbContext;

    protected UnitOfWork(DbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public virtual void Dispose()
    {
        _appDbContext.Dispose();
    }

    public virtual ValueTask DisposeAsync()
    {
        return _appDbContext.DisposeAsync();
    }

    public virtual void Save()
    {
        _appDbContext.SaveChanges();
    }

    public virtual async Task SaveAsync()
    {
        await _appDbContext.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<DbTransaction> BeginTransactionAsync()
    {
        var trx = await _appDbContext.Database.BeginTransactionAsync().ConfigureAwait(false);
        return trx.GetDbTransaction();
    }
}