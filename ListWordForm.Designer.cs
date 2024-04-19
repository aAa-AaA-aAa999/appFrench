namespace appFrench
{
    partial class ListWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListWordForm));
            this.wordsList = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordsList
            // 
            this.wordsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordsList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.wordsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(114)))));
            this.wordsList.FormattingEnabled = true;
            this.wordsList.HorizontalExtent = 10;
            this.wordsList.HorizontalScrollbar = true;
            this.wordsList.ItemHeight = 21;
            this.wordsList.Location = new System.Drawing.Point(28, 90);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(332, 273);
            this.wordsList.TabIndex = 15;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(23)))), ((int)(((byte)(155)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(258, 373);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(102, 33);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ListWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 417);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.wordsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListWordForm";
            this.Text = "ListWordForm";
            this.Load += new System.EventHandler(this.ListWordForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox wordsList;
        private System.Windows.Forms.Button buttonExit;
    }
}