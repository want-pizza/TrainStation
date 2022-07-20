﻿namespace TrainStation
{
    partial class User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_take_time = new System.Windows.Forms.Label();
            this.label_take_town = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.list_ticket = new System.Windows.Forms.ListBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.combo_box_time = new System.Windows.Forms.ComboBox();
            this.combo_box_town = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(370, 202);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(187, 24);
            this.dateTimePicker.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Виберіть дату поїздки:";
            // 
            // label_take_time
            // 
            this.label_take_time.AutoSize = true;
            this.label_take_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_take_time.Location = new System.Drawing.Point(46, 276);
            this.label_take_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_take_time.Name = "label_take_time";
            this.label_take_time.Size = new System.Drawing.Size(295, 26);
            this.label_take_time.TabIndex = 23;
            this.label_take_time.Text = "Виберіть час відправлення:";
            // 
            // label_take_town
            // 
            this.label_take_town.AutoSize = true;
            this.label_take_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_take_town.Location = new System.Drawing.Point(46, 122);
            this.label_take_town.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_take_town.Name = "label_take_town";
            this.label_take_town.Size = new System.Drawing.Size(309, 26);
            this.label_take_town.TabIndex = 22;
            this.label_take_town.Text = "Виберіть місце призначення:";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_last_name.Location = new System.Drawing.Point(272, 45);
            this.label_last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(116, 26);
            this.label_last_name.TabIndex = 21;
            this.label_last_name.Text = "Прізвище:";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_first_name.Location = new System.Drawing.Point(46, 45);
            this.label_first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(56, 26);
            this.label_first_name.TabIndex = 20;
            this.label_first_name.Text = "Ім\'я:";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_first_name.Location = new System.Drawing.Point(102, 42);
            this.textBox_first_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(147, 31);
            this.textBox_first_name.TabIndex = 19;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_last_name.Location = new System.Drawing.Point(387, 42);
            this.textBox_last_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(170, 31);
            this.textBox_last_name.TabIndex = 18;
            // 
            // list_ticket
            // 
            this.list_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_ticket.FormattingEnabled = true;
            this.list_ticket.ItemHeight = 17;
            this.list_ticket.Location = new System.Drawing.Point(267, 340);
            this.list_ticket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_ticket.Name = "list_ticket";
            this.list_ticket.Size = new System.Drawing.Size(290, 157);
            this.list_ticket.TabIndex = 17;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(50, 340);
            this.button_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(147, 65);
            this.button_reset.TabIndex = 16;
            this.button_reset.Text = "Скинути форму";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // button_accept
            // 
            this.button_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_accept.Location = new System.Drawing.Point(50, 439);
            this.button_accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(147, 65);
            this.button_accept.TabIndex = 15;
            this.button_accept.Text = "Замовити";
            this.button_accept.UseVisualStyleBackColor = true;
            // 
            // combo_box_time
            // 
            this.combo_box_time.Enabled = false;
            this.combo_box_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_time.FormattingEnabled = true;
            this.combo_box_time.Location = new System.Drawing.Point(370, 274);
            this.combo_box_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_box_time.Name = "combo_box_time";
            this.combo_box_time.Size = new System.Drawing.Size(187, 33);
            this.combo_box_time.TabIndex = 14;
            this.combo_box_time.SelectedIndexChanged += new System.EventHandler(this.combo_box_time_SelectedIndexChanged);
            // 
            // combo_box_town
            // 
            this.combo_box_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_town.FormattingEnabled = true;
            this.combo_box_town.Location = new System.Drawing.Point(370, 119);
            this.combo_box_town.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_box_town.Name = "combo_box_town";
            this.combo_box_town.Size = new System.Drawing.Size(187, 33);
            this.combo_box_town.TabIndex = 13;
            this.combo_box_town.SelectedIndexChanged += new System.EventHandler(this.combo_box_town_SelectedItemChanged);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 546);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_take_time);
            this.Controls.Add(this.label_take_town);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.list_ticket);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.combo_box_time);
            this.Controls.Add(this.combo_box_town);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User_Form";
            this.Text = "User_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_take_time;
        private System.Windows.Forms.Label label_take_town;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.ListBox list_ticket;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.ComboBox combo_box_time;
        private System.Windows.Forms.ComboBox combo_box_town;
    }
}