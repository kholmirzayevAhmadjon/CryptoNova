using CryptoNova.Data.Repositories;
using CryptoNova.Domain.Entities;

namespace CryptoNova.Data.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    IRepository<Key> Keys { get; }
    IRepository<Encryption> Encryptions { get; }
    Task<bool> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
}
