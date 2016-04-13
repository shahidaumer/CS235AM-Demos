﻿using System;
using System.Collections.Generic;

namespace ToDo
{
	public class Task
	{
		public string Description { get; set;}
		public int Priority { get; set;}
		public DateTime DueDate {get; set;}
	}


	public class TaskMaster
	{
		private List<Task> tasks = new List<Task>();

		public List<Task> Tasks {get { return tasks; } }

		// Temporary, for testing
		public TaskMaster()
		{
			tasks.Add(new Task() {Description = "My first horrible task"});
			tasks.Add(new Task() {Description = "A not so bad task"});
			tasks.Add(new Task() {Description = "A fun and easy task"});
		}

		public string GetTaskDescriptions()
		{
			string descriptions = "";
			foreach (Task t in tasks) {
				descriptions += t.Description + "\n\r";
			}

			return descriptions;
		}

		// TODO Add code to add tasks to the list


	}
}
