namespace Google.GData.Extensions
{
	public class BatchError : SimpleContainer
	{
		public string Domain
		{
			get
			{
				return GetStringValue<BatchErrorDomain>("domain", "http://schemas.google.com/g/2005");
			}
			set
			{
				SetStringValue<BatchErrorDomain>(value.ToString(), "domain", "http://schemas.google.com/g/2005");
			}
		}

		public string Code
		{
			get
			{
				return GetStringValue<BatchErrorCode>("code", "http://schemas.google.com/g/2005");
			}
			set
			{
				SetStringValue<BatchErrorCode>(value.ToString(), "code", "http://schemas.google.com/g/2005");
			}
		}

		public BatchErrorLocation Location
		{
			get
			{
				return FindExtension("location", "http://schemas.google.com/g/2005") as BatchErrorLocation;
			}
			set
			{
				ReplaceExtension("location", "http://schemas.google.com/g/2005", value);
			}
		}

		public string InternalReason
		{
			get
			{
				return GetStringValue<BatchErrorInternalReason>("internalReason", "http://schemas.google.com/g/2005");
			}
			set
			{
				SetStringValue<BatchErrorInternalReason>(value.ToString(), "internalReason", "http://schemas.google.com/g/2005");
			}
		}

		public string Id
		{
			get
			{
				return GetStringValue<BatchErrorId>("id", "http://www.w3.org/2005/Atom");
			}
			set
			{
				SetStringValue<BatchErrorId>(value.ToString(), "id", "http://www.w3.org/2005/Atom");
			}
		}

		public BatchError()
			: base("error", "gd", "http://schemas.google.com/g/2005")
		{
			base.ExtensionFactories.Add(new BatchErrorDomain());
			base.ExtensionFactories.Add(new BatchErrorCode());
			base.ExtensionFactories.Add(new BatchErrorLocation());
			base.ExtensionFactories.Add(new BatchErrorInternalReason());
			base.ExtensionFactories.Add(new BatchErrorId());
		}
	}
}
