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
	internal sealed class XPathNodeInfoAtom // TypeDefIndex: 2007
	{
		// Fields
		private string localName; // 0x10
		private string namespaceUri; // 0x18
		private string prefix; // 0x20
		private string baseUri; // 0x28
		private XPathNode[] pageParent; // 0x30
		private XPathNode[] pageSibling; // 0x38
		private XPathNode[] pageSimilar; // 0x40
		private XPathDocument doc; // 0x48
		private int lineNumBase; // 0x50
		private int linePosBase; // 0x54
		private XPathNodePageInfo pageInfo; // 0x58
	
		// Properties
		public XPathNodePageInfo PageInfo { get; } // 0x00000001803A1580-0x00000001803A1590 
		public string LocalName { get; } // 0x0000000180372440-0x0000000180372450 
		public string NamespaceUri { get; } // 0x0000000180372430-0x0000000180372440 
		public string Prefix { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public string BaseUri { get; } // 0x00000001803745B0-0x00000001803745C0 
		public XPathNode[] SiblingPage { get; } // 0x00000001803743D0-0x00000001803743E0 
		public XPathNode[] SimilarElementPage { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public XPathNode[] ParentPage { get; } // 0x00000001803745C0-0x00000001803745D0 
		public XPathDocument Document { get; } // 0x00000001803743E0-0x00000001803743F0 
		public int LineNumberBase { get; } // 0x00000001803F8270-0x00000001803F8280 
		public int LinePositionBase { get; } // 0x0000000180379EE0-0x0000000180379EF0 
	}
}
