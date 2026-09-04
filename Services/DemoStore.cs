using WorkFlow.Models;

namespace WorkFlow.Services;

public sealed class DemoStore
{
    public IReadOnlyList<Quote> Quotes { get; } = new List<Quote>
    {
        new() { Id = 1, Number = "ORC-2026-041", Customer = "MetalAve, Lda.", Description = "Portão seccionado e estrutura metálica", CreatedAt = DateTime.Today.AddDays(-4), ValidUntil = DateTime.Today.AddDays(26), Total = 8420m, Status = QuoteStatus.Sent },
        new() { Id = 2, Number = "ORC-2026-040", Customer = "Carpintaria Moderna", Description = "Mobiliário para moradia T3", CreatedAt = DateTime.Today.AddDays(-7), ValidUntil = DateTime.Today.AddDays(23), Total = 13750m, Status = QuoteStatus.Approved },
        new() { Id = 3, Number = "ORC-2026-039", Customer = "Construções Vale, Lda.", Description = "Guardas metálicas - 4 moradias", CreatedAt = DateTime.Today.AddDays(-10), ValidUntil = DateTime.Today.AddDays(20), Total = 6120m, Status = QuoteStatus.Draft },
        new() { Id = 4, Number = "ORC-2026-038", Customer = "Habita Norte", Description = "Caixilharia de alumínio", CreatedAt = DateTime.Today.AddDays(-14), ValidUntil = DateTime.Today.AddDays(16), Total = 9840m, Status = QuoteStatus.Rejected }
    };

    public IReadOnlyList<Job> Jobs { get; } = new List<Job>
    {
        new() { Id = 1, Number = "TRB-2026-018", Customer = "Carpintaria Moderna", Description = "Mobiliário para moradia T3", Responsible = "Carlos Silva", DueDate = DateTime.Today.AddDays(8), EstimatedCost = 9100m, ActualCost = 5420m, Progress = 62, Status = JobStatus.InProgress },
        new() { Id = 2, Number = "TRB-2026-017", Customer = "Serralharia do Ave", Description = "Estrutura para cobertura industrial", Responsible = "Rui Costa", DueDate = DateTime.Today.AddDays(2), EstimatedCost = 4750m, ActualCost = 3890m, Progress = 84, Status = JobStatus.InProgress },
        new() { Id = 3, Number = "TRB-2026-016", Customer = "Obras & Forma", Description = "Escada metálica interior", Responsible = "Ana Martins", DueDate = DateTime.Today.AddDays(-1), EstimatedCost = 2200m, ActualCost = 2010m, Progress = 90, Status = JobStatus.Waiting },
        new() { Id = 4, Number = "TRB-2026-015", Customer = "Habita Norte", Description = "Portas interiores - lote A", Responsible = "João Ribeiro", DueDate = DateTime.Today.AddDays(-5), EstimatedCost = 5800m, ActualCost = 5610m, Progress = 100, Status = JobStatus.Completed },
        new() { Id = 5, Number = "TRB-2026-019", Customer = "Construções Vale, Lda.", Description = "Guardas metálicas - 4 moradias", Responsible = "Por atribuir", DueDate = DateTime.Today.AddDays(18), EstimatedCost = 4020m, ActualCost = 0m, Progress = 0, Status = JobStatus.Planned }
    };
}
