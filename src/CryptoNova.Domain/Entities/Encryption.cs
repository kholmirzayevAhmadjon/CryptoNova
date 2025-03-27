using CryptoNova.Domain.Commons;
using CryptoNova.Domain.Enums;

namespace CryptoNova.Domain.Entities;

public class Encryption : Auditable
{
    public string Content { get; set; }
    public string ContentHash { get; set; }
    public string Key { get; set; }
    public long UserId { get; set; }
    public AlgorithmType AlgorithmType { get; set; }
}
