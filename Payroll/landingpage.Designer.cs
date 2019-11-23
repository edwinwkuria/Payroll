namespace Payroll
{
    partial class landingpage
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDatabaseDataSet = new Payroll.payrollDatabaseDataSet();
            this.employeesTableAdapter = new Payroll.payrollDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.payrollDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDatabaseDataSet1 = new Payroll.payrollDatabaseDataSet();
            this.payrollDatabaseDataSet2 = new Payroll.payrollDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/M/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.payrollDatabaseDataSet;
            this.employeesBindingSource.CurrentChanged += new System.EventHandler(this.employeesBindingSource_CurrentChanged);
            // 
            // payrollDatabaseDataSet
            // 
            this.payrollDatabaseDataSet.DataSetName = "payrollDatabaseDataSet";
            this.payrollDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // payrollDatabaseDataSetBindingSource
            // 
            this.payrollDatabaseDataSetBindingSource.DataSource = this.payrollDatabaseDataSet;
            this.payrollDatabaseDataSetBindingSource.Position = 0;
            // 
            // payrollDatabaseDataSet1
            // 
            this.payrollDatabaseDataSet1.DataSetName = "payrollDatabaseDataSet";
            this.payrollDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollDatabaseDataSet2
            // 
            this.payrollDatabaseDataSet2.DataSetName = "payrollDatabaseDataSet";
            this.payrollDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 461);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "landingpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.landingpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private payrollDatabaseDataSet payrollDatabaseDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private payrollDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource payrollDatabaseDataSetBindingSource;
        private payrollDatabaseDataSet payrollDatabaseDataSet1;
        private payrollDatabaseDataSet payrollDatabaseDataSet2;
    }
}