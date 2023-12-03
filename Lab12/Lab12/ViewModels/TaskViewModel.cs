using Lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    public class TaskViewModel : ViewModelsBasic
    {

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        string selectedStatus;
        public string SelectedStatus
        {
            get { return selectedStatus; }
            set
            {
                if (selectedStatus != value)
                {
                    selectedStatus = value;
                    OnPropertyChanged();
                }
            }
        }

        ObservableCollection<TaskModels> tasks;
        public ObservableCollection<TaskModels> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        private List<TaskModels> TasksModels;
        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskModels>();
            TasksModels = new List<TaskModels>();

            Save = new Command(() =>
            {
                TaskModels task = new TaskModels();
                task.Title = this.Title;
                task.Description = this.Description;
                task.Status = this.SelectedStatus;
                TasksModels.Add(task);

            });
            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModels>(TasksModels);
            });
        }

    }
}