using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkFlow.Models;
using WorkFlow.Services;
namespace WorkFlow.Pages.Quotes;
public class IndexModel(DemoStore store) : PageModel { public IReadOnlyList<Quote> Quotes => store.Quotes; }
