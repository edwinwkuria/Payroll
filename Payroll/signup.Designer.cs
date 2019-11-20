namespace Payroll
{
    partial class signup
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
            this.employeeSignUpForm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeSignUpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeSignUpForm
            // 
            this.employeeSignUpForm.Controls.Add(this.textBox6);
            this.employeeSignUpForm.Controls.Add(this.label9);
            this.employeeSignUpForm.Controls.Add(this.textBox1);
            this.employeeSignUpForm.Controls.Add(this.label8);
            this.employeeSignUpForm.Controls.Add(this.dateTimePicker1);
            this.employeeSignUpForm.Controls.Add(this.label7);
            this.employeeSignUpForm.Controls.Add(this.label6);
            this.employeeSignUpForm.Controls.Add(this.Female);
            this.employeeSignUpForm.Controls.Add(this.Male);
            this.employeeSignUpForm.Controls.Add(this.textBox5);
            this.employeeSignUpForm.Controls.Add(this.label5);
            this.employeeSignUpForm.Controls.Add(this.textBox4);
            this.employeeSignUpForm.Controls.Add(this.label4);
            this.employeeSignUpForm.Controls.Add(this.textBox3);
            this.employeeSignUpForm.Controls.Add(this.label3);
            this.employeeSignUpForm.Controls.Add(this.textBox2);
            this.employeeSignUpForm.Controls.Add(this.label2);
            this.employeeSignUpForm.Controls.Add(this.label1);
            this.employeeSignUpForm.Location = new System.Drawing.Point(40, 2);
            this.employeeSignUpForm.Name = "employeeSignUpForm";
            this.employeeSignUpForm.Size = new System.Drawing.Size(750, 472);
            this.employeeSignUpForm.TabIndex = 0;
            this.employeeSignUpForm.TabStop = false;
            this.employeeSignUpForm.Text = "Enter the new employees biodata";
            this.employeeSignUpForm.Enter += new System.EventHandler(this.employeeSignUpForm_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Number";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(129, 278);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 8;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(183, 278);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 9;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date Joined";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(129, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alt Phone Number";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 505);
            this.Controls.Add(this.employeeSignUpForm);
            this.Name = "signup";
            this.Text = "signup";
            this.employeeSignUpForm.ResumeLayout(false);
            this.employeeSignUpForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeSignUpForm;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

    }
}