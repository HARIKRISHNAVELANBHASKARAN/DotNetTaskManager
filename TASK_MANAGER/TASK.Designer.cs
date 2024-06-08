namespace TASK_MANAGER
{
    partial class TASK
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
            this.components = new System.ComponentModel.Container();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.taskmanagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskmanagerDataSet = new TASK_MANAGER.taskmanagerDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskmanagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskmanagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AccessibleName = "";
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(31, 31);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(704, 297);
            this.dgv1.TabIndex = 0;
            // 
            // taskmanagerDataSetBindingSource
            // 
            this.taskmanagerDataSetBindingSource.DataSource = this.taskmanagerDataSet;
            this.taskmanagerDataSetBindingSource.Position = 0;
            // 
            // taskmanagerDataSet
            // 
            this.taskmanagerDataSet.DataSetName = "taskmanagerDataSet";
            this.taskmanagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "REFERSH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TASK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Name = "TASK";
            this.Size = new System.Drawing.Size(769, 436);
            this.Load += new System.EventHandler(this.TASK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskmanagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskmanagerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource taskmanagerDataSetBindingSource;
        private taskmanagerDataSet taskmanagerDataSet;
        private System.Windows.Forms.Button button1;
    }
}
