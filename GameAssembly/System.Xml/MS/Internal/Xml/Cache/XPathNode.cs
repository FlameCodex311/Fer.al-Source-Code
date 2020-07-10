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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.Cache
{
	internal struct XPathNode // TypeDefIndex: 1898
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
		public XPathNodeType NodeType { get; } // 0x00000001800216E0-0x00000001800216F0 
		public string Prefix { get; } // 0x0000000180021710-0x00000001800218C0 
		public string LocalName { get; } // 0x0000000180019170-0x0000000180019190 
		public string Name { get; } // 0x00000001800216B0-0x00000001800216C0 
		public string NamespaceUri { get; } // 0x00000001800216C0-0x00000001800216E0 
		public XPathDocument Document { get; } // 0x0000000180021540-0x0000000180021560 
		public string BaseUri { get; } // 0x00000001800214F0-0x0000000180021510 
		public int LineNumber { get; } // 0x0000000180021650-0x0000000180021680 
		public int LinePosition { get; } // 0x0000000180021680-0x00000001800216B0 
		public int CollapsedLinePosition { get; } // 0x0000000180021510-0x0000000180021540 
		public XPathNodePageInfo PageInfo { get; } // 0x00000001800216F0-0x0000000180021710 
		public bool IsXmlNamespaceNode { get; } // 0x0000000180021640-0x0000000180021650 
		public bool HasSibling { get; } // 0x00000001800215B0-0x00000001800215C0 
		public bool HasCollapsedText { get; } // 0x0000000180021570-0x0000000180021580 
		public bool HasAttribute { get; } // 0x0000000180021560-0x0000000180021570 
		public bool HasContentChild { get; } // 0x0000000180021580-0x0000000180021590 
		public bool HasElementChild { get; } // 0x0000000180021590-0x00000001800215A0 
		public bool IsAttrNmsp { get; } // 0x00000001800215C0-0x00000001800215E0 
		public bool IsText { get; } // 0x00000001800215E0-0x0000000180021640 
		public bool HasNamespaceDecls { get; } // 0x00000001800215A0-0x00000001800215B0 
		public string Value { get; } // 0x0000000180002430-0x00000001800024A0 
	
		// Methods
		public int GetRoot(out XPathNode[] pageNode); // 0x0000000180021410-0x0000000180021440
		public int GetParent(out XPathNode[] pageNode); // 0x00000001800213E0-0x0000000180021410
		public int GetSibling(out XPathNode[] pageNode); // 0x0000000180021440-0x0000000180021470
		public int GetSimilarElement(out XPathNode[] pageNode); // 0x0000000180021470-0x00000001800214A0
		public bool NameMatch(string localName, string namespaceName); // 0x00000001800214A0-0x00000001800214F0
		public bool ElementMatch(string localName, string namespaceName); // 0x0000000180021390-0x00000001800213E0
	}
}
