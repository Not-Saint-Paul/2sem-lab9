
namespace Lab9
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
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondDirListBox = new System.Windows.Forms.ListBox();
            this.FirstDirListBox = new System.Windows.Forms.ListBox();
            this.SecondDirTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changesSaveDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveAsXmlFileButton = new System.Windows.Forms.Button();
            this.saveAsJsonFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(355, 75);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(103, 23);
            this.CheckOutButton.TabIndex = 26;
            this.CheckOutButton.Text = "Let\'s check out!";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "What\'s changed?";
            // 
            // ChangesListBox
            // 
            this.ChangesListBox.FormattingEnabled = true;
            this.ChangesListBox.Location = new System.Drawing.Point(319, 137);
            this.ChangesListBox.Name = "ChangesListBox";
            this.ChangesListBox.Size = new System.Drawing.Size(181, 199);
            this.ChangesListBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Files in this directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Files in this directory";
            // 
            // SecondDirListBox
            // 
            this.SecondDirListBox.FormattingEnabled = true;
            this.SecondDirListBox.Location = new System.Drawing.Point(583, 137);
            this.SecondDirListBox.Name = "SecondDirListBox";
            this.SecondDirListBox.Size = new System.Drawing.Size(181, 290);
            this.SecondDirListBox.TabIndex = 21;
            // 
            // FirstDirListBox
            // 
            this.FirstDirListBox.FormattingEnabled = true;
            this.FirstDirListBox.Location = new System.Drawing.Point(31, 137);
            this.FirstDirListBox.Name = "FirstDirListBox";
            this.FirstDirListBox.Size = new System.Drawing.Size(181, 290);
            this.FirstDirListBox.TabIndex = 20;
            // 
            // SecondDirTextBox
            // 
            this.SecondDirTextBox.Location = new System.Drawing.Point(583, 78);
            this.SecondDirTextBox.Name = "SecondDirTextBox";
            this.SecondDirTextBox.Size = new System.Drawing.Size(181, 20);
            this.SecondDirTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Second directory\'s name";
            // 
            // FirstDirTextBox
            // 
            this.FirstDirTextBox.Location = new System.Drawing.Point(31, 78);
            this.FirstDirTextBox.Name = "FirstDirTextBox";
            this.FirstDirTextBox.Size = new System.Drawing.Size(181, 20);
            this.FirstDirTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "First directory\'s name";
            // 
            // changesSaveDirectoryTextBox
            // 
            this.changesSaveDirectoryTextBox.Location = new System.Drawing.Point(319, 368);
            this.changesSaveDirectoryTextBox.Name = "changesSaveDirectoryTextBox";
            this.changesSaveDirectoryTextBox.Size = new System.Drawing.Size(181, 20);
            this.changesSaveDirectoryTextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Directory\'s name when you want to save changes";
            // 
            // saveAsXmlFileButton
            // 
            this.saveAsXmlFileButton.Location = new System.Drawing.Point(319, 406);
            this.saveAsXmlFileButton.Name = "saveAsXmlFileButton";
            this.saveAsXmlFileButton.Size = new System.Drawing.Size(91, 21);
            this.saveAsXmlFileButton.TabIndex = 30;
            this.saveAsXmlFileButton.Text = "Save as XML";
            this.saveAsXmlFileButton.UseVisualStyleBackColor = true;
            this.saveAsXmlFileButton.Click += new System.EventHandler(this.changesSaveButton_Click);
            // 
            // saveAsJsonFileButton
            // 
            this.saveAsJsonFileButton.Location = new System.Drawing.Point(416, 406);
            this.saveAsJsonFileButton.Name = "saveAsJsonFileButton";
            this.saveAsJsonFileButton.Size = new System.Drawing.Size(91, 21);
            this.saveAsJsonFileButton.TabIndex = 31;
            this.saveAsJsonFileButton.Text = "Save as JSON";
            this.saveAsJsonFileButton.UseVisualStyleBackColor = true;
            this.saveAsJsonFileButton.Click += new System.EventHandler(this.saveAsJsonFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveAsJsonFileButton);
            this.Controls.Add(this.saveAsXmlFileButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changesSaveDirectoryTextBox);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondDirListBox);
            this.Controls.Add(this.FirstDirListBox);
            this.Controls.Add(this.SecondDirTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstDirTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ChangesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SecondDirListBox;
        private System.Windows.Forms.ListBox FirstDirListBox;
        private System.Windows.Forms.TextBox SecondDirTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changesSaveDirectoryTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveAsXmlFileButton;
        private System.Windows.Forms.Button saveAsJsonFileButton;
    }
}

