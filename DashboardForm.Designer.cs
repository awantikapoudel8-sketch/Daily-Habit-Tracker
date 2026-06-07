namespace DAILYHABITTRACKERAPP
{
    partial class DashboardForm
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
            this.btnaddhabit = new System.Windows.Forms.Button();
            this.btnviewhabit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddhabit
            // 
            this.btnaddhabit.Location = new System.Drawing.Point(324, 85);
            this.btnaddhabit.Name = "btnaddhabit";
            this.btnaddhabit.Size = new System.Drawing.Size(119, 23);
            this.btnaddhabit.TabIndex = 0;
            this.btnaddhabit.Text = "Add Habit";
            this.btnaddhabit.UseVisualStyleBackColor = true;
            this.btnaddhabit.Click += new System.EventHandler(this.btnaddhabit_Click);
            // 
            // btnviewhabit
            // 
            this.btnviewhabit.Location = new System.Drawing.Point(324, 131);
            this.btnviewhabit.Name = "btnviewhabit";
            this.btnviewhabit.Size = new System.Drawing.Size(119, 23);
            this.btnviewhabit.TabIndex = 1;
            this.btnviewhabit.Text = "View Habits     ";
            this.btnviewhabit.UseVisualStyleBackColor = true;
            this.btnviewhabit.Click += new System.EventHandler(this.btnviewhabit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Progress Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daily Habit Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnviewhabit);
            this.Controls.Add(this.btnaddhabit);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddhabit;
        private System.Windows.Forms.Button btnviewhabit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}