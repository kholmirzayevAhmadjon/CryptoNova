using CryptoNova.Domain.Commons;
using CryptoNova.Domain.Enums;

namespace CryptoNova.Domain.Entities;

public class Key : Auditable
{
    public long UserId { get; set; }
    public AlgorithmType AlgorithmType { get; set; }
    public string KeyValue {  get; set; }
}
