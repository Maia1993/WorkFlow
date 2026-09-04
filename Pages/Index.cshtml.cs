using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkFlow.Models;
using WorkFlow.Services;

namespace WorkFlow.Pages;

public class IndexModel(DemoStore store) : PageModel
{
    public IReadOnlyList<Job> ActiveJobs => store.Jobs.Where(x => x.Status is JobStatus.InProgress or JobStatus.Waiting).ToList();
    public decimal OpenQuoteValue => store.Quotes.Where(x => x.Status is QuoteStatus.Draft or QuoteStatus.Sent).Sum(x => x.Total);
    public int ApprovedQuotes => store.Quotes.Count(x => x.Status == QuoteStatus.Approved);
    public decimal CurrentMargin => store.Jobs.Where(x => x.ActualCost > 0).Sum(x => x.EstimatedCost - x.ActualCost);
}
