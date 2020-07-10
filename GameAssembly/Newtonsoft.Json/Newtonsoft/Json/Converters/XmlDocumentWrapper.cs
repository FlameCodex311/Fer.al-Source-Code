/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument // TypeDefIndex: 8024
	{
		// Fields
		private readonly XmlDocument _document; // 0x28
	
		// Properties
		public IXmlElement DocumentElement { get; } // 0x000000018069B0E0-0x000000018069B180 
	
		// Constructors
		public XmlDocumentWrapper(XmlDocument document); // 0x000000018069A8E0-0x000000018069A910
	
		// Methods
		public IXmlNode CreateComment(string data); // 0x000000018069ABE0-0x000000018069AC60
		public IXmlNode CreateTextNode(string text); // 0x000000018069AE80-0x000000018069AF00
		public IXmlNode CreateCDataSection(string data); // 0x000000018069AB60-0x000000018069ABE0
		public IXmlNode CreateWhitespace(string text); // 0x000000018069AF00-0x000000018069AF80
		public IXmlNode CreateSignificantWhitespace(string text); // 0x000000018069AE00-0x000000018069AE80
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x000000018069AF80-0x000000018069B030
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x000000018069B030-0x000000018069B0E0
		public IXmlNode CreateProcessingInstruction(string target, string data); // 0x000000018069AD70-0x000000018069AE00
		public IXmlElement CreateElement(string elementName); // 0x000000018069ACF0-0x000000018069AD70
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x000000018069AC60-0x000000018069ACF0
		public IXmlNode CreateAttribute(string name, string value); // 0x000000018069A9F0-0x000000018069AAA0
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value); // 0x000000018069AAA0-0x000000018069AB60
	}
}
