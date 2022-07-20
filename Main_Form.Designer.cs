
namespace TrainStation
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_user = new System.Windows.Forms.Button();
            this.button_cashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_user
            // 
            this.button_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user.Location = new System.Drawing.Point(48, 90);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(150, 50);
            this.button_user.TabIndex = 0;
            this.button_user.Text = "Покупець";
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_cashier
            // 
            this.button_cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cashier.Location = new System.Drawing.Point(280, 90);
            this.button_cashier.Name = "button_cashier";
            this.button_cashier.Size = new System.Drawing.Size(150, 50);
            this.button_cashier.TabIndex = 1;
            this.button_cashier.Text = "Касир";
            this.button_cashier.UseVisualStyleBackColor = true;
            this.button_cashier.Click += new System.EventHandler(this.button_cashier_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 235);
            this.Controls.Add(this.button_cashier);
            this.Controls.Add(this.button_user);
            this.MaximumSize = new System.Drawing.Size(500, 282);
            this.MinimumSize = new System.Drawing.Size(500, 282);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_cashier;
    }
}

