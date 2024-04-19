namespace appFrench
{
    partial class ExperimentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentalForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLearnSpeed = new System.Windows.Forms.Button();
            this.buttonLearnSlowed = new System.Windows.Forms.Button();
            this.speedGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.speedGame)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(220, 100);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(92, 80);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // buttonLearnSpeed
            // 
            this.buttonLearnSpeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLearnSpeed.BackgroundImage")));
            this.buttonLearnSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLearnSpeed.FlatAppearance.BorderSize = 0;
            this.buttonLearnSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.buttonLearnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLearnSpeed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonLearnSpeed.Location = new System.Drawing.Point(36, 169);
            this.buttonLearnSpeed.Name = "buttonLearnSpeed";
            this.buttonLearnSpeed.Size = new System.Drawing.Size(152, 63);
            this.buttonLearnSpeed.TabIndex = 4;
            this.buttonLearnSpeed.Text = "Быстрая игра";
            this.buttonLearnSpeed.UseVisualStyleBackColor = true;
            // 
            // buttonLearnSlowed
            // 
            this.buttonLearnSlowed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLearnSlowed.BackgroundImage")));
            this.buttonLearnSlowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLearnSlowed.FlatAppearance.BorderSize = 0;
            this.buttonLearnSlowed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.buttonLearnSlowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLearnSlowed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonLearnSlowed.Location = new System.Drawing.Point(36, 240);
            this.buttonLearnSlowed.Name = "buttonLearnSlowed";
            this.buttonLearnSlowed.Size = new System.Drawing.Size(152, 63);
            this.buttonLearnSlowed.TabIndex = 3;
            this.buttonLearnSlowed.Text = "Постепенное изучение";
            this.buttonLearnSlowed.UseVisualStyleBackColor = true;
            // 
            // speedGame
            // 
            this.speedGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speedGame.Image = ((System.Drawing.Image)(resources.GetObject("speedGame.Image")));
            this.speedGame.Location = new System.Drawing.Point(36, 91);
            this.speedGame.Name = "speedGame";
            this.speedGame.Size = new System.Drawing.Size(152, 63);
            this.speedGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speedGame.TabIndex = 5;
            this.speedGame.TabStop = false;
            this.speedGame.Click += new System.EventHandler(this.speedGame_Click);
            // 
            // ExperimentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.speedGame);
            this.Controls.Add(this.buttonLearnSpeed);
            this.Controls.Add(this.buttonLearnSlowed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExperimentalForm";
            this.Text = "ExperimentalForm";
            ((System.ComponentModel.ISupportInitialize)(this.speedGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLearnSpeed;
        private System.Windows.Forms.Button buttonLearnSlowed;
        private System.Windows.Forms.PictureBox speedGame;
    }
}