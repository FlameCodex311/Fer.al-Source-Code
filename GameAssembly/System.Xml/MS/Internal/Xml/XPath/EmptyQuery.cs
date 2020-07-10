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
	internal sealed class EmptyQuery : Query // TypeDefIndex: 1837
	{
		// Properties
		public override int CurrentPosition { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int Count { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override QueryProps Properties { get; } // 0x00000001809EE170-0x00000001809EE180 
		public override XPathResultType StaticType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override XPathNavigator Current { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public EmptyQuery(); // 0x0000000180C86500-0x0000000180C86520
	
		// Methods
		public override XPathNavigator Advance(); // 0x000000018035FCC0-0x000000018035FCD0
		public override XPathNodeIterator Clone(); // 0x0000000180362190-0x00000001803621A0
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180362190-0x00000001803621A0
		public override void Reset(); // 0x00000001803581E0-0x00000001803581F0
	}
}
