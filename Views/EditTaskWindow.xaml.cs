using System;
using System.Windows;
using TaskTimeManager.Models;

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
            CurrentTask.Name = NameTextBox.Text;
            CurrentTask.DueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
            CurrentTask.Priority = PriorityTextBox.Text;
            CurrentTask.Status = StatusTextBox.Text;

            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
