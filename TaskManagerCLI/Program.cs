using TaskManagerCLI.Helpers;
using TaskManagerCLI.Models;
using TaskManagerCLI.Services;

namespace TaskManagerCLI
{
    static class Program
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();
            ViewTasksMenu(manager);
        }

        static void ViewTasksMenu(TaskManager manager)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== TASK MANAGER CLI ===");
                Console.WriteLine();
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Update Task");
                Console.WriteLine("5. Delete Task");
                Console.WriteLine("6. Save and Exit");
                Console.WriteLine();
                Console.Write("Select an option: ");

                string? option = Console.ReadLine();
                bool isOptionValid = int.TryParse(option, out int selectedOption);
                if(isOptionValid == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    continue;
                }

                
                switch (selectedOption)
                {
                    case (int)Options.AddTask:
                        {
                            AddTaskMenu(manager);
                        }
                        break;
                    case (int)Options.ViewTask:
                        {
                            ListTasksMenu(manager);
                        }
                        break;
                    case (int)Options.CompleteTask:
                        {
                            CompleteTaskMenu(manager);
                        }
                        break;
                    case (int)Options.UpdateTask:
                        {
                            UpdateTaskMenu(manager);
                        }
                        break;
                    case (int)Options.DeleteTask:
                        {
                            DeleteTaskMenu(manager);
                        }
                        break;
                    case (int)Options.SaveTask:
                        {
                            manager.SaveTasks();
                            Console.WriteLine("Exiting...");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option. Please try again.");
                            Pause();
                        }
                        break;

                }
            }
        }

        static void AddTaskMenu(TaskManager manager)
        {
            Console.Clear();
            Console.WriteLine("=== ADD TASK MENU ===");
            Console.WriteLine();
            string title = InputHelper.ReadRequiredText("Enter task title: ");
            string description = InputHelper.ReadRequiredText("Enter task description: ");
            manager.AddTask(title, description);
            Console.WriteLine("Task added successfully");
            Pause();
        }

        static void ListTasksMenu(TaskManager manager)
        {
            Console.Clear();
            Console.WriteLine("=== LIST TASK MENU ===");
            Console.WriteLine();
            
            if (manager.GetAllTasks().Count == 0)
            {
                Console.WriteLine("No tasks found.");
                Pause();
                return;
            }

            foreach (var task in manager.GetAllTasks())
            {
                Console.WriteLine($"ID: {task.Id} " +
                    $"| Title: {task.Title} " +
                    $"| Description: {task.Description} " +
                    $"| Completed: {task.IsCompleted} " +
                    $"| Created At: {task.CreatedAt}");
            }
            Pause();
        }

        static void CompleteTaskMenu(TaskManager manager)
        {
            Console.Clear();
            Console.WriteLine("=== COMPLETE TASK MENU ===");
            Console.WriteLine();

            if (manager.GetAllTasks().Count == 0)
            {
                Console.WriteLine("No tasks found.");
                Pause();
                return;
            }

            foreach (var task in manager.GetAllTasks())
            {
                Console.WriteLine($"ID: {task.Id} " +
                    $"| Title: {task.Title} " +
                    $"| Description: {task.Description} " +
                    $"| Completed: {task.IsCompleted} " +
                    $"| Created At: {task.CreatedAt}");
            }

            Console.WriteLine();
            int id = InputHelper.ReadRequiredInt("Enter task ID to complete: ");
            bool isTaskCompleted = manager.CompleteTask(id);

            Console.WriteLine(isTaskCompleted
                ? $"Task with ID {id} marked as completed."
                : $"Task with ID {id} not found.");
            Pause();
        }

        static void UpdateTaskMenu(TaskManager manager)
        {
            Console.Clear();
            Console.WriteLine("=== UPDATE TASK MENU ===");
            Console.WriteLine();

            var tasks = manager.GetAllTasks();

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                Pause();
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id} " +
                    $"| Title: {task.Title} " +
                    $"| Description: {task.Description} " +
                    $"| Completed: {task.IsCompleted} " +
                    $"| Created At: {task.CreatedAt}");
            }

            Console.WriteLine();
            int id = InputHelper.ReadRequiredInt("Enter task ID to update: ");

            var foundedTask = tasks.FirstOrDefault(task => task.Id == id);

            if (foundedTask == null)
            {
                Console.WriteLine($"Task with ID {id} not found.");
                Pause();
                return;
            }

            string title = InputHelper.ReadRequiredText("Enter new task title: ");
            string description = InputHelper.ReadRequiredText("Enter new task description: ");

            manager.UpdateTask(id, title, description);
            Console.WriteLine($"Task with ID {id} updated successfully.");
            Pause();
        }

        static void DeleteTaskMenu(TaskManager manager)
        {
            Console.Clear();
            Console.WriteLine("=== DELETE TASK MENU ===");
            Console.WriteLine();

            if (manager.GetAllTasks().Count == 0)
            {
                Console.WriteLine("No tasks found.");
                Pause();
                return;
            }

            foreach (var task in manager.GetAllTasks())
            {
                Console.WriteLine($"ID: {task.Id} " +
                    $"| Title: {task.Title} " +
                    $"| Description: {task.Description} " +
                    $"| Completed: {task.IsCompleted} " +
                    $"| Created At: {task.CreatedAt}");
            }

            Console.WriteLine();
            int id = InputHelper.ReadRequiredInt("Enter task ID to delete: ");
           
            bool isTaskDeleted = manager.DeleteTask(id);
            Console.WriteLine(isTaskDeleted 
                ? $"Task with ID {id} deleted successfully." 
                : $"Task with ID {id} not found");
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

    }
}