using CryptoNova.Domain.Commons;

namespace CryptoNova.Domain.Entities;

public sealed class Permission : Auditable
{
    public string Action { get; set; }
    public string Controller { get; set; }
}
