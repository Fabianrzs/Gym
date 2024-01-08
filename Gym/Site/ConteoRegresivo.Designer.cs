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
            label1 = new Label();
            userNameLbl = new Label();
            label2 = new Label();
            dayDisponibleLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 117);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido Nuevamente ";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(308, 152);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(109, 15);
            userNameLbl.TabIndex = 5;
            userNameLbl.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 215);
            label2.Name = "label2";
            label2.Size = new Size(286, 15);
            label2.TabIndex = 6;
            label2.Text = "Puedes seguir entrenando durante los siguientes dias";
            // 
            // dayDisponibleLbl
            // 
            dayDisponibleLbl.AutoSize = true;
            dayDisponibleLbl.Location = new Point(324, 281);
            dayDisponibleLbl.Name = "dayDisponibleLbl";
            dayDisponibleLbl.Size = new Size(93, 15);
            dayDisponibleLbl.TabIndex = 7;
            dayDisponibleLbl.Text = "Dias Disponibles";
            // 
            // ConteoRegresivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dayDisponibleLbl);
            Controls.Add(label2);
            Controls.Add(userNameLbl);
            Controls.Add(label1);
            Name = "ConteoRegresivo";
            Text = "ConteoRegresivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userNameLbl;
        private Label label2;
        private Label dayDisponibleLbl;
    }
}