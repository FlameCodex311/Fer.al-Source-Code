/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument // TypeDefIndex: 8036
	{
		// Properties
		private XDocument Document { get; } // 0x0000000180699B90-0x0000000180699C20 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180699990-0x0000000180699AA0 
		public IXmlElement DocumentElement { get; } // 0x0000000180699AA0-0x0000000180699B90 
	
		// Constructors
		public XDocumentWrapper(XDocument document); // 0x0000000180698B70-0x0000000180698BE0
	
		// Methods
		public IXmlNode CreateComment(string text); // 0x00000001806993C0-0x0000000180699430
		public IXmlNode CreateTextNode(string text); // 0x00000001806996F0-0x0000000180699760
		public IXmlNode CreateCDataSection(string data); // 0x0000000180699350-0x00000001806993C0
		public IXmlNode CreateWhitespace(string text); // 0x0000000180699760-0x00000001806997D0
		public IXmlNode CreateSignificantWhitespace(string text); // 0x0000000180699680-0x00000001806996F0
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x00000001806997D0-0x00000001806998B0
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x00000001806998B0-0x0000000180699990
		public IXmlNode CreateProcessingInstruction(string target, string data); // 0x00000001806995C0-0x0000000180699680
		public IXmlElement CreateElement(string elementName); // 0x0000000180699500-0x00000001806995C0
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x0000000180699430-0x0000000180699500
		public IXmlNode CreateAttribute(string name, string value); // 0x0000000180699280-0x0000000180699350
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value); // 0x00000001806991A0-0x0000000180699280
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180699070-0x00000001806991A0
	}
}
