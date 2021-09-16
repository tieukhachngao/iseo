using System;
using System.Globalization;
using System.Text;

namespace Google.GData.Client
{
	public class DocumentQuery : FeedQuery
	{
		private string string_5;

		private bool bool_2;

		public string Title
		{
			get
			{
				return string_5;
			}
			set
			{
				string_5 = value;
			}
		}

		public bool Exact
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

		public DocumentQuery(string baseUri)
			: base(baseUri)
		{
			Title = null;
			Exact = false;
		}

		protected override Uri ParseUri(Uri targetUri)
		{
			base.ParseUri(targetUri);
			if (targetUri != null)
			{
				char[] delimiters = new char[2] { '?', '&' };
				string source = HttpUtility.UrlDecode(targetUri.Query);
				TokenCollection tokenCollection = new TokenCollection(source, delimiters);
				foreach (string item in tokenCollection)
				{
					if (item.Length > 0)
					{
						char[] separator = new char[1] { '=' };
						string[] array = item.Split(separator, 2);
						switch (array[0])
						{
						case "title-exact":
							Title = array[1];
							Exact = true;
							break;
						case "title":
							Title = array[1];
							Exact = false;
							break;
						}
					}
				}
			}
			return base.Uri;
		}

		protected override void Reset()
		{
			base.Reset();
			Title = null;
			Exact = false;
		}

		protected override string CalculateQuery(string basePath)
		{
			string text = base.CalculateQuery(basePath);
			StringBuilder stringBuilder = new StringBuilder(text, 2048);
			char value = InsertionParameter(text);
			if (Title != null)
			{
				stringBuilder.Append(value);
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "title={0}", new object[1] { Utilities.UriEncodeReserved(Title) });
				value = '&';
				if (Exact)
				{
					stringBuilder.Append(value);
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "title-exact=true");
				}
			}
			return stringBuilder.ToString();
		}
	}
}
