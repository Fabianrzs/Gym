namespace Gym.Site
{
    partial class ConteoRegresivo
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            userNameLbl = new Label();
            label2 = new Label();
            dayDisponibleLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(165, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 45);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido Nuevamente ";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.BackColor = Color.Transparent;
            userNameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLbl.ForeColor = SystemColors.Control;
            userNameLbl.Location = new Point(272, 105);
            userNameLbl.Margin = new Padding(4, 0, 4, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(270, 38);
            userNameLbl.TabIndex = 5;
            userNameLbl.Text = "Nombre de usuario";
            userNameLbl.Click += userNameLbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(21, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(714, 38);
            label2.TabIndex = 6;
            label2.Text = "Puedes seguir entrenando durante los siguientes dias";
            label2.Click += label2_Click;
            // 
            // dayDisponibleLbl
            // 
            dayDisponibleLbl.AutoSize = true;
            dayDisponibleLbl.BackColor = Color.Transparent;
            dayDisponibleLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dayDisponibleLbl.ForeColor = SystemColors.Control;
            dayDisponibleLbl.Location = new Point(256, 274);
            dayDisponibleLbl.Margin = new Padding(4, 0, 4, 0);
            dayDisponibleLbl.Name = "dayDisponibleLbl";
            dayDisponibleLbl.Size = new Size(233, 38);
            dayDisponibleLbl.TabIndex = 7;
            dayDisponibleLbl.Text = "Dias Disponibles";
            dayDisponibleLbl.Click += dayDisponibleLbl_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2900;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_gym_60;
            pictureBox1.Location = new Point(316, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 351);
            label3.Name = "label3";
            label3.Size = new Size(229, 46);
            label3.TabIndex = 9;
            label3.Text = "Energymclub";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(465, 351);
            label4.Name = "label4";
            label4.Size = new Size(290, 46);
            label4.TabIndex = 10;
            label4.Text = "Por Salud y Vida.";
            // 
            // ConteoRegresivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.pexels_anush_gorak_1431282;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(748, 406);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dayDisponibleLbl);
            Controls.Add(label2);
            Controls.Add(userNameLbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConteoRegresivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConteoRegresivo";
            Load += ConteoRegresivo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userNameLbl;
        private Label label2;
        private Label dayDisponibleLbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}