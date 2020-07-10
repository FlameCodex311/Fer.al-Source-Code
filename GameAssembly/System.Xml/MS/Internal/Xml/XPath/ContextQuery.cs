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

namespace MS.Internal.Xml.XPath
{
	internal class ContextQuery : Query // TypeDefIndex: 1832
	{
		// Fields
		protected XPathNavigator contextNode; // 0x18
	
		// Properties
		public override XPathNavigator Current { get; } // 0x000000018038B150-0x000000018038B160 
		public override XPathResultType StaticType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override int CurrentPosition { get; } // 0x000000018036CFF0-0x000000018036D000 
		public override int Count { get; } // 0x000000018042E670-0x000000018042E680 
		public override QueryProps Properties { get; } // 0x00000001809EE170-0x00000001809EE180 
	
		// Constructors
		public ContextQuery(); // 0x0000000180C830E0-0x0000000180C83100
		protected ContextQuery(ContextQuery other); // 0x0000000180C83100-0x0000000180C83140
	
		// Methods
		public override void Reset(); // 0x0000000180C84750-0x0000000180C84760
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C85AA0-0x0000000180C85AE0
		public override XPathNavigator Advance(); // 0x0000000180C85A10-0x0000000180C85A30
		public override XPathNodeIterator Clone(); // 0x0000000180C85A30-0x0000000180C85AA0
	}
}
