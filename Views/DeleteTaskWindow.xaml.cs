using System.Windows;

namespace TaskTimeManager.Views
{
    public partial class DeleteTaskWindow : Window
    {
        public DeleteTaskWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // Add delete logic here
            this.DialogResult = true;
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
