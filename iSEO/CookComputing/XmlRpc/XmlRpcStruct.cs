using System;
using System.Collections;

namespace CookComputing.XmlRpc
{
	public class XmlRpcStruct : Hashtable
	{
		public override object this[object key]
		{
			get
			{
				return base[key];
			}
			set
			{
				if (!(key is string))
				{
					throw new ArgumentException("XmlRpcStruct key must be a string.");
				}
				if (XmlRpcServiceInfo.GetXmlRpcType(value.GetType()) == XmlRpcType.tInvalid)
				{
					throw new ArgumentException($"Type {value.GetType()} cannot be mapped to an XML-RPC type");
				}
				base[key] = value;
			}
		}

		public override void Add(object key, object value)
		{
			if (!(key is string))
			{
				throw new ArgumentException("XmlRpcStruct key must be a string.");
			}
			if (XmlRpcServiceInfo.GetXmlRpcType(value.GetType()) == XmlRpcType.tInvalid)
			{
				throw new ArgumentException($"Type {value.GetType()} cannot be mapped to an XML-RPC type");
			}
			base.Add(key, value);
		}

		public override bool Equals(object obj)
		{
			if ((object)obj.GetType() != typeof(XmlRpcStruct))
			{
				return false;
			}
			XmlRpcStruct xmlRpcStruct = (XmlRpcStruct)obj;
			if (Keys.Count != xmlRpcStruct.Count)
			{
				return false;
			}
			foreach (string key in Keys)
			{
				if (xmlRpcStruct.ContainsKey(key))
				{
					if (!this[key].Equals(xmlRpcStruct[key]))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			int num = 0;
			foreach (object value in Values)
			{
				num ^= value.GetHashCode();
			}
			return num;
		}
	}
}
