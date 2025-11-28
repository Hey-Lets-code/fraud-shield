using FraudShield.Core.Entities;

namespace FraudShield.Core.Interfaces;

public interface ITransactionRepository
{
    Task SaveAsync(Transaction transaction);
    Task<Transaction?> GetByIdAsync(string id);
    Task<IEnumerable<Transaction>> GetByCustomerIdAsync(string customerId);
}