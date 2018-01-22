//El código Bacon sigue las siguientes reglas:
	// a- AAAAA
	// b- AAAAB
	// c- AAABA
	// d- AAABB
	// e- AABAA
	// f- AABAB
	// g- AABBA
	// h- AABBB
	// i j- ABAAA
	// k- ABAAB
	// l- ABABA
	// m- ABABB
	// n- ABBAA
	// o- ABBAB
	// p- ABBBA
	// q- ABBBB
	// r- BAAAA
	// s- BAAAB
	// t- BAABA
	// u v- BAABB
	// w- BABAA
	// x- BABAB
	// y- BABBA
	// z- BABBB
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baconiancipher
{
	public partial class FrmMain : Form
	{
		private String[] Values = {"AAAAA", "AAAAB", "AAABA", 
		"AAABB", "AABAA", "AABAB", "AABBA", "AABBB", "ABAAA", "ABAAA",
		"ABAAB", "ABABA", "ABABB", "ABBAA", "ABBAB", "ABBBA", "ABBBB",
		"BAAAA", "BAAAB", "BAABA", "BAABB", "BAABB", "BABAA", "BABAB",
		"BABBA", "BABBB"};

		private string CharToBaconianCode(string Input)
		{
			Input = Input.ToUpper();
			char[] Letras = Input.ToCharArray();
			string OutValue = "";
			for (int X = 0; X < Letras.Length; X++)
			{
				if ((byte)Letras[X] < 91 && (byte)Letras[X] > 64)
				{
					OutValue += Values[(byte)Letras[X] - 65];// + " ";
				}
			}
			return OutValue;
		}
		private bool IsLower(byte Code)
		{
			if (Code > 96 && Code < 123)
				return true;
			else
				return false;
		}
		private string FinalCipher(string PreCipher, string Phrase)
		{
			if (PreCipher.Length != Phrase.Length)
			{
				MessageBox.Show("Las longitudes del pre-cifrado y la frase para insertarlo no coinciden", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return "Error";
			}
			char[] PreCipherChars = PreCipher.ToCharArray();
			char[] PhraseChars = Phrase.ToCharArray();
			string FinalResult = "";
			for (int Y = 0; Y < PhraseChars.Length; Y++)
			{
				if ((byte)PreCipherChars[Y] == 65)
				{
					if (IsLower((byte)Phrase[Y]))
						FinalResult += PhraseChars[Y];
					else
						FinalResult += (char)(PhraseChars[Y] + 32);
				}
				else
				{
					if (!IsLower((byte)Phrase[Y]))
						FinalResult += PhraseChars[Y];
					else
						FinalResult += (char)(PhraseChars[Y] - 32);
				}
			}
			return FinalResult;
		}
		public FrmMain()
		{
			InitializeComponent();
		}

		private void BtnPreCipher_Click(object sender, EventArgs e)
		{
			TxtPrecipherResult.Text = CharToBaconianCode(TxtInput.Text);
			if (TxtPrecipherResult.TextLength == txtInput2.TextLength)
				BtnCipher.Enabled = true;
		}

		private void txtInput2_TextChanged(object sender, EventArgs e)
		{
			GBInput2.Text = "Frase de " + txtInput2.TextLength + " letras.";
			if (TxtPrecipherResult.TextLength == txtInput2.TextLength)
				BtnCipher.Enabled = true;
			else
				BtnCipher.Enabled = false;
		}

		private void BtnCipher_Click(object sender, EventArgs e)
		{
			TxtFinalResult.Text = FinalCipher(TxtPrecipherResult.Text, txtInput2.Text);
		}
	}
}
