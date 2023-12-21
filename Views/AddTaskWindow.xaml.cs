using System.Windows;
using TaskTimeManager.Models; // Import the namespace for your Task model

namespace TaskTimeManager.Views
{
    public partial class AddTaskWindow : Window
    {
        public Models.Task NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
            NewTask = new Models.Task(); // Initialize a new Task
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Update NewTask with values from the UI
            NewTask.Name = NameTextBox.Text;
            NewTask.DueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
            NewTask.Priority = PriorityTextBox.Text;
            NewTask.Status = StatusTextBox.Text;

            // TODO: Implement validation for the NewTask object

            this.DialogResult = true; // Closes the window and indicates success
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; // Closes the window and indicates cancellation
        }
    }
}
