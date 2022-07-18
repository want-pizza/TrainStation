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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            FormClosed += User_Form_Close;
        }
        private void button_reset_Click(object sender, EventArgs e)     //Кнопка скинути форму
        {
            Reset_Form();
        }
        private void button_accept_Click(object sender, EventArgs e)        //Кнопка замовити квиток
        {

            MessageBox.Show("");
            Reset_Form();
        }
        private void combo_box_town_SelectedIndexChanged(object sender, EventArgs e)        //Вибір місця призначення
        {
            dateTimePicker.Enabled = true;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)        //Вибір дати поїздки
        {
            combo_box_time.Enabled = true;
        }
        private void combo_box_time_SelectedIndexChanged(object sender, EventArgs e)        //Вибір часу відправлення
        {
            Print_Ticket();
        }
        private void Print_Ticket()    //Друк білету
        {
            /*list_ticket.Items.Add($"Номер потягу: {.number}");
            list_ticket.Items.Add($"Місце призначення: {.town}");
            list_ticket.Items.Add($"Дата поїздки: {.date}");
            list_ticket.Items.Add($"Час відправлення: {.time}");
            list_ticket.Items.Add($"К-сть вільних місць: {.free_places}");
            list_ticket.Items.Add("");
            list_ticket.Items.Add($"Ціна: {.price}");*/
        }
        private void Reset_Form()       //Метод скидання форми
        {
            textBox_first_name.Text = "";
            textBox_last_name.Text = "";
            combo_box_town.Text = "";
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
            combo_box_time.Text = "";
            combo_box_time.Enabled = false;
            list_ticket.Items.Clear();
            button_accept.Enabled = false;  
        }
        private void User_Form_Close(object sender, FormClosedEventArgs e)      //Закриття форми
        {

        }
    }
}
