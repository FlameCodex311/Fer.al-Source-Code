/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.Cache
{
	internal struct XPathNode // TypeDefIndex: 2003
	{
		// Fields
		private XPathNodeInfoAtom info; // 0x00
		private ushort idxSibling; // 0x08
		private ushort idxParent; // 0x0A
		private ushort idxSimilar; // 0x0C
		private ushort posOffset; // 0x0E
		private uint props; // 0x10
		private string value; // 0x18
	
		// Properties
		public XPathNodeType NodeType { get; } // 0x000000018010DE00-0x000000018010DE10 
		public string Prefix { get; } // 0x000000018010DE30-0x000000018010E0C0 
		public string LocalName { get; } // 0x00000001800C3440-0x00000001800C3460 
		public string Name { get; } // 0x000000018010DDD0-0x000000018010DDE0 
		public string NamespaceUri { get; } // 0x000000018010DDE0-0x000000018010DE00 
		public XPathDocument Document { get; } // 0x000000018010DC70-0x000000018010DC90 
		public string BaseUri { get; } // 0x000000018010DC20-0x000000018010DC40 
		public int LineNumber { get; } // 0x000000018010DD80-0x000000018010DDB0 
		public int LinePosition { get; } // 0x000000018010DDB0-0x000000018010DDD0 
		public int CollapsedLinePosition { get; } // 0x000000018010DC40-0x000000018010DC70 
		public XPathNodePageInfo PageInfo { get; } // 0x000000018010DE10-0x000000018010DE30 
		public bool IsXmlNamespaceNode { get; } // 0x000000018010DD70-0x000000018010DD80 
		public bool HasSibling { get; } // 0x000000018010DCE0-0x000000018010DCF0 
		public bool HasCollapsedText { get; } // 0x000000018010DCA0-0x000000018010DCB0 
		public bool HasAttribute { get; } // 0x000000018010DC90-0x000000018010DCA0 
		public bool HasContentChild { get; } // 0x000000018010DCB0-0x000000018010DCC0 
		public bool HasElementChild { get; } // 0x000000018010DCC0-0x000000018010DCD0 
		public bool IsAttrNmsp { get; } // 0x000000018010DCF0-0x000000018010DD10 
		public bool IsText { get; } // 0x000000018010DD10-0x000000018010DD70 
		public bool HasNamespaceDecls { get; } // 0x000000018010DCD0-0x000000018010DCE0 
		public string Value { get; } // 0x0000000180003250-0x0000000180003270 
	
		// Methods
		public int GetRoot(out XPathNode[] pageNode); // 0x000000018010DB40-0x000000018010DB70
		public int GetParent(out XPathNode[] pageNode); // 0x000000018010DB10-0x000000018010DB40
		public int GetSibling(out XPathNode[] pageNode); // 0x000000018010DB70-0x000000018010DBA0
		public int GetSimilarElement(out XPathNode[] pageNode); // 0x000000018010DBA0-0x000000018010DBD0
		public bool NameMatch(string localName, string namespaceName); // 0x000000018010DBD0-0x000000018010DC20
		public bool ElementMatch(string localName, string namespaceName); // 0x000000018010DAC0-0x000000018010DB10
	}
}
