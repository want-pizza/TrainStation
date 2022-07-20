﻿using System;
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
    partial class Cashier_Form : Form
    {
        List<string> times = new List<string>();
        public Cashier_Form()
        {
            InitializeComponent();
            textBox_times.KeyDown += EnterKey;
            FormClosed += Cashier_Form_Close;
        }
        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                times.Add(textBox_times.Text);
                list_times.Items.Add(textBox_times.Text);
                textBox_times.Text = "";
            }
        }
        private void button_reset_Click(object sender, EventArgs e)     //Кнопка скинути форму
        {
            Reset_Form();
        }
        private void button_add_train_Click(object sender, EventArgs e)     //Кнопка замовити квиток
        {
            try
            {
                Trains.AddNewTrain(new Train(Convert.ToInt32(textBox_number.Text), textBox_town.Text, textBox_stops.Text, new List<string>(times), (int)numericUpDown_free_places.Value, Convert.ToInt32(textBox_price.Text)));
                Reset_Form();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно заповнені дані", "Упс!");
            }
            
        }
        private void Reset_Form()       //Метод скидання форми
        {
            textBox_number.Text = "";
            textBox_town.Text = "";
            textBox_stops.Text = "";
            textBox_times.Text = "";
            times.Clear();
            list_times.Items.Clear();
            textBox_price.Text = "";
            numericUpDown_free_places.Value = numericUpDown_free_places.Minimum;
        }
        private void Cashier_Form_Close(object sender, FormClosedEventArgs e)      //Закриття форми
        {
            new Main_Form().Show();
        }
    }
}
