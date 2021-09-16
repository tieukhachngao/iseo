using System;
using System.ComponentModel;
using Google.GData.Extensions.AppControl;

namespace Google.GData.Client
{
	public abstract class Entry
	{
		private AtomEntry atomEntry_0;

		[Category("Basic Entry Data")]
		[Description("The original AtomEntry object that this object is standing in for")]
		public AtomEntry AtomEntry
		{
			get
			{
				return atomEntry_0;
			}
			set
			{
				atomEntry_0 = value;
			}
		}

		[Description("The unique Id of the entry")]
		[Category("Basic Entry Data")]
		public string Id
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Id.AbsoluteUri;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.Id = new AtomId(value);
			}
		}

		[Category("Basic Entry Data")]
		[Description("The value of the self uri as a string")]
		public string Self
		{
			get
			{
				EnsureInnerObject();
				if (atomEntry_0.SelfUri != null)
				{
					return atomEntry_0.SelfUri.ToString();
				}
				return null;
			}
		}

		[Category("Basic Entry Data")]
		[Description("Specifies the title of the entry.")]
		public virtual string Title
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Title.Text;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.Title.Text = value;
			}
		}

		[Description("The AppControl subobject.")]
		[Category("Basic Entry Data")]
		public AppControl AppControl
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.AppControl;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.AppControl = value;
			}
		}

		[Category("Basic Entry Data")]
		[Description("Specifies if the entry is considered a draft entry.")]
		public bool IsDraft
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.IsDraft;
			}
		}

		[Description("If then entry has no edit uri, it is considered read only.")]
		[Category("Basic Entry Data")]
		public bool ReadOnly
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.EditUri == null;
			}
		}

		[Description("returns the first author name in the atom.entry.authors collection.")]
		[Category("Basic Entry Data")]
		public string Author
		{
			get
			{
				EnsureInnerObject();
				if (atomEntry_0.Authors.Count > 0 && atomEntry_0.Authors[0] != null)
				{
					return atomEntry_0.Authors[0].Name;
				}
				return null;
			}
			set
			{
				EnsureInnerObject();
				AtomPerson atomPerson = null;
				if (atomEntry_0.Authors.Count == 0)
				{
					atomPerson = new AtomPerson(AtomPersonType.Author);
					atomEntry_0.Authors.Add(atomPerson);
				}
				else
				{
					atomPerson = atomEntry_0.Authors[0];
				}
				atomPerson.Name = value;
			}
		}

		[Description("returns the string representation of the atom.content element.")]
		[Category("Basic Entry Data")]
		public string Content
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Content.Content;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.Content.Content = value;
			}
		}

		[Category("Basic Entry Data")]
		[Description("returns the string representation of the atom.Summary element.")]
		public string Summary
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Summary.Text;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.Summary.Text = value;
			}
		}

		[Description("The datetime at which the entry was updated the last time.")]
		[Category("Basic Entry Data")]
		public DateTime Updated
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Updated;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.Updated = value;
			}
		}

		[Description("The batchdata subobject.")]
		[Category("Basic Entry Data")]
		public GDataBatchEntryData BatchData
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.BatchData;
			}
			set
			{
				EnsureInnerObject();
				atomEntry_0.BatchData = value;
			}
		}

		[Description("The Categories collection.")]
		[Category("Basic Entry Data")]
		public AtomCategoryCollection Categories
		{
			get
			{
				EnsureInnerObject();
				return atomEntry_0.Categories;
			}
		}

		[Category("Media Data")]
		[Description("The Mediasource subobject.")]
		public MediaSource MediaSource
		{
			get
			{
				EnsureInnerObject();
				return (atomEntry_0 as AbstractEntry)?.MediaSource;
			}
			set
			{
				EnsureInnerObject();
				AbstractEntry abstractEntry = atomEntry_0 as AbstractEntry;
				if (abstractEntry == null)
				{
					throw new InvalidOperationException("The AtomEntry contained does not support Media operations");
				}
				abstractEntry.MediaSource = value;
			}
		}

		[Description("The etag information.")]
		[Category("State Data")]
		public string ETag
		{
			get
			{
				EnsureInnerObject();
				return (atomEntry_0 as AbstractEntry)?.Etag;
			}
			set
			{
				EnsureInnerObject();
				AbstractEntry abstractEntry = atomEntry_0 as AbstractEntry;
				if (abstractEntry == null)
				{
					throw new InvalidOperationException("The AtomEntry contained does not support ETags operations");
				}
				abstractEntry.Etag = value;
			}
		}

		public Entry()
		{
		}

		public override string ToString()
		{
			return Title;
		}

		protected abstract void EnsureInnerObject();
	}
}
