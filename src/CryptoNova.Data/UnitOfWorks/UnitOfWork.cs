using CryptoNova.Data.DbContexts;
using CryptoNova.Data.Repositories;
using CryptoNova.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace CryptoNova.Data.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;
    private IDbContextTransaction transaction;
    public IRepository<User> Users {  get; }   

    public IRepository<Key> Keys { get; }

    public IRepository<Encryption> Encryptions {  get; }

    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
        Users = new Repository<User>(context);
        Keys = new Repository<Key>(context);
        Encryptions = new Repository<Encryption>(context);
    }
    public void Dispose()
    {
        context.Dispose();
        transaction?.Dispose();
        GC.SuppressFinalize(this);
    }
    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }
    public async Task BeginTransactionAsync()
    {
        transaction = await context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        await transaction.CommitAsync();
    }
}
