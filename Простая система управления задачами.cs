using System;
using System.Collections.Generic;

class TaskManager
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Задача добавлена.");
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Задача удалена.");
        }
        else
        {
            Console.WriteLine("Неверный индекс задачи.");
        }
    }

    public void EditTask(int index, string newTask)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index] = newTask;
            Console.WriteLine("Задача отредактирована.");
        }
        else
        {
            Console.WriteLine("Неверный индекс задачи.");
        }
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Редактировать задачу");
            Console.WriteLine("4. Просмотреть задачи");
            Console.WriteLine("5. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите новую задачу: ");
                    string newTask = Console.ReadLine();
                    taskManager.AddTask(newTask);
                    break;
                case 2:
                    Console.Write("Введите индекс задачи для удаления: ");
                    int indexToRemove = Convert.ToInt32(Console.ReadLine()) - 1;
                    taskManager.RemoveTask(indexToRemove);
                    break;
                case 3:
                    Console.Write("Введите индекс задачи для редактирования: ");
                    int indexToEdit = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Введите новую версию задачи: ");
                    string editedTask = Console.ReadLine();
                    taskManager.EditTask(indexToEdit, editedTask);
                    break;
                case 4:
                    taskManager.ViewTasks();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }
}