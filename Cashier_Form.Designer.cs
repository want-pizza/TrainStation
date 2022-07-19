namespace TrainStation
{
    partial class Cashier_Form
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
            this.label_new_time = new System.Windows.Forms.Label();
            this.label_new_town = new System.Windows.Forms.Label();
            this.textBox_town = new System.Windows.Forms.TextBox();
            this.textBox_stops = new System.Windows.Forms.TextBox();
            this.label_new_stops = new System.Windows.Forms.Label();
            this.textBox_times = new System.Windows.Forms.TextBox();
            this.list_times = new System.Windows.Forms.ListBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_free_places = new System.Windows.Forms.Label();
            this.numericUpDown_free_places = new System.Windows.Forms.NumericUpDown();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_add_train = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_free_places)).BeginInit();
            this.SuspendLayout();
            // 
            // label_new_time
            // 
            this.label_new_time.AutoSize = true;
            this.label_new_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_new_time.Location = new System.Drawing.Point(50, 262);
            this.label_new_time.Name = "label_new_time";
            this.label_new_time.Size = new System.Drawing.Size(246, 31);
            this.label_new_time.TabIndex = 29;
            this.label_new_time.Text = "Час відправлення:";
            // 
            // label_new_town
            // 
            this.label_new_town.AutoSize = true;
            this.label_new_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_new_town.Location = new System.Drawing.Point(50, 102);
            this.label_new_town.Name = "label_new_town";
            this.label_new_town.Size = new System.Drawing.Size(265, 31);
            this.label_new_town.TabIndex = 28;
            this.label_new_town.Text = "Місце призначення:";
            // 
            // textBox_town
            // 
            this.textBox_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_town.Location = new System.Drawing.Point(483, 102);
            this.textBox_town.Name = "textBox_town";
            this.textBox_town.Size = new System.Drawing.Size(248, 37);
            this.textBox_town.TabIndex = 30;
            // 
            // textBox_stops
            // 
            this.textBox_stops.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_stops.Location = new System.Drawing.Point(483, 179);
            this.textBox_stops.Name = "textBox_stops";
            this.textBox_stops.Size = new System.Drawing.Size(248, 37);
            this.textBox_stops.TabIndex = 31;
            // 
            // label_new_stops
            // 
            this.label_new_stops.AutoSize = true;
            this.label_new_stops.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_new_stops.Location = new System.Drawing.Point(50, 182);
            this.label_new_stops.Name = "label_new_stops";
            this.label_new_stops.Size = new System.Drawing.Size(246, 31);
            this.label_new_stops.TabIndex = 33;
            this.label_new_stops.Text = "Проміжні зупинки:";
            // 
            // textBox_times
            // 
            this.textBox_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_times.Location = new System.Drawing.Point(483, 259);
            this.textBox_times.Name = "textBox_times";
            this.textBox_times.Size = new System.Drawing.Size(248, 37);
            this.textBox_times.TabIndex = 34;
            // 
            // list_times
            // 
            this.list_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_times.FormattingEnabled = true;
            this.list_times.ItemHeight = 22;
            this.list_times.Location = new System.Drawing.Point(483, 339);
            this.list_times.Name = "list_times";
            this.list_times.Size = new System.Drawing.Size(248, 114);
            this.list_times.TabIndex = 35;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(50, 503);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(162, 31);
            this.label_price.TabIndex = 36;
            this.label_price.Text = "Ціна білету:";
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price.Location = new System.Drawing.Point(483, 503);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(180, 37);
            this.textBox_price.TabIndex = 37;
            // 
            // label_free_places
            // 
            this.label_free_places.AutoSize = true;
            this.label_free_places.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_free_places.Location = new System.Drawing.Point(50, 583);
            this.label_free_places.Name = "label_free_places";
            this.label_free_places.Size = new System.Drawing.Size(165, 31);
            this.label_free_places.TabIndex = 38;
            this.label_free_places.Text = "К-сть місць:";
            // 
            // numericUpDown_free_places
            // 
            this.numericUpDown_free_places.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_free_places.Location = new System.Drawing.Point(483, 581);
            this.numericUpDown_free_places.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_free_places.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown_free_places.Name = "numericUpDown_free_places";
            this.numericUpDown_free_places.Size = new System.Drawing.Size(248, 37);
            this.numericUpDown_free_places.TabIndex = 39;
            this.numericUpDown_free_places.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(56, 660);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(259, 43);
            this.button_reset.TabIndex = 40;
            this.button_reset.Text = "Скинути форму";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_add_train
            // 
            this.button_add_train.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_train.Location = new System.Drawing.Point(483, 660);
            this.button_add_train.Name = "button_add_train";
            this.button_add_train.Size = new System.Drawing.Size(248, 43);
            this.button_add_train.TabIndex = 41;
            this.button_add_train.Text = "Додати";
            this.button_add_train.UseVisualStyleBackColor = true;
            this.button_add_train.Click += new System.EventHandler(this.button_add_train_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(669, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "грн.";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number.Location = new System.Drawing.Point(50, 22);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(239, 31);
            this.label_number.TabIndex = 43;
            this.label_number.Text = "Номер маршруту:";
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_number.Location = new System.Drawing.Point(483, 19);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(248, 37);
            this.textBox_number.TabIndex = 44;
            // 
            // Cashier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 737);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add_train);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.numericUpDown_free_places);
            this.Controls.Add(this.label_free_places);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.list_times);
            this.Controls.Add(this.textBox_times);
            this.Controls.Add(this.textBox_stops);
            this.Controls.Add(this.textBox_town);
            this.Controls.Add(this.label_new_town);
            this.Controls.Add(this.label_new_stops);
            this.Controls.Add(this.label_new_time);
            this.Name = "Cashier_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_free_places)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_new_time;
        private System.Windows.Forms.Label label_new_town;
        private System.Windows.Forms.TextBox textBox_town;
        private System.Windows.Forms.TextBox textBox_stops;
        private System.Windows.Forms.Label label_new_stops;
        private System.Windows.Forms.TextBox textBox_times;
        private System.Windows.Forms.ListBox list_times;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_free_places;
        private System.Windows.Forms.NumericUpDown numericUpDown_free_places;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_add_train;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_number;
    }
}