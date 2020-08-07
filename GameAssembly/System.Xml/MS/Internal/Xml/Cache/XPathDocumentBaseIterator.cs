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
	internal abstract class XPathDocumentBaseIterator : XPathNodeIterator // TypeDefIndex: 1997
	{
		// Fields
		protected XPathDocumentNavigator ctxt; // 0x18
		protected int pos; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180372430-0x0000000180372440 
		public override int CurrentPosition { get; } // 0x00000001803FB670-0x00000001803FB680 
	
		// Constructors
		protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt); // 0x00000001819CDE60-0x00000001819CDF00
		protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter); // 0x00000001819CDF00-0x00000001819CDFC0
	}
}
