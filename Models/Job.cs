namespace WorkFlow.Models;

public enum JobStatus { Planned, InProgress, Waiting, Completed }

public sealed class Job
{
    public int Id { get; init; }
    public required string Number { get; init; }
    public required string Customer { get; init; }
    public required string Description { get; init; }
    public required string Responsible { get; init; }
    public DateTime DueDate { get; init; }
    public decimal EstimatedCost { get; init; }
    public decimal ActualCost { get; init; }
    public int Progress { get; init; }
    public JobStatus Status { get; init; }
}
