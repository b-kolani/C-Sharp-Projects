
List<TaskItem>  tasks = new List<TaskItem>();

tasks.Add(
    new TaskItem(
        "Learn C#", 
        "Learning C# through hands-on project"
    )
);

tasks.Add(
    new TaskItem(
        "Learn ASP.Net Core", 
        "Learning ASP.Net Core through hands-on project"
    )
);

tasks.Add(
    new TaskItem(
        "Learn Angular", 
        "Learning Angular through hands-on project"
    )
);

int id = 1;

foreach (TaskItem task in tasks)
{
    task.Id = id;
    id++;
}

TaskItem? foundTask = tasks.FirstOrDefault(task => task.Id == 2);

Console.WriteLine(
    "Id: " + foundTask?.Id + "\n" + 
    "Title: " + foundTask?.Title + "\n" + 
    "Description: " + foundTask?.Description + "\n" +
    "Created: " + foundTask?.CreatedAt + "\n"
);