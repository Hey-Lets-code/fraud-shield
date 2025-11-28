using FraudShield.Core.Entities;

namespace FraudShield.Core.Services;

public class FraudAnalysisService
{
    public bool Analyze(Transaction transaction)
    {
        if (transaction.Amount > 1000)
            return true;


        if (transaction.Location == "Pais Diferente")
            return true;

        if (transaction.DeviceId == "dispositivo-suspeito")
            return true;

        return false;
    }
}