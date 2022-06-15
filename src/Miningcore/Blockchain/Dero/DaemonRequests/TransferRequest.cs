using Newtonsoft.Json;

namespace Miningcore.Blockchain.Dero.DaemonRequests;

public class TransferDestination
{
    public string Destination { get; set; }
    public ulong Amount { get; set; }
}

public class TransferRequest
{
    public TransferDestination[] Transfers { get; set; }

    /// <summary>
    /// Number of outputs to mix in the transaction (this output + N decoys from the blockchain)
    /// </summary>
    [JsonProperty("ringsize")]
    public uint RingSize { get; set; } = 32;
}