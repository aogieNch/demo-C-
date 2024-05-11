public class HomeController : Controller
{
    private static List<Task> tasks = new List<Task>(); // In-memory task list

    public IActionResult Index()
    {
        return View(tasks);
    }

    [HttpPost]
    public IActionResult AddTask(string description)
    {
        tasks.Add(new Task { Id = tasks.Count + 1, Description = description, Completed = false });
        return Json(tasks); // Return updated task list as JSON
    }
}
