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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument // TypeDefIndex: 8202
	{
		// Properties
		private XDocument Document { get; } // 0x0000000180C791D0-0x0000000180C79260 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180C78FE0-0x0000000180C790E0 
		public IXmlElement DocumentElement { get; } // 0x0000000180C790E0-0x0000000180C791D0 
	
		// Constructors
		public XDocumentWrapper(XDocument document); // 0x0000000180C78190-0x0000000180C78200
	
		// Methods
		public IXmlNode CreateComment(string text); // 0x0000000180C78A10-0x0000000180C78A80
		public IXmlNode CreateTextNode(string text); // 0x0000000180C78D40-0x0000000180C78DB0
		public IXmlNode CreateCDataSection(string data); // 0x0000000180C789A0-0x0000000180C78A10
		public IXmlNode CreateWhitespace(string text); // 0x0000000180C78DB0-0x0000000180C78E20
		public IXmlNode CreateSignificantWhitespace(string text); // 0x0000000180C78CD0-0x0000000180C78D40
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x0000000180C78E20-0x0000000180C78F00
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x0000000180C78F00-0x0000000180C78FE0
		public IXmlNode CreateProcessingInstruction(string target, string data); // 0x0000000180C78C10-0x0000000180C78CD0
		public IXmlElement CreateElement(string elementName); // 0x0000000180C78B50-0x0000000180C78C10
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x0000000180C78A80-0x0000000180C78B50
		public IXmlNode CreateAttribute(string name, string value); // 0x0000000180C788D0-0x0000000180C789A0
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value); // 0x0000000180C787F0-0x0000000180C788D0
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180C786C0-0x0000000180C787F0
	}
}
