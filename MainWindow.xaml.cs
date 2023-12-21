using TaskTimeManager.Views;
using System.Windows;
using System.Collections.ObjectModel;
using TaskTimeManager.Models;
using System.Linq;
using Task = TaskTimeManager.Models.Task;

namespace TaskTimeManager
{
    public partial class MainWindow : Window
    {
        // Assuming you have a DbContext or similar data source
        private TaskContext _context = new TaskContext();
        public ObservableCollection<Task> Tasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>(_context.Tasks.ToList());
            this.DataContext = this;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true)
            {
                Task newTask = addTaskWindow.NewTask;
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
                Tasks.Add(newTask);
            }
        }

        private void EditTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListView.SelectedItem is Task selectedTask)
            {
                var editTaskWindow = new EditTaskWindow(selectedTask);
                if (editTaskWindow.ShowDialog() == true)
                {
                    _context.SaveChanges();
                    RefreshTasks();
                }
            }
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListView.SelectedItem is Task selectedTask)
            {
                var deleteTaskWindow = new DeleteTaskWindow();
                if (deleteTaskWindow.ShowDialog() == true)
                {
                    _context.Tasks.Remove(selectedTask);
                    _context.SaveChanges();
                    Tasks.Remove(selectedTask);
                }
            }
        }

        private void CheckNotificationsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Check Notifications button clicked");
            // Implement notification logic here
        }

        private void RefreshTasks()
        {
            Tasks.Clear();
            foreach (var task in _context.Tasks.ToList())
            {
                Tasks.Add(task);
            }
        }
    }
}
