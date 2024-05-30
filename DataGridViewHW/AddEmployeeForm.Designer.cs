namespace DataGridViewHW
{
    partial class AddEmployeeForm
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
            label3 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            ageNumericUpDown = new NumericUpDown();
            label4 = new Label();
            positionTextBox = new TextBox();
            label5 = new Label();
            salaryNumericUpDown = new NumericUpDown();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 35);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 5;
            label3.Text = "Adding an employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(51, 96);
            label1.Name = "label1";
            label1.Size = new Size(38, 13);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nameTextBox.Location = new Point(140, 92);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(146, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(51, 144);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 5;
            label2.Text = "Age:";
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ageNumericUpDown.Location = new Point(140, 144);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(78, 23);
            ageNumericUpDown.TabIndex = 2;
            ageNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(51, 202);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 7;
            label4.Text = "Position:";
            // 
            // positionTextBox
            // 
            positionTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            positionTextBox.Location = new Point(140, 202);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(100, 23);
            positionTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(51, 256);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 5;
            label5.Text = "Salary:";
            // 
            // salaryNumericUpDown
            // 
            salaryNumericUpDown.DecimalPlaces = 2;
            salaryNumericUpDown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            salaryNumericUpDown.Location = new Point(140, 256);
            salaryNumericUpDown.Name = "salaryNumericUpDown";
            salaryNumericUpDown.Size = new Size(120, 23);
            salaryNumericUpDown.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addButton.Location = new Point(51, 338);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 37);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(salaryNumericUpDown);
            Controls.Add(label5);
            Controls.Add(positionTextBox);
            Controls.Add(label4);
            Controls.Add(ageNumericUpDown);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private NumericUpDown ageNumericUpDown;
        private Label label4;
        private TextBox positionTextBox;
        private Label label5;
        private NumericUpDown salaryNumericUpDown;
        private Button addButton;
    }
}