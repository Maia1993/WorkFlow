using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkFlow.Models;
using WorkFlow.Services;
namespace WorkFlow.Pages.Jobs;
public class IndexModel(DemoStore store) : PageModel { public IReadOnlyList<Job> Jobs => store.Jobs; }
