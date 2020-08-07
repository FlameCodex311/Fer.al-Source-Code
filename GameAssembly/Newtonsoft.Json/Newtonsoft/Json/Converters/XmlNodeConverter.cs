/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class XmlNodeConverter : JsonConverter // TypeDefIndex: 8210
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <DeserializeRootElementName>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <WriteArrayAttribute>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <OmitRootObject>k__BackingField; // 0x19
	
		// Properties
		public string DeserializeRootElementName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
		public bool WriteArrayAttribute { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803F6D30-0x00000001803F6D40 
		public bool OmitRootObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180690340-0x0000000180690350 
	
		// Constructors
		public XmlNodeConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C800D0-0x0000000180C801F0
		private IXmlNode WrapXml(object value); // 0x0000000180C7FF40-0x0000000180C800D0
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager); // 0x0000000180C7D4E0-0x0000000180C7D950
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager); // 0x0000000180C7EAC0-0x0000000180C7EC60
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager); // 0x0000000180C7CF00-0x0000000180C7D1C0
		private bool IsArray(IXmlNode node); // 0x0000000180C7D1C0-0x0000000180C7D410
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x0000000180C7EC60-0x0000000180C7F0D0
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x0000000180C7F0D0-0x0000000180C7FDB0
		private static bool AllSameName(IXmlNode node); // 0x0000000180C7ABF0-0x0000000180C7ADD0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C7E5E0-0x0000000180C7EAC0
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode); // 0x0000000180C7CB30-0x0000000180C7CF00
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager); // 0x0000000180C7E340-0x0000000180C7E5E0
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues); // 0x0000000180C7BA20-0x0000000180C7BFC0
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix); // 0x0000000180C7A870-0x0000000180C7AA30
		private string ConvertTokenToXmlValue(JsonReader reader); // 0x0000000180C7AEC0-0x0000000180C7B560
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager); // 0x0000000180C7D950-0x0000000180C7DD10
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document); // 0x0000000180C7AA30-0x0000000180C7ABF0
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager); // 0x0000000180C7DD10-0x0000000180C7E340
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName); // 0x0000000180C7BFC0-0x0000000180C7C370
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode); // 0x0000000180C7B560-0x0000000180C7B8F0
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager); // 0x0000000180C7B8F0-0x0000000180C7BA20
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode); // 0x0000000180C7C370-0x0000000180C7CB30
		private bool IsNamespaceAttribute(string attributeName, out string prefix); // 0x0000000180C7D410-0x0000000180C7D4E0
		private bool ValueAttributes(List<IXmlNode> c); // 0x0000000180C7FDB0-0x0000000180C7FF40
		public override bool CanConvert(Type valueType); // 0x0000000180C7ADD0-0x0000000180C7AEC0
	}
}
