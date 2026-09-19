TaskService taskService = new TaskService();


taskService.AddTask(
    "Learn C#",
    "Learning C# through hands-on projects"
);

taskService.AddTask(
    "Learn ASP.Net Core",
    "Learning ASP.Net Core through hands-on projects"
);

taskService.AddTask(
    "Learn Angular",
    "Learning Angular through hands-on projects"
);

taskService.UpdateTask(
    2,
    "Learn ASP.Net Core Seriously",
    "Learning deeply ASP.Net Core"
);

taskService.DeleteTask(3);

TaskItem[] tasksList = taskService.GetTasks();


foreach (TaskItem task in tasksList)
{
    Console.WriteLine("Id: " + task.Id + "\n" + 
        "Title: " + task.Title + "\n" +
        "Description: " + task.Description + "\n" + 
        "Completed: " + task.IsCompleted + "\n");
}


// List<TaskItem>  tasks = new List<TaskItem>();

// tasks.Add(
//     new TaskItem(
//         "Learn C#", 
//         "Learning C# through hands-on project"
//     )
// );

// tasks.Add(
//     new TaskItem(
//         "Learn ASP.Net Core", 
//         "Learning ASP.Net Core through hands-on project"
//     )
// );

// tasks.Add(
//     new TaskItem(
//         "Learn Angular", 
//         "Learning Angular through hands-on project"
//     )
// );

// tasks.Add(
//     new TaskItem(
//         "Test",
//         "Task Item to test the delete method on"
//     )
// );

// int id = 1;

// foreach (TaskItem task in tasks)
// {
//     task.Id = id;
//     id++;
// }

// TaskItem?    getTaskItem(int id)
// {
//     TaskItem? foundTask = tasks.FirstOrDefault(task => task.Id == id);
//     return foundTask; 
// }

// TaskItem? foundTask = getTaskItem(2);

// Console.WriteLine(
//     "Id: " + foundTask?.Id + "\n" + 
//     "Title: " + foundTask?.Title + "\n" + 
//     "Description: " + foundTask?.Description + "\n" +
//     "Created: " + foundTask?.CreatedAt + "\n"
// );

// void    UpdateTask(int id, string newTitle)
// {
//     TaskItem? foundTask = tasks.FirstOrDefault(task => task.Id == id);

//     if (foundTask == null)
//         throw new Exception("Task Item with id " + id + " not found");
    
//     foundTask.Title = newTitle;
// }

// UpdateTask(2, "Learn ASP.Net Core seriously");

// foreach (TaskItem task in tasks) {
//     Console.WriteLine(task.Title);
// }

// void    DeleteTask(int id)
// {
//     TaskItem? foundTask = tasks.FirstOrDefault(task => task.Id == id);

//     if (foundTask == null)
//         throw new Exception("Task item with id " + id + " not found");
    
//     tasks.Remove(foundTask);
// }

// int taskIdToDelete = 4;

// try
// {
//     DeleteTask(taskIdToDelete);

//     Console.WriteLine("Task with id " + taskIdToDelete + " deleted.");
// }
// catch (System.Exception)
// {
//     // throw new Exception("Task Item to delete not found");
//     Console.Error.WriteLine("Task with id " + taskIdToDelete + " not Found");
// }

// foreach (TaskItem task in tasks)
// {
//     Console.WriteLine(task.Title);
// }