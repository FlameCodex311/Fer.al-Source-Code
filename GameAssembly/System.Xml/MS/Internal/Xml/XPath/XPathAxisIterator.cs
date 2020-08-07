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

namespace MS.Internal.Xml.XPath
{
	internal abstract class XPathAxisIterator : XPathNodeIterator // TypeDefIndex: 1986
	{
		// Fields
		internal XPathNavigator nav; // 0x18
		internal XPathNodeType type; // 0x20
		internal string name; // 0x28
		internal string uri; // 0x30
		internal int position; // 0x38
		internal bool matchSelf; // 0x3C
		internal bool first; // 0x3D
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180372430-0x0000000180372440 
		public override int CurrentPosition { get; } // 0x000000018057D1C0-0x000000018057D1D0 
		protected virtual bool Matches { get; } // 0x00000001819CD840-0x00000001819CD9C0 
	
		// Constructors
		public XPathAxisIterator(XPathNavigator nav, bool matchSelf); // 0x00000001819CD7B0-0x00000001819CD7F0
		public XPathAxisIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf); // 0x00000001819CD7F0-0x00000001819CD840
		public XPathAxisIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf); // 0x00000001819CD650-0x00000001819CD730
		public XPathAxisIterator(XPathAxisIterator it); // 0x00000001819CD730-0x00000001819CD7B0
	}
}
