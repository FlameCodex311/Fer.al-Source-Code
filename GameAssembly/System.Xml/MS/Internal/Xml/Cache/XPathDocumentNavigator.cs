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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 2002
	{
		// Fields
		private XPathNode[] pageCurrent; // 0x10
		private XPathNode[] pageParent; // 0x18
		private int idxCurrent; // 0x20
		private int idxParent; // 0x24
		private string atomizedLocalName; // 0x28
	
		// Properties
		public override string Value { get; } // 0x00000001819D1550-0x00000001819D1860 
		public override XPathNodeType NodeType { get; } // 0x00000001819D14C0-0x00000001819D1500 
		public override string LocalName { get; } // 0x00000001819D1370-0x00000001819D13C0 
		public override string NamespaceURI { get; } // 0x00000001819D1470-0x00000001819D14C0 
		public override string Name { get; } // 0x00000001819D1420-0x00000001819D1470 
		public override string Prefix { get; } // 0x00000001819D1500-0x00000001819D1550 
		public override string BaseURI { get; } // 0x00000001819D10C0-0x00000001819D11E0 
		public override XmlNameTable NameTable { get; } // 0x00000001819D13C0-0x00000001819D1420 
		public override object UnderlyingObject { get; } // 0x00000001808B3AF0-0x00000001808B3B10 
		public int LineNumber { get; } // 0x00000001819D11E0-0x00000001819D12A0 
		public int LinePosition { get; } // 0x00000001819D12A0-0x00000001819D1370 
	
		// Constructors
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent); // 0x00000001819D1030-0x00000001819D10C0
		public XPathDocumentNavigator(XPathDocumentNavigator nav); // 0x00000001819D0FE0-0x00000001819D1030
	
		// Methods
		public override XPathNavigator Clone(); // 0x00000001819CEB30-0x00000001819CEBD0
		public override bool MoveToFirstAttribute(); // 0x00000001819CF5F0-0x00000001819CF680
		public override bool MoveToNextAttribute(); // 0x00000001819D0230-0x00000001819D02D0
		public override bool MoveToAttribute(string localName, string namespaceURI); // 0x00000001819CF3B0-0x00000001819CF470
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope); // 0x00000001819CF880-0x00000001819CFB80
		public override bool MoveToNextNamespace(XPathNamespaceScope scope); // 0x00000001819D02D0-0x00000001819D04C0
		public override bool MoveToNext(); // 0x00000001819D0610-0x00000001819D06B0
		public override bool MoveToFirstChild(); // 0x00000001819CF680-0x00000001819CF880
		public override bool MoveToParent(); // 0x00000001819D0850-0x00000001819D08E0
		public override bool MoveTo(XPathNavigator other); // 0x00000001819D0960-0x00000001819D09E0
		public override bool MoveToId(string id); // 0x00000001819D0180-0x00000001819D0230
		public override bool IsSamePosition(XPathNavigator other); // 0x00000001819CF320-0x00000001819CF3B0
		public override void MoveToRoot(); // 0x00000001819D08E0-0x00000001819D0960
		public override bool MoveToChild(string localName, string namespaceURI); // 0x00000001819CF560-0x00000001819CF5F0
		public override bool MoveToNext(string localName, string namespaceURI); // 0x00000001819D06B0-0x00000001819D0850
		public override bool MoveToChild(XPathNodeType type); // 0x00000001819CF470-0x00000001819CF560
		public override bool MoveToNext(XPathNodeType type); // 0x00000001819D04C0-0x00000001819D0610
		public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end); // 0x00000001819CFFA0-0x00000001819D0180
		public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end); // 0x00000001819CFB80-0x00000001819CFFA0
		public override XPathNodeIterator SelectChildren(XPathNodeType type); // 0x00000001819D09E0-0x00000001819D0AB0
		public override XPathNodeIterator SelectChildren(string name, string namespaceURI); // 0x00000001819D0AB0-0x00000001819D0C50
		public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf); // 0x00000001819D0C50-0x00000001819D0DC0
		public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf); // 0x00000001819D0DC0-0x00000001819D0FE0
		public override XmlNodeOrder ComparePosition(XPathNavigator other); // 0x00000001819CEBD0-0x00000001819CED30
		public override bool IsDescendant(XPathNavigator other); // 0x00000001819CF050-0x00000001819CF170
		private int GetPrimaryLocation(); // 0x00000001819CEE20-0x00000001819CEED0
		private int GetSecondaryLocation(); // 0x00000001819CEED0-0x00000001819CEFF0
		public bool HasLineInfo(); // 0x00000001819CEFF0-0x00000001819CF050
		public int GetPositionHashCode(); // 0x00000001819CEE10-0x00000001819CEE20
		public bool IsElementMatch(string localName, string namespaceURI); // 0x00000001819CF170-0x00000001819CF270
		public bool IsKindMatch(XPathNodeType typ); // 0x00000001819CF270-0x00000001819CF320
		private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd); // 0x00000001819CED30-0x00000001819CEE10
	}
}
