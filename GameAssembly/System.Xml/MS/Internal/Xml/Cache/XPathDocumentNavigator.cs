/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XPath;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1897
	{
		// Fields
		private XPathNode[] pageCurrent; // 0x10
		private XPathNode[] pageParent; // 0x18
		private int idxCurrent; // 0x20
		private int idxParent; // 0x24
		private string atomizedLocalName; // 0x28
	
		// Properties
		public override string Value { get; } // 0x0000000180C99850-0x0000000180C99B90 
		public override XPathNodeType NodeType { get; } // 0x0000000180C997A0-0x0000000180C997F0 
		public override string LocalName { get; } // 0x0000000180C99620-0x0000000180C99680 
		public override string NamespaceURI { get; } // 0x0000000180C99740-0x0000000180C997A0 
		public override string Name { get; } // 0x0000000180C996F0-0x0000000180C99740 
		public override string Prefix { get; } // 0x0000000180C997F0-0x0000000180C99850 
		public override string BaseURI { get; } // 0x0000000180C99340-0x0000000180C99470 
		public override XmlNameTable NameTable { get; } // 0x0000000180C99680-0x0000000180C996F0 
		public override object UnderlyingObject { get; } // 0x000000018059F550-0x000000018059F570 
		public int LineNumber { get; } // 0x0000000180C99470-0x0000000180C99540 
		public int LinePosition { get; } // 0x0000000180C99540-0x0000000180C99620 
	
		// Constructors
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent); // 0x0000000180C992B0-0x0000000180C99340
		public XPathDocumentNavigator(XPathDocumentNavigator nav); // 0x0000000180C99250-0x0000000180C992B0
	
		// Methods
		public override XPathNavigator Clone(); // 0x0000000180C96EA0-0x0000000180C96F40
		public override bool MoveToFirstAttribute(); // 0x0000000180C979E0-0x0000000180C97A70
		public override bool MoveToNextAttribute(); // 0x0000000180C98560-0x0000000180C98610
		public override bool MoveToAttribute(string localName, string namespaceURI); // 0x0000000180C97790-0x0000000180C97850
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope); // 0x0000000180C97B50-0x0000000180C97E80
		public override bool MoveToNextNamespace(XPathNamespaceScope scope); // 0x0000000180C98610-0x0000000180C98810
		public override bool MoveToNext(); // 0x0000000180C98970-0x0000000180C98A20
		public override bool MoveToFirstChild(); // 0x0000000180C97A70-0x0000000180C97B50
		public override bool MoveToParent(); // 0x0000000180C98AB0-0x0000000180C98B40
		public override bool MoveTo(XPathNavigator other); // 0x0000000180C98BC0-0x0000000180C98C40
		public override bool MoveToId(string id); // 0x0000000180C984B0-0x0000000180C98560
		public override bool IsSamePosition(XPathNavigator other); // 0x0000000180C97700-0x0000000180C97790
		public override void MoveToRoot(); // 0x0000000180C98B40-0x0000000180C98BC0
		public override bool MoveToChild(string localName, string namespaceURI); // 0x0000000180C97950-0x0000000180C979E0
		public override bool MoveToNext(string localName, string namespaceURI); // 0x0000000180C98A20-0x0000000180C98AB0
		public override bool MoveToChild(XPathNodeType type); // 0x0000000180C97850-0x0000000180C97950
		public override bool MoveToNext(XPathNodeType type); // 0x0000000180C98810-0x0000000180C98970
		public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end); // 0x0000000180C982C0-0x0000000180C984B0
		public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end); // 0x0000000180C97E80-0x0000000180C982C0
		public override XPathNodeIterator SelectChildren(XPathNodeType type); // 0x0000000180C98C40-0x0000000180C98D10
		public override XPathNodeIterator SelectChildren(string name, string namespaceURI); // 0x0000000180C98D10-0x0000000180C98EC0
		public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf); // 0x0000000180C98EC0-0x0000000180C99030
		public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf); // 0x0000000180C99030-0x0000000180C99250
		public override XmlNodeOrder ComparePosition(XPathNavigator other); // 0x0000000180C96F40-0x0000000180C970A0
		public override bool IsDescendant(XPathNavigator other); // 0x0000000180C97410-0x0000000180C97550
		private int GetPrimaryLocation(); // 0x0000000180C971A0-0x0000000180C97260
		private int GetSecondaryLocation(); // 0x0000000180C97260-0x0000000180C973A0
		public bool HasLineInfo(); // 0x0000000180C973A0-0x0000000180C97410
		public int GetPositionHashCode(); // 0x0000000180C97190-0x0000000180C971A0
		public bool IsElementMatch(string localName, string namespaceURI); // 0x0000000180C97550-0x0000000180C97650
		public bool IsKindMatch(XPathNodeType typ); // 0x0000000180C97650-0x0000000180C97700
		private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd); // 0x0000000180C970A0-0x0000000180C97190
	}
}
