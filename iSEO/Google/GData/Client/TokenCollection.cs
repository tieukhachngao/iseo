using System.Collections;
using System.Collections.Generic;

namespace Google.GData.Client
{
	public class TokenCollection : IEnumerable
	{
		public class TokenEnumerator : IEnumerator
		{
			private int int_0 = -1;

			private TokenCollection tokenCollection_0;

			public string Current
			{
				get
				{
					if (tokenCollection_0.string_0 == null)
					{
						return null;
					}
					return tokenCollection_0.string_0[int_0];
				}
			}

			object IEnumerator.Current
			{
				get
				{
					if (tokenCollection_0.string_0 == null)
					{
						return null;
					}
					return tokenCollection_0.string_0[int_0];
				}
			}

			public TokenEnumerator(TokenCollection tokens)
			{
				tokenCollection_0 = tokens;
			}

			public bool MoveNext()
			{
				if (tokenCollection_0.string_0 != null && int_0 < tokenCollection_0.string_0.Length - 1)
				{
					int_0++;
					return true;
				}
				return false;
			}

			public void Reset()
			{
				int_0 = -1;
			}
		}

		private string[] string_0;

		public TokenCollection(string source, char[] delimiters)
		{
			if (source != null)
			{
				string_0 = source.Split(delimiters);
			}
		}

		public TokenCollection(string source, char delimiter, bool separateLines, int resultsPerLine)
		{
			if (source == null)
			{
				return;
			}
			if (separateLines)
			{
				string[] array = source.Split('\n');
				int num = array.Length * resultsPerLine;
				string_0 = new string[num];
				num = 0;
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split(delimiter);
					int num2 = ((array3.Length < resultsPerLine) ? array3.Length : resultsPerLine);
					for (int j = 0; j < num2; j++)
					{
						string_0[num++] = array3[j];
					}
					for (int k = resultsPerLine; k < array3.Length; k++)
					{
						string[] array4;
						string[] array5 = (array4 = string_0);
						int num3 = num - 1;
						nint num4 = num3;
						array5[num3] = array4[num4] + delimiter + array3[k];
					}
				}
			}
			else
			{
				string[] array6 = source.Split(delimiter);
				resultsPerLine = ((array6.Length < resultsPerLine) ? array6.Length : resultsPerLine);
				string_0 = new string[resultsPerLine];
				for (int l = 0; l < resultsPerLine; l++)
				{
					string_0[l] = array6[l];
				}
				for (int m = resultsPerLine; m < array6.Length; m++)
				{
					string[] array7;
					string[] array8 = (array7 = string_0);
					int num5 = resultsPerLine - 1;
					nint num6 = num5;
					array8[num5] = array7[num6] + delimiter + array6[m];
				}
			}
		}

		public Dictionary<string, string> CreateDictionary()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			for (int i = 0; i < string_0.Length; i += 2)
			{
				string key = string_0[i];
				string value = string_0[i + 1];
				dictionary.Add(key, value);
			}
			return dictionary;
		}

		public TokenEnumerator GetEnumerator()
		{
			return new TokenEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TokenEnumerator(this);
		}
	}
}
