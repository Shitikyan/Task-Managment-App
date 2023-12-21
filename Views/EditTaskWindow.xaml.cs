using System.Windows;
using TaskTimeManager.Models; // Make sure to import the namespace for your Task model

namespace TaskTimeManager.Views
{
    public partial class EditTaskWindow : Window
    {
        public Models.Task CurrentTask { get; private set; }

        public EditTaskWindow(Models.Task taskToEdit)
        {
            InitializeComponent();
            CurrentTask = taskToEdit;
            PopulateFields();
        }

        private void PopulateFields()
        {
            NameTextBox.Text = CurrentTask.Name;
            DueDatePicker.SelectedDate = CurrentTask.DueDate;
            PriorityTextBox.Text = CurrentTask.Priority;
            StatusTextBox.Text = CurrentTask.Status;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Update CurrentTask with new values from UI
            CurrentTask.Name = NameTextBox.Text;
            CurrentTask.DueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
            CurrentTask.Priority = PriorityTextBox.Text;
            CurrentTask.Status = StatusTextBox.Text;

            // TODO: Implement validation and database update logic here

            this.DialogResult = true; // Closes the window and returns DialogResult.OK
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; // Closes the window and returns DialogResult.Cancel
        }
    }
}
