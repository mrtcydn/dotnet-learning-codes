using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using TaskManagerCLI.Models;

namespace TaskManagerCLI.Services
{
    internal class TaskManager
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public void AddTask(string title, string description)
        {
            TaskItem newTask = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                IsCompleted = false,
                CreatedAt = DateTime.Now
            };

            _tasks.Add(newTask);
        }

        public List<TaskItem> GetAllTasks()
        {
            return _tasks.ToList();
        }
        public bool CompleteTask(int taskId)
        {
            TaskItem? completedTask = _tasks.Find(task => task.Id == taskId);
            if (completedTask == null)
            {
                return false;
            }
            completedTask.IsCompleted = true;
            Console.WriteLine();
            return true;
        }

        public bool UpdateTask(int id, string title, string description)
        {
            TaskItem? updatedTask = _tasks.FirstOrDefault(task => task.Id == id);
            if(updatedTask == null)
            {
                return false;
            }

            updatedTask.Title = title;
            updatedTask.Description = description;
            Console.WriteLine();
            return true;
        }

        public bool DeleteTask(int taskId)
        {
            var deletedTask = _tasks.FirstOrDefault(task => task.Id == taskId);
            if (deletedTask == null)
            {
                return false;
            }
            _tasks.Remove(deletedTask);
            Console.WriteLine();
            return true;
        }

        public void SaveTasks()
        {
            if (_tasks.Count == 0)
            {
                return;
            }
            string filePath = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json";
            var jsonOption = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(_tasks,jsonOption);

            File.WriteAllText(filePath, json);
        }
    }
}
