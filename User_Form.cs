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
        List<Train> trains;
        Train train;
        public User_Form()
        {
            InitializeComponent();
            FormClosed += User_Form_Close;
            trains = Trains.GetTrains;
            foreach(Train t in trains)
            {
                combo_box_town.Items.Add(t.Town);
            }
        }
        private void button_reset_Click(object sender, EventArgs e)     //Кнопка скинути форму
        {
            Reset_Form();
        }
        private void button_accept_Click(object sender, EventArgs e)        //Кнопка замовити квиток
        {
            if (textBox_first_name.Text != "" && textBox_last_name.Text != "" && combo_box_town.Text != "" && combo_box_time.Text != "")
            {
                Random random = new Random();
                MessageBox.Show($"Номер вашого білету: {random.Next(100, 2000)}", "Дякуємо!");
                Reset_Form();
            }
            else
            {
                MessageBox.Show("Заповніть усі поля!", "Помилка!");
            }
        }
        private void combo_box_town_SelectedItemChanged(object sender, EventArgs e)        //Вибір місця призначення
        {
            list_ticket.Items.Clear();
            dateTimePicker.Enabled = true;
            combo_box_time.Items.Clear();
            combo_box_time.Text = "";
            combo_box_time.Enabled = true;
            SetTimes();
            dateTimePicker.Value = DateTime.Now;
            train.Date = dateTimePicker.Value;           
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < DateTime.Now)
            {
                dateTimePicker.Value = DateTime.Now;
                MessageBox.Show("Ви не можете замовити квиток на поїзд, котрий відправився");
            }
            list_ticket.Items.Clear();
            train.Date = dateTimePicker.Value;
        }
        private void combo_box_time_SelectedIndexChanged(object sender, EventArgs e)        //Вибір часу відправлення
        {
            Print_Ticket();
        }
        private void SetTimes()
        {
            foreach(Train t in trains)
            {
                if (combo_box_town.SelectedItem.ToString() == t.Town)
                {
                    foreach (string str in t.Time)
                    {
                        char[] temp = new char[4];
                        int k = 0;
                        for(int i = 0; i < str.Length; i++, k++)
                        {
                            if (str[i] != ':')
                            {
                                temp[i] = str[i];
                            }
                            else
                            {
                                k--;
                            }
                        }
                        if(DateTime.Now.Hour*100+DateTime.Now.Minute <= Convert.ToInt32(temp)) 
                        combo_box_time.Items.Add(str);
                    }
                    train = t;
                }
            }
        }
        private void Print_Ticket()    //Друк білету
        {
            list_ticket.Items.Clear();
            list_ticket.Items.Add($"Номер потягу: {train.Number}");
            list_ticket.Items.Add($"Місце призначення: {train.Town}");
            list_ticket.Items.Add($"Проміжні зупинки: {train.Stops}");
            list_ticket.Items.Add($"Дата поїздки: {train.Date.Day}.{train.Date.Month}.{train.Date.Year}");
            list_ticket.Items.Add($"Час відправлення: {combo_box_time.Text}");
            list_ticket.Items.Add($"К-сть вільних місць: {train.Free_Places}");
            list_ticket.Items.Add("");
            list_ticket.Items.Add($"Ціна: {train.Price}");
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
        }
        private void User_Form_Close(object sender, FormClosedEventArgs e)      //Закриття форми
        {
            new Main_Form().Show();
        }
    }
}
