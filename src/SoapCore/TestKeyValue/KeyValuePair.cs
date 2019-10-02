using System;
using System.Xml.Serialization;

namespace SoapCore.TestKeyValue
{
	[Serializable]
	[XmlType("KeyValuePair")]
	public class KeyValuePair<K, V>
	{
		public KeyValuePair()
		{
		}

		public KeyValuePair(K key, V value)
		{
			Key = key;
			Value = value;
		}

		public K Key { get; set; }
		public V Value { get; set; }
	}
}
