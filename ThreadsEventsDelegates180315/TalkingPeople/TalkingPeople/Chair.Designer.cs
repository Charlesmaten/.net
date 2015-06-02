namespace TalkingPeople
{
    partial class Chair
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
            this.labelChair = new System.Windows.Forms.Label();
            this.checkBoxChair = new System.Windows.Forms.CheckBox();
            this.buttonChair = new System.Windows.Forms.Button();
            this.textBoxChair = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelChair
            // 
            this.labelChair.AutoSize = true;
            this.labelChair.Location = new System.Drawing.Point(225, 35);
            this.labelChair.Name = "labelChair";
            this.labelChair.Size = new System.Drawing.Size(126, 13);
            this.labelChair.TabIndex = 0;
            this.labelChair.Text = "Chair with person threads";
            // 
            // checkBoxChair
            // 
            this.checkBoxChair.AutoSize = true;
            this.checkBoxChair.Location = new System.Drawing.Point(253, 73);
            this.checkBoxChair.Name = "checkBoxChair";
            this.checkBoxChair.Size = new System.Drawing.Size(50, 17);
            this.checkBoxChair.TabIndex = 1;
            this.checkBoxChair.Text = "Lock";
            this.checkBoxChair.UseVisualStyleBackColor = true;
            this.checkBoxChair.CheckedChanged += new System.EventHandler(this.checkBoxChair_CheckedChanged);
            // 
            // buttonChair
            // 
            this.buttonChair.Location = new System.Drawing.Point(239, 108);
            this.buttonChair.Name = "buttonChair";
            this.buttonChair.Size = new System.Drawing.Size(75, 23);
            this.buttonChair.TabIndex = 2;
            this.buttonChair.Text = "Start";
            this.buttonChair.UseVisualStyleBackColor = true;
            this.buttonChair.Click += new System.EventHandler(this.buttonChair_Click);
            // 
            // textBoxChair
            // 
            this.textBoxChair.Location = new System.Drawing.Point(13, 162);
            this.textBoxChair.Multiline = true;
            this.textBoxChair.Name = "textBoxChair";
            this.textBoxChair.ReadOnly = true;
            this.textBoxChair.Size = new System.Drawing.Size(559, 400);
            this.textBoxChair.TabIndex = 3;
            // 
            // Chair
            // 
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.textBoxChair);
            this.Controls.Add(this.buttonChair);
            this.Controls.Add(this.checkBoxChair);
            this.Controls.Add(this.labelChair);
            this.Name = "Chair";
            this.Text = "Chair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelChair;
        private System.Windows.Forms.CheckBox checkBoxChair;
        private System.Windows.Forms.Button buttonChair;
        private System.Windows.Forms.TextBox textBoxChair;
    }
}

