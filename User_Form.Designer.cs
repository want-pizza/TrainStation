namespace TrainStation
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
            this.combo_box_town = new System.Windows.Forms.ComboBox();
            this.combo_box_time = new System.Windows.Forms.ComboBox();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.list_ticket = new System.Windows.Forms.ListBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_take_town = new System.Windows.Forms.Label();
            this.label_take_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // combo_box_town
            // 
            this.combo_box_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_town.FormattingEnabled = true;
            this.combo_box_town.Location = new System.Drawing.Point(489, 149);
            this.combo_box_town.Name = "combo_box_town";
            this.combo_box_town.Size = new System.Drawing.Size(248, 38);
            this.combo_box_town.TabIndex = 0;
            this.combo_box_town.SelectedIndexChanged += new System.EventHandler(this.combo_box_town_SelectedIndexChanged);
            // 
            // combo_box_time
            // 
            this.combo_box_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_time.FormattingEnabled = true;
            this.combo_box_time.Location = new System.Drawing.Point(489, 339);
            this.combo_box_time.Name = "combo_box_time";
            this.combo_box_time.Size = new System.Drawing.Size(248, 38);
            this.combo_box_time.TabIndex = 1;
            this.combo_box_time.Visible = false;
            this.combo_box_time.SelectedIndexChanged += new System.EventHandler(this.combo_box_time_SelectedIndexChanged);
            // 
            // button_accept
            // 
            this.button_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_accept.Location = new System.Drawing.Point(63, 542);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(196, 80);
            this.button_accept.TabIndex = 2;
            this.button_accept.Text = "Замовити";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(63, 420);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(196, 80);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Скинути форму";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // list_ticket
            // 
            this.list_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_ticket.FormattingEnabled = true;
            this.list_ticket.ItemHeight = 22;
            this.list_ticket.Location = new System.Drawing.Point(352, 420);
            this.list_ticket.Name = "list_ticket";
            this.list_ticket.Size = new System.Drawing.Size(385, 202);
            this.list_ticket.TabIndex = 4;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_last_name.Location = new System.Drawing.Point(512, 54);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(225, 37);
            this.textBox_last_name.TabIndex = 5;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_first_name.Location = new System.Drawing.Point(132, 54);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(195, 37);
            this.textBox_first_name.TabIndex = 6;
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_first_name.Location = new System.Drawing.Point(57, 57);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(69, 31);
            this.label_first_name.TabIndex = 7;
            this.label_first_name.Text = "Ім\'я:";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_last_name.Location = new System.Drawing.Point(358, 57);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(143, 31);
            this.label_last_name.TabIndex = 8;
            this.label_last_name.Text = "Прізвище:";
            // 
            // label_take_town
            // 
            this.label_take_town.AutoSize = true;
            this.label_take_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_take_town.Location = new System.Drawing.Point(57, 152);
            this.label_take_town.Name = "label_take_town";
            this.label_take_town.Size = new System.Drawing.Size(379, 31);
            this.label_take_town.TabIndex = 9;
            this.label_take_town.Text = "Виберіть місце призначення:";
            // 
            // label_take_time
            // 
            this.label_take_time.AutoSize = true;
            this.label_take_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_take_time.Location = new System.Drawing.Point(57, 342);
            this.label_take_time.Name = "label_take_time";
            this.label_take_time.Size = new System.Drawing.Size(359, 31);
            this.label_take_time.TabIndex = 10;
            this.label_take_time.Text = "Виберіть час відправлення:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Виберіть дату поїздки:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(489, 251);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(248, 28);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 672);
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
            this.Name = "User_Form";
            this.Text = "Білет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_box_town;
        private System.Windows.Forms.ComboBox combo_box_time;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox list_ticket;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_take_town;
        private System.Windows.Forms.Label label_take_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}