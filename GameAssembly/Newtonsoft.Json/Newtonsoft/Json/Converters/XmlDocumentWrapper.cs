/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument // TypeDefIndex: 8190
	{
		// Fields
		private readonly XmlDocument _document; // 0x28
	
		// Properties
		public IXmlElement DocumentElement { get; } // 0x0000000180C7A660-0x0000000180C7A700 
	
		// Constructors
		public XmlDocumentWrapper(XmlDocument document); // 0x0000000180C79EA0-0x0000000180C79ED0
	
		// Methods
		public IXmlNode CreateComment(string data); // 0x0000000180C7A160-0x0000000180C7A1E0
		public IXmlNode CreateTextNode(string text); // 0x0000000180C7A400-0x0000000180C7A480
		public IXmlNode CreateCDataSection(string data); // 0x0000000180C7A0E0-0x0000000180C7A160
		public IXmlNode CreateWhitespace(string text); // 0x0000000180C7A480-0x0000000180C7A500
		public IXmlNode CreateSignificantWhitespace(string text); // 0x0000000180C7A380-0x0000000180C7A400
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x0000000180C7A500-0x0000000180C7A5B0
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x0000000180C7A5B0-0x0000000180C7A660
		public IXmlNode CreateProcessingInstruction(string target, string data); // 0x0000000180C7A2F0-0x0000000180C7A380
		public IXmlElement CreateElement(string elementName); // 0x0000000180C7A270-0x0000000180C7A2F0
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x0000000180C7A1E0-0x0000000180C7A270
		public IXmlNode CreateAttribute(string name, string value); // 0x0000000180C79F70-0x0000000180C7A020
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value); // 0x0000000180C7A020-0x0000000180C7A0E0
	}
}
