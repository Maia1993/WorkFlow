namespace WorkFlow.Models;

public enum QuoteStatus { Draft, Sent, Approved, Rejected }

public sealed class Quote
{
    public int Id { get; init; }
    public required string Number { get; init; }
    public required string Customer { get; init; }
    public required string Description { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime ValidUntil { get; init; }
    public decimal Total { get; init; }
    public QuoteStatus Status { get; init; }
}
