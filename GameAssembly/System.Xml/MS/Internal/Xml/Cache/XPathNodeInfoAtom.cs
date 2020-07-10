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
	internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1902
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
		private int hashCode; // 0x58
		private int localNameHash; // 0x5C
		private XPathNodePageInfo pageInfo; // 0x60
	
		// Properties
		public XPathNodePageInfo PageInfo { get; } // 0x0000000180369B40-0x0000000180369B50 
		public string LocalName { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string NamespaceUri { get; } // 0x000000018038B150-0x000000018038B160 
		public string Prefix { get; } // 0x000000018036AC70-0x000000018036AC80 
		public string BaseUri { get; } // 0x0000000180369B60-0x0000000180369B70 
		public XPathNode[] SiblingPage { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		public XPathNode[] SimilarElementPage { get; } // 0x0000000180369B30-0x0000000180369B40 
		public XPathNode[] ParentPage { get; } // 0x0000000180397720-0x0000000180397730 
		public XPathDocument Document { get; } // 0x0000000180369C40-0x0000000180369C50 
		public int LineNumberBase { get; } // 0x0000000180369BA0-0x0000000180369BB0 
		public int LinePositionBase { get; } // 0x0000000180369C60-0x0000000180369C70 
	
		// Methods
		public override int GetHashCode(); // 0x0000000180C9B660-0x0000000180C9B790
		public override bool Equals(object other); // 0x0000000180C9B560-0x0000000180C9B660
		public override string ToString(); // 0x0000000180C9B790-0x0000000180C9BC60
	}
}
