namespace MyRijndael
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
			this.textBoxEncriptionInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonEncriptionFileInput = new System.Windows.Forms.Button();
			this.buttonEncriptionFileOutput = new System.Windows.Forms.Button();
			this.textBoxKey = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialogEncriptionInput = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogEncriptionOutput = new System.Windows.Forms.SaveFileDialog();
			this.buttonEncrypt = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxDectiptionOutput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonDecryptionFileOutput = new System.Windows.Forms.Button();
			this.buttonDecryptionFileInput = new System.Windows.Forms.Button();
			this.buttonDecrypt = new System.Windows.Forms.Button();
			this.openFileDialogDecriptionInput = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogDecriptionOutput = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// textBoxEncriptionInput
			// 
			this.textBoxEncriptionInput.Location = new System.Drawing.Point(9, 40);
			this.textBoxEncriptionInput.Multiline = true;
			this.textBoxEncriptionInput.Name = "textBoxEncriptionInput";
			this.textBoxEncriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxEncriptionInput.Size = new System.Drawing.Size(631, 60);
			this.textBoxEncriptionInput.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Открытый текст";
			// 
			// buttonEncriptionFileInput
			// 
			this.buttonEncriptionFileInput.Location = new System.Drawing.Point(535, 106);
			this.buttonEncriptionFileInput.Name = "buttonEncriptionFileInput";
			this.buttonEncriptionFileInput.Size = new System.Drawing.Size(105, 43);
			this.buttonEncriptionFileInput.TabIndex = 2;
			this.buttonEncriptionFileInput.Text = "Из файла";
			this.buttonEncriptionFileInput.UseVisualStyleBackColor = true;
			this.buttonEncriptionFileInput.Click += new System.EventHandler(this.buttonEncriptionFileInput_Click);
			// 
			// buttonEncriptionFileOutput
			// 
			this.buttonEncriptionFileOutput.Location = new System.Drawing.Point(9, 106);
			this.buttonEncriptionFileOutput.Name = "buttonEncriptionFileOutput";
			this.buttonEncriptionFileOutput.Size = new System.Drawing.Size(105, 43);
			this.buttonEncriptionFileOutput.TabIndex = 2;
			this.buttonEncriptionFileOutput.Text = "Выберите выходной файл";
			this.buttonEncriptionFileOutput.UseVisualStyleBackColor = true;
			this.buttonEncriptionFileOutput.Click += new System.EventHandler(this.buttonEncriptionFileOutput_Click);
			// 
			// textBoxKey
			// 
			this.textBoxKey.Location = new System.Drawing.Point(148, 163);
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.Size = new System.Drawing.Size(90, 20);
			this.textBoxKey.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(145, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ключ";
			// 
			// openFileDialogEncriptionInput
			// 
			this.openFileDialogEncriptionInput.FileName = "opentext.txt";
			this.openFileDialogEncriptionInput.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogEncriptionInput_FileOk);
			// 
			// saveFileDialogEncriptionOutput
			// 
			this.saveFileDialogEncriptionOutput.FileName = "%userprofile%\\Desktop\\encryptedtext.txt";
			// 
			// buttonEncrypt
			// 
			this.buttonEncrypt.Location = new System.Drawing.Point(309, 106);
			this.buttonEncrypt.Name = "buttonEncrypt";
			this.buttonEncrypt.Size = new System.Drawing.Size(105, 43);
			this.buttonEncrypt.TabIndex = 2;
			this.buttonEncrypt.Text = "Зашифровать";
			this.buttonEncrypt.UseVisualStyleBackColor = true;
			this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(280, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Зашифрование";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(289, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Расшифрование";
			// 
			// textBoxDectiptionOutput
			// 
			this.textBoxDectiptionOutput.Location = new System.Drawing.Point(9, 260);
			this.textBoxDectiptionOutput.Multiline = true;
			this.textBoxDectiptionOutput.Name = "textBoxDectiptionOutput";
			this.textBoxDectiptionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxDectiptionOutput.Size = new System.Drawing.Size(631, 60);
			this.textBoxDectiptionOutput.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Открытый текст";
			// 
			// buttonDecryptionFileOutput
			// 
			this.buttonDecryptionFileOutput.Location = new System.Drawing.Point(535, 211);
			this.buttonDecryptionFileOutput.Name = "buttonDecryptionFileOutput";
			this.buttonDecryptionFileOutput.Size = new System.Drawing.Size(105, 43);
			this.buttonDecryptionFileOutput.TabIndex = 2;
			this.buttonDecryptionFileOutput.Text = "В файл";
			this.buttonDecryptionFileOutput.UseVisualStyleBackColor = true;
			this.buttonDecryptionFileOutput.Click += new System.EventHandler(this.buttonDecryptionFileOutput_Click);
			// 
			// buttonDecryptionFileInput
			// 
			this.buttonDecryptionFileInput.Location = new System.Drawing.Point(9, 192);
			this.buttonDecryptionFileInput.Name = "buttonDecryptionFileInput";
			this.buttonDecryptionFileInput.Size = new System.Drawing.Size(105, 43);
			this.buttonDecryptionFileInput.TabIndex = 2;
			this.buttonDecryptionFileInput.Text = "Выберите входной файл";
			this.buttonDecryptionFileInput.UseVisualStyleBackColor = true;
			this.buttonDecryptionFileInput.Click += new System.EventHandler(this.buttonDecryptionFileInput_Click);
			// 
			// buttonDecrypt
			// 
			this.buttonDecrypt.Location = new System.Drawing.Point(309, 192);
			this.buttonDecrypt.Name = "buttonDecrypt";
			this.buttonDecrypt.Size = new System.Drawing.Size(105, 43);
			this.buttonDecrypt.TabIndex = 2;
			this.buttonDecrypt.Text = "Расшифровать";
			this.buttonDecrypt.UseVisualStyleBackColor = true;
			this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
			// 
			// openFileDialogDecriptionInput
			// 
			this.openFileDialogDecriptionInput.FileName = "%userprofile%\\Desktop\\encryptedtext.txt";
			// 
			// saveFileDialogDecriptionOutput
			// 
			this.saveFileDialogDecriptionOutput.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogDecriptionOutput_FileOk);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 340);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonDecrypt);
			this.Controls.Add(this.buttonEncrypt);
			this.Controls.Add(this.buttonDecryptionFileInput);
			this.Controls.Add(this.buttonEncriptionFileOutput);
			this.Controls.Add(this.buttonDecryptionFileOutput);
			this.Controls.Add(this.buttonEncriptionFileInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxKey);
			this.Controls.Add(this.textBoxDectiptionOutput);
			this.Controls.Add(this.textBoxEncriptionInput);
			this.Name = "Form1";
			this.Text = "Rijndael";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxEncriptionInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonEncriptionFileInput;
		private System.Windows.Forms.Button buttonEncriptionFileOutput;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialogEncriptionInput;
		private System.Windows.Forms.SaveFileDialog saveFileDialogEncriptionOutput;
		private System.Windows.Forms.Button buttonEncrypt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDectiptionOutput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonDecryptionFileOutput;
		private System.Windows.Forms.Button buttonDecryptionFileInput;
		private System.Windows.Forms.Button buttonDecrypt;
		private System.Windows.Forms.OpenFileDialog openFileDialogDecriptionInput;
		private System.Windows.Forms.SaveFileDialog saveFileDialogDecriptionOutput;
	}
}

