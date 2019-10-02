using System;
using System.Collections;
using System.Xml;

namespace SoapCore.TestKeyValue
{
	public static class SerializableKeyPairValue
	{
		public static void Serialize(this XmlWriter writer, object result, string parameterName, string parameterNs)
		{
			writer.WriteStartElement(parameterName, parameterNs);
			foreach (var keyValueObject in (IList)result)
			{
				var key = keyValueObject.GetType().GetProperty("Key");
				var value = keyValueObject.GetType().GetProperty("Value");
				var keyObj = (key != null) ? key.GetValue(keyValueObject) : string.Empty;
				var valueObj = (value != null) ? value.GetValue(keyValueObject) : string.Empty;
				writer.WriteStartElement($@"KeyValuePairOf{keyValueObject.GetType().GenericTypeArguments[0].Name}{keyValueObject.GetType().GenericTypeArguments[1].Name}", parameterNs);

				writer.WriteStartElement("Key", parameterNs);
                writer.WriteValue(keyObj);
                writer.WriteEndElement();

                writer.WriteStartElement("Value", parameterNs);
                writer.WriteValue(valueObj);
                writer.WriteEndElement();

                writer.WriteEndElement();
			}
		}
	}
}
