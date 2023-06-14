namespace composants.uc
{
    partial class ToDo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkTask = new System.Windows.Forms.CheckBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkTask
            // 
            this.chkTask.AutoSize = true;
            this.chkTask.Location = new System.Drawing.Point(4, 2);
            this.chkTask.Name = "chkTask";
            this.chkTask.Size = new System.Drawing.Size(22, 21);
            this.chkTask.TabIndex = 0;
            this.chkTask.UseVisualStyleBackColor = true;
            this.chkTask.CheckedChanged += new System.EventHandler(this.chkTask_CheckedChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(290, 0);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(42, 36);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "X";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.chkTask);
            this.Name = "ToDo";
            this.Size = new System.Drawing.Size(335, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTask;
        private System.Windows.Forms.Button btnEnd;
    }
}
