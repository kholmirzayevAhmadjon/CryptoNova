using CryptoNova.Domain.Commons;

namespace CryptoNova.Domain.Entities;

public sealed class Role : Auditable
{

    public string Name { get; set; }
    public IEnumerable<RolePermission> RolePermissions { get; set; }
}
