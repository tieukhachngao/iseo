using System.ComponentModel;
using System.Xml;

namespace Google.GData.Client
{
	[Description("Expand to see the person object for the feed/entry.")]
	[TypeConverter(typeof(AtomPersonConverter))]
	public class AtomPerson : AtomBase
	{
		private string string_1;

		private string string_2;

		private AtomUri atomUri_2;

		private AtomPersonType atomPersonType_0;

		public string Name
		{
			get
			{
				return string_1;
			}
			set
			{
				base.Dirty = true;
				string_1 = value;
			}
		}

		public AtomUri Uri
		{
			get
			{
				if (atomUri_2 == null)
				{
					atomUri_2 = new AtomUri("");
				}
				return atomUri_2;
			}
			set
			{
				base.Dirty = true;
				atomUri_2 = value;
			}
		}

		public string Email
		{
			get
			{
				return string_2;
			}
			set
			{
				base.Dirty = true;
				string_2 = value;
			}
		}

		public override string XmlName
		{
			get
			{
				if (atomPersonType_0 != 0)
				{
					return "contributor";
				}
				return "author";
			}
		}

		public AtomPerson()
		{
			atomPersonType_0 = AtomPersonType.Author;
		}

		public AtomPerson(AtomPersonType type)
		{
			atomPersonType_0 = type;
		}

		public AtomPerson(AtomPersonType type, string name)
			: this(type)
		{
			string_1 = name;
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			AtomBase.WriteEncodedElementString(writer, "name", Name);
			AtomBase.WriteEncodedElementString(writer, "email", Email);
			AtomBase.WriteEncodedElementString(writer, "uri", Uri);
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				if (Utilities.IsPersistable(string_1))
				{
					return true;
				}
				if (Utilities.IsPersistable(string_2))
				{
					return true;
				}
				if (Utilities.IsPersistable(atomUri_2))
				{
					return true;
				}
				return false;
			}
			return true;
		}
	}
}
