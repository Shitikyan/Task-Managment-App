using System.Windows;

namespace TaskTimeManager.Views
{
    public partial class AddTaskWindow : Window
    {
        public Models.Task NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
            NewTask = new Models.Task();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateInputs();

                NewTask.Name = NameTextBox.Text;
                NewTask.DueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
                NewTask.Priority = PriorityTextBox.Text;
                NewTask.Status = StatusTextBox.Text;

                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                throw new InvalidOperationException("Task Name cannot be empty.");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
