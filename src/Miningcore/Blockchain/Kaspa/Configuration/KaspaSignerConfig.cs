namespace Miningcore.Blockchain.Kaspa.Configuration;

public class KaspaSignerConfig
{
    /// <summary>
    /// Type of signer implementation (e.g. "walletcore" or "sidecar")
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Connection endpoint or additional parameters understood by the signer
    /// </summary>
    public string Endpoint { get; set; }
}
