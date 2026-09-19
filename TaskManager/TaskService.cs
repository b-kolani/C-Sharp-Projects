
using System.Collections;
using System.Collections.ObjectModel;

public class TaskService
{
    private List<TaskItem>  tasks = new List<TaskItem>();
    private int nextId = 1;

    public void AddTask(string title, string description)
    {
        TaskItem newTask = new TaskItem(title, description);

        newTask.Id = nextId;
        nextId++;
        
        tasks.Add(newTask);
    }

    public TaskItem[] GetTasks()
    {
        TaskItem[] tasksList = new TaskItem[tasks.Count];

        tasks.CopyTo(tasksList, 0);

        return tasksList;
    }

    public void UpdateTask(int id, string newTitle, string newDescription)
    {
        TaskItem? taskToUpdate = tasks.FirstOrDefault(task => task.Id == id);

        if (taskToUpdate == null)
            throw new Exception("Task item with id " + id + " not found");
        
        taskToUpdate.Title = newTitle;
        taskToUpdate.Description = newDescription;
    }

    public void DeleteTask(int id)
    {
        TaskItem? foundTask = tasks.FirstOrDefault(task => task.Id == id);

        if (foundTask == null)
            throw new Exception("Task with id " + id + " not found");

        tasks.Remove(foundTask);
    }
}