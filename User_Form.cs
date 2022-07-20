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
                if (train.Free_Places[combo_box_time.SelectedIndex] > 0)
                {
                    train.Free_Places[combo_box_time.SelectedIndex] -= 1;
                    Random random = new Random();
                    MessageBox.Show($"Номер вашого білету: {random.Next(100, 2000)}", "Дякуємо!");
                }
                else
                {
                    MessageBox.Show("На жаль усі місця заповнені :(", "Ой");
                }
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
            }
            combo_box_time.Items.Clear();
            combo_box_time.Text = "";
            SetTimes();
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
                        char[] temp = str.ToCharArray();
                        char[] hour = new char[2];
                        char[] minute = new char[2];
                        bool b = false;
                        for (int i = 0; i < 2; i++)
                        {                            
                            if (temp[i] != ':')
                            {
                                hour[i] = temp[i];
                            }
                        }   
                        for(int i = 0, j = 0; i < 5 && j != 2; i++)
                        {
                            if (b)
                            {
                                minute[j] = temp[i];
                                j++;
                            }
                            if (temp[i] == ':')
                            {
                                b = true;
                            }
                        }
                        string _hour = new string(hour);
                        string _minute = new string(minute);
                        if (!(dateTimePicker.Value.Day > DateTime.Now.Day))
                        {
                            if(Convert.ToInt32(_hour) > DateTime.Now.Hour)
                            {
                                combo_box_time.Items.Add(str);
                            }
                            else if(Convert.ToInt32(_hour) == DateTime.Now.Hour)
                            {
                                if(Convert.ToInt32(_minute) > (DateTime.Now.Minute + 1))
                                {
                                    combo_box_time.Items.Add(str);
                                }
                            }
                        }
                        else
                        {
                            combo_box_time.Items.Add(str);
                        }
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
            list_ticket.Items.Add($"К-сть вільних місць: {train.Free_Places[combo_box_time.SelectedIndex]}");
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
