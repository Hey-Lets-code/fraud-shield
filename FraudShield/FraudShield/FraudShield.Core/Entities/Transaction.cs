namespace FraudShield.Core.Entities;

public class Transaction
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string CustomerId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public string Location { get; set; } = string.Empty;
    public string DeviceId { get; set; } = string.Empty;
    public bool IsFraud { get; set; } = false;
}