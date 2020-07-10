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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class XmlNodeConverter : JsonConverter // TypeDefIndex: 8044
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <DeserializeRootElementName>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <WriteArrayAttribute>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <OmitRootObject>k__BackingField; // 0x19
	
		// Properties
		public string DeserializeRootElementName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
		public bool WriteArrayAttribute { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018041BAC0-0x000000018041BAD0 
		public bool OmitRootObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018048F440-0x000000018048F450 
	
		// Constructors
		public XmlNodeConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x00000001806A0CE0-0x00000001806A0E10
		private IXmlNode WrapXml(object value); // 0x00000001806A0B50-0x00000001806A0CE0
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager); // 0x000000018069E030-0x000000018069E4B0
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager); // 0x000000018069F670-0x000000018069F810
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager); // 0x000000018069DA40-0x000000018069DD10
		private bool IsArray(IXmlNode node); // 0x000000018069DD10-0x000000018069DF60
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x000000018069F810-0x000000018069FC90
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x000000018069FC90-0x00000001806A09B0
		private static bool AllSameName(IXmlNode node); // 0x000000018069B680-0x000000018069B860
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x000000018069F170-0x000000018069F670
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode); // 0x000000018069D640-0x000000018069DA40
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager); // 0x000000018069EEC0-0x000000018069F170
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues); // 0x000000018069C4F0-0x000000018069CAB0
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix); // 0x000000018069B2F0-0x000000018069B4C0
		private string ConvertTokenToXmlValue(JsonReader reader); // 0x000000018069B960-0x000000018069C010
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager); // 0x000000018069E4B0-0x000000018069E880
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document); // 0x000000018069B4C0-0x000000018069B680
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager); // 0x000000018069E880-0x000000018069EEC0
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName); // 0x000000018069CAB0-0x000000018069CE70
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode); // 0x000000018069C010-0x000000018069C3C0
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager); // 0x000000018069C3C0-0x000000018069C4F0
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode); // 0x000000018069CE70-0x000000018069D640
		private bool IsNamespaceAttribute(string attributeName, out string prefix); // 0x000000018069DF60-0x000000018069E030
		private bool ValueAttributes(List<IXmlNode> c); // 0x00000001806A09B0-0x00000001806A0B50
		public override bool CanConvert(Type valueType); // 0x000000018069B860-0x000000018069B960
	}
}
