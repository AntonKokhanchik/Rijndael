using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyRijndael
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonEncriptionFileInput_Click(object sender, EventArgs e)
		{
			openFileDialogEncriptionInput.ShowDialog();
		}

		private void openFileDialogEncriptionInput_FileOk(object sender, CancelEventArgs e)
		{
			textBoxEncriptionInput.Text = new StreamReader(openFileDialogEncriptionInput.FileName).ReadToEnd();
		}

		private void buttonEncriptionFileOutput_Click(object sender, EventArgs e)
		{
			saveFileDialogEncriptionOutput.ShowDialog();
		}

		private void buttonDecryptionFileInput_Click(object sender, EventArgs e)
		{
			openFileDialogDecriptionInput.ShowDialog();
		}

		private void buttonDecryptionFileOutput_Click(object sender, EventArgs e)
		{
			saveFileDialogDecriptionOutput.ShowDialog();
		}

		private void saveFileDialogDecriptionOutput_FileOk(object sender, CancelEventArgs e)
		{
			new StreamWriter(saveFileDialogDecriptionOutput.FileName).Write(textBoxDectiptionOutput.Text);
		}

		private void buttonEncrypt_Click(object sender, EventArgs e)
		{
			using (Rijndael myRijndael = Rijndael.Create())
			{
				byte[] encrypted = EncryptStringToBytes(textBoxEncriptionInput.Text, getKey(),
					Encoding.ASCII.GetBytes("0000000000000000"));

				using (FileStream fs = new FileStream(saveFileDialogEncriptionOutput.FileName, FileMode.Create, FileAccess.Write))
					for (int i = 0; i < encrypted.Length; i++)
						fs.WriteByte(encrypted[i]);
			}
		}

		byte[] getKey()
		{
			string textKey = textBoxKey.Text;
			while (textKey.Length < 32)
				textKey += "0";
			if (textKey.Length > 32)
				textKey = textKey.Substring(0, 32);
			return Encoding.ASCII.GetBytes(textKey);
		}

		static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
		{
			byte[] encrypted;
			// Create an Rijndael object
			// with the specified key and IV.

			using (Rijndael rijAlg = Rijndael.Create())
			{
				rijAlg.Key = Key;
				var a = rijAlg.IV;
				rijAlg.IV = IV;

				// Create an encryptor to perform the stream transform.
				ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

				// Create the streams used for encryption.
				using (MemoryStream msEncrypt = new MemoryStream())
				using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
				{
					using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						//Write all data to the stream.
						swEncrypt.Write(plainText);
					encrypted = msEncrypt.ToArray();
				}
			}
			// Return the encrypted bytes from the memory stream.
			return encrypted;
		}

		private void buttonDecrypt_Click(object sender, EventArgs e)
		{
			using (FileStream fs = new FileStream(openFileDialogDecriptionInput.FileName, FileMode.Open, FileAccess.Read))
			{
				byte[] encrypted = new byte[fs.Length];
				for (int i = 0; i < fs.Length; i++)
					encrypted[i] = (byte)fs.ReadByte();

				textBoxDectiptionOutput.Text = DecryptStringFromBytes(encrypted, getKey(), 
					Encoding.ASCII.GetBytes("0000000000000000"));
			}
		}

		static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
		{
			// Declare the string used to hold
			// the decrypted text.
			string plaintext = null;

			// Create an Rijndael object
			// with the specified key and IV.
			using (Rijndael rijAlg = Rijndael.Create())
			{
				rijAlg.Key = Key;
				rijAlg.IV = IV;

				// Create a decryptor to perform the stream transform.
				ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

				// Create the streams used for decryption.
				using (MemoryStream msDecrypt = new MemoryStream(cipherText))
				using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
				using (StreamReader srDecrypt = new StreamReader(csDecrypt))
					// Read the decrypted bytes from the decrypting stream
					// and place them in a string.
					plaintext = srDecrypt.ReadToEnd();
			}
			return plaintext;
		}
	}
}
