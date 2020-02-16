using System.Windows.Forms;

namespace TimeKeeping.App.Helpers
{
    class ShowMessage
    {
        public ShowMessage()
        {

        }

        public static void ShowMessageBox(int messageType)
        {
            switch (messageType)
            {
                case 1:
                    MessageBox.Show("Record successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Record successfully Updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Record already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static void CustomErrorMessage(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void CustomEUpdateMessage(string updateMessage)
        {
            MessageBox.Show(updateMessage, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
