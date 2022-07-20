using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            FormClosed += Main_Form_Close;
        }
        private void button_user_Click(object sender, EventArgs e)
        {
            new User_Form().Show();            
        }
        private void button_cashier_Click(object sender, EventArgs e)
        {
            new Cashier_Form().Show();
        }
        private void Main_Form_Close(object sender, FormClosedEventArgs e)   //Закриття головної програми
        {
            Application.Exit();
        }
    }
}
