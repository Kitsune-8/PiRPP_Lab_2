namespace Lab_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label resultLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.taskList = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 16;
            this.taskList.Items.AddRange(new object[] {
            "1. Сумма 10 чисел",
            "2. Макс и мин в массиве",
            "3. Четные и нечетные",
            "4. Реверс массива",
            "5. Сдвиг вправо",
            "6. Подсчет повторений"});
            this.taskList.Location = new System.Drawing.Point(12, 12);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(200, 276);
            this.taskList.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(230, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(340, 100);
            this.inputBox.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(230, 118);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(150, 30);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(230, 154);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(340, 134);
            this.resultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.taskList);
            this.Name = "Form1";
            this.Text = "Задачи с массивами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}