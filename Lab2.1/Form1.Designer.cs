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
            InputNumber = new TextBox();
            TextTask = new Label();
            bindingSource1 = new BindingSource(components);
            ButtonInput = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // InputNumber
            // 
            InputNumber.Location = new Point(21, 50);
            InputNumber.Name = "InputNumber";
            InputNumber.Size = new Size(125, 27);
            InputNumber.TabIndex = 0;
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
            // ButtonInput
            // 
            ButtonInput.Location = new Point(21, 83);
            ButtonInput.Name = "ButtonInput";
            ButtonInput.Size = new Size(249, 27);
            ButtonInput.TabIndex = 2;
            ButtonInput.Text = "Проверить на счастливое число";
            ButtonInput.UseVisualStyleBackColor = true;
            ButtonInput.Click += ButtonInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 146);
            Controls.Add(ButtonInput);
            Controls.Add(TextTask);
            Controls.Add(InputNumber);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputNumber;
        private Label TextTask;
        private BindingSource bindingSource1;
        private Button ButtonInput;
    }
}
