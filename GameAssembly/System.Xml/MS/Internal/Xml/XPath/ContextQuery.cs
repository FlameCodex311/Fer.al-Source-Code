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
	internal class ContextQuery : Query // TypeDefIndex: 1937
	{
		// Fields
		protected XPathNavigator contextNode; // 0x18
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180372430-0x0000000180372440 
		public override XPathResultType StaticType { get; } // 0x000000018043E010-0x000000018043E020 
		public override int CurrentPosition { get; } // 0x0000000180387590-0x0000000180387930 
		public override int Count { get; } // 0x000000018058C710-0x000000018058C720 
		public override QueryProps Properties { get; } // 0x0000000181451370-0x0000000181451380 
	
		// Constructors
		public ContextQuery(); // 0x00000001819BAF40-0x00000001819BAF60
		protected ContextQuery(ContextQuery other); // 0x00000001819BAF60-0x00000001819BAFA0
	
		// Methods
		public override void Reset(); // 0x00000001819BC570-0x00000001819BC580
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819BD880-0x00000001819BD8C0
		public override XPathNavigator Advance(); // 0x00000001819BD7F0-0x00000001819BD810
		public override XPathNodeIterator Clone(); // 0x00000001819BD810-0x00000001819BD880
	}
}
