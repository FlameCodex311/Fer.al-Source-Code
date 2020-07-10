/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	[Serializable]
	public class SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, IXmlSerializable, ISerializable // TypeDefIndex: 9963
	{
		// Fields
		private const string ItemNodeName = "Item"; // Metadata: 0x00746774
		private const string KeyNodeName = "Key"; // Metadata: 0x0074677C
		private const string ValueNodeName = "Value"; // Metadata: 0x00746783
		private XmlSerializer keySerializer;
		private XmlSerializer valueSerializer;
	
		// Properties
		private XmlSerializer ValueSerializer { get; }
		private XmlSerializer KeySerializer { get; }
	
		// Constructors
		public SerializableDictionary();
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary);
		public SerializableDictionary(IEqualityComparer<TKey> comparer);
		public SerializableDictionary(int capacity);
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary, IEqualityComparer<TKey> comparer);
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer);
		protected SerializableDictionary(SerializationInfo info, StreamingContext context);
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
		void IXmlSerializable.WriteXml(XmlWriter writer);
		void IXmlSerializable.ReadXml(XmlReader reader);
		XmlSchema IXmlSerializable.GetSchema();
	}
}
