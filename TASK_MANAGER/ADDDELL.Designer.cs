namespace TASK_MANAGER
{
    partial class ADDDELL
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
            this.label1 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.pri = new System.Windows.Forms.Label();
            this.due = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Duedate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TASK";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(162, 106);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(115, 21);
            this.d.TabIndex = 1;
            this.d.Text = "DESCRIPTION";
            // 
            // pri
            // 
            this.pri.AutoSize = true;
            this.pri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pri.Location = new System.Drawing.Point(162, 268);
            this.pri.Name = "pri";
            this.pri.Size = new System.Drawing.Size(82, 21);
            this.pri.TabIndex = 2;
            this.pri.Text = "PRIORITY";
            // 
            // due
            // 
            this.due.AutoSize = true;
            this.due.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due.Location = new System.Drawing.Point(162, 186);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(92, 21);
            this.due.TabIndex = 3;
            this.due.Text = "DUE DATE ";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(381, 109);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(241, 20);
            this.description.TabIndex = 6;
            // 
            // priority
            // 
            this.priority.FormattingEnabled = true;
            this.priority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.priority.Location = new System.Drawing.Point(381, 268);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(241, 21);
            this.priority.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Duedate
            // 
            this.Duedate.Location = new System.Drawing.Point(381, 186);
            this.Duedate.Name = "Duedate";
            this.Duedate.Size = new System.Drawing.Size(241, 20);
            this.Duedate.TabIndex = 13;
            // 
            // ADDDELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.Duedate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.description);
            this.Controls.Add(this.due);
            this.Controls.Add(this.pri);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label1);
            this.Name = "ADDDELL";
            this.Size = new System.Drawing.Size(769, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label pri;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Duedate;
    }
}
