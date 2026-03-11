namespace Lab2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            inputNumber = new TextBox();
            TextTask = new Label();
            bindingSource1 = new BindingSource(components);
            buttonInput = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // inputNumber
            // 
            inputNumber.Location = new Point(21, 50);
            inputNumber.Name = "inputNumber";
            inputNumber.Size = new Size(125, 27);
            inputNumber.TabIndex = 0;
            // 
            // TextTask
            // 
            TextTask.AutoSize = true;
            TextTask.Location = new Point(21, 27);
            TextTask.Name = "TextTask";
            TextTask.Size = new Size(214, 20);
            TextTask.TabIndex = 1;
            TextTask.Text = "Введите шестизначное число";
            // 
            // buttonInput
            // 
            buttonInput.Location = new Point(21, 83);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(94, 29);
            buttonInput.TabIndex = 2;
            buttonInput.Text = "Ввести число";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 146);
            Controls.Add(buttonInput);
            Controls.Add(TextTask);
            Controls.Add(inputNumber);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNumber;
        private Label TextTask;
        private BindingSource bindingSource1;
        private Button buttonInput;
    }
}
