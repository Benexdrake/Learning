using System;
using System.Drawing.Printing;
using System.Printing;
using System.Windows;

namespace WPF_Test
{
    public partial class LoginWindow : Window
    {
        string username = "Test";
        string password = "111111";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            PrintServer myPrintServer = new PrintServer(@"\\BBQ");

            // List the print server's queues
            PrintQueueCollection myPrintQueues = myPrintServer.GetPrintQueues();
            String printQueueNames = "My Print Queues:\n\n";
            foreach (PrintQueue pq in myPrintQueues)
            {
                printQueueNames += "\t" + pq.Name + "\n";
            }
            MessageBox.Show(printQueueNames);
            

            //if(tBox_Username.Text.Equals(username) && tBox_Password.Text.Equals(password))
            //{
            //    MessageBox.Show("Yay");
            //    MainWindow main = new MainWindow();
            //    main.Show();
            //}
        }
    }
}
