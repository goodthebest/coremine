using System.Threading;
using System.Threading.Tasks;
using Miningcore.Blockchain.Kaspa.Configuration;

namespace Miningcore.Blockchain.Kaspa;

public class KaspaWalletBalance
{
    public decimal Pending { get; set; }
    public decimal Available { get; set; }
}

public interface IKaspaSigner
{
    /// <summary>
    /// Configure the signer using the provided configuration values
    /// </summary>
    Task ConfigureAsync(KaspaSignerConfig config, CancellationToken ct);

    /// <summary>
    /// Retrieve current wallet balance information
    /// </summary>
    Task<KaspaWalletBalance> GetBalanceAsync(CancellationToken ct);

    /// <summary>
    /// Build and sign a transaction paying the given address the specified amount.
    /// Returns the transaction id.
    /// </summary>
    Task<string> SendTransactionAsync(string address, decimal amount, string password, CancellationToken ct);
}
