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
	internal abstract class XPathDocumentBaseIterator : XPathNodeIterator // TypeDefIndex: 1892
	{
		// Fields
		protected XPathDocumentNavigator ctxt; // 0x18
		protected int pos; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x000000018038B150-0x000000018038B160 
		public override int CurrentPosition { get; } // 0x00000001803C2700-0x00000001803C2710 
	
		// Constructors
		protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt); // 0x0000000180C961C0-0x0000000180C96260
		protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter); // 0x0000000180C96260-0x0000000180C96320
	}
}
