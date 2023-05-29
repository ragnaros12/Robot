namespace Robot
{
    partial class Form1
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
            this.Bomb = new System.Windows.Forms.PictureBox();
            this.RobotImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Bomb
            // 
            this.Bomb.BackColor = System.Drawing.Color.Transparent;
            this.Bomb.Image = global::Robot.Properties.Resources.dust;
            this.Bomb.Location = new System.Drawing.Point(350, 350);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(100, 100);
            this.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb.TabIndex = 1;
            this.Bomb.TabStop = false;
            // 
            // RobotImage
            // 
            this.RobotImage.BackColor = System.Drawing.Color.Transparent;
            this.RobotImage.Image = global::Robot.Properties.Resources.robot;
            this.RobotImage.Location = new System.Drawing.Point(0, 0);
            this.RobotImage.Name = "RobotImage";
            this.RobotImage.Size = new System.Drawing.Size(100, 100);
            this.RobotImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobotImage.TabIndex = 0;
            this.RobotImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.RobotImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RobotImage;
        private System.Windows.Forms.PictureBox Bomb;
    }
}

