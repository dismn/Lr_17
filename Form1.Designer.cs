
namespace Lr_17
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.AndRadioButton = new System.Windows.Forms.RadioButton();
            this.OnRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ForEach = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(73, 60);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(220, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // AndRadioButton
            // 
            this.AndRadioButton.AutoSize = true;
            this.AndRadioButton.Location = new System.Drawing.Point(73, 106);
            this.AndRadioButton.Name = "AndRadioButton";
            this.AndRadioButton.Size = new System.Drawing.Size(88, 21);
            this.AndRadioButton.TabIndex = 1;
            this.AndRadioButton.TabStop = true;
            this.AndRadioButton.Text = "AndArray";
            this.AndRadioButton.UseVisualStyleBackColor = true;
            // 
            // OnRadioButton
            // 
            this.OnRadioButton.AutoSize = true;
            this.OnRadioButton.Location = new System.Drawing.Point(73, 144);
            this.OnRadioButton.Name = "OnRadioButton";
            this.OnRadioButton.Size = new System.Drawing.Size(82, 21);
            this.OnRadioButton.TabIndex = 2;
            this.OnRadioButton.TabStop = true;
            this.OnRadioButton.Text = "OnArray";
            this.OnRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(73, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 33);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Обрати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(238, 195);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(38, 17);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "label";
            // 
            // ForEach
            // 
            this.ForEach.Location = new System.Drawing.Point(79, 265);
            this.ForEach.Name = "ForEach";
            this.ForEach.Size = new System.Drawing.Size(176, 49);
            this.ForEach.TabIndex = 5;
            this.ForEach.Text = "Заелементна обр. масиву";
            this.ForEach.UseVisualStyleBackColor = true;
            this.ForEach.Click += new System.EventHandler(this.ForEach_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(79, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(176, 49);
            this.Add.TabIndex = 6;
            this.Add.Text = "Додавання";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(332, 301);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(279, 22);
            this.OutputTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введіть масив:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ForEach);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OnRadioButton);
            this.Controls.Add(this.AndRadioButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RadioButton AndRadioButton;
        private System.Windows.Forms.RadioButton OnRadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ForEach;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
    }
}

