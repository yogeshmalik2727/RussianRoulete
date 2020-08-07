namespace RussianRoulete
{
    partial class MainForm
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
            this.ShootAtHead = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveMe = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShootAtHead
            // 
            this.ShootAtHead.BackgroundImage = global::RussianRoulete.Resource1.shoot_at_head;
            this.ShootAtHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShootAtHead.ForeColor = System.Drawing.Color.Red;
            this.ShootAtHead.Location = new System.Drawing.Point(589, 12);
            this.ShootAtHead.Name = "ShootAtHead";
            this.ShootAtHead.Size = new System.Drawing.Size(116, 74);
            this.ShootAtHead.TabIndex = 0;
            this.ShootAtHead.Text = "Shoot At Head";
            this.ShootAtHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShootAtHead.UseVisualStyleBackColor = true;
            this.ShootAtHead.Click += new System.EventHandler(this.ShootAtHead_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.BackgroundImage = global::RussianRoulete.Resource1.shoot_away;
            this.ShootAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShootAway.ForeColor = System.Drawing.Color.Red;
            this.ShootAway.ImageKey = "(none)";
            this.ShootAway.Location = new System.Drawing.Point(589, 92);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(116, 71);
            this.ShootAway.TabIndex = 1;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spin.BackgroundImage = global::RussianRoulete.Resource1.loading;
            this.Spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spin.ForeColor = System.Drawing.Color.Red;
            this.Spin.Location = new System.Drawing.Point(12, 166);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(117, 71);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "Spin";
            this.Spin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackgroundImage = global::RussianRoulete.Resource1.load_real;
            this.LoadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadBtn.ForeColor = System.Drawing.Color.Red;
            this.LoadBtn.Location = new System.Drawing.Point(12, 243);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(117, 76);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveMe
            // 
            this.SaveMe.BackgroundImage = global::RussianRoulete.Resource1.running_safely;
            this.SaveMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveMe.ForeColor = System.Drawing.Color.Red;
            this.SaveMe.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SaveMe.Location = new System.Drawing.Point(564, 219);
            this.SaveMe.Name = "SaveMe";
            this.SaveMe.Size = new System.Drawing.Size(152, 110);
            this.SaveMe.TabIndex = 4;
            this.SaveMe.Text = "SaveMe";
            this.SaveMe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SaveMe.UseVisualStyleBackColor = true;
            this.SaveMe.Click += new System.EventHandler(this.SaveMe_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackgroundImage = global::RussianRoulete.Resource1.play_again;
            this.PlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayAgain.ForeColor = System.Drawing.Color.Red;
            this.PlayAgain.Location = new System.Drawing.Point(1, 2);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(65, 53);
            this.PlayAgain.TabIndex = 5;
            this.PlayAgain.Text = "PlayAgain";
            this.PlayAgain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(11, 20);
            this.textBox2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulete.Resource1.backgroundreal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 329);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.SaveMe);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.ShootAtHead);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShootAtHead;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveMe;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

