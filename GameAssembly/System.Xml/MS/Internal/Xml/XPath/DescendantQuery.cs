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
	internal class DescendantQuery : DescendantBaseQuery // TypeDefIndex: 1939
	{
		// Fields
		private XPathNodeIterator nodeIterator; // 0x60
	
		// Constructors
		internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis); // 0x00000001819BD900-0x00000001819BD9D0
		public DescendantQuery(DescendantQuery other); // 0x00000001819BE060-0x00000001819BE0D0
	
		// Methods
		public override void Reset(); // 0x00000001819BE020-0x00000001819BE060
		public override XPathNavigator Advance(); // 0x00000001819BDDF0-0x00000001819BDF80
		public override XPathNodeIterator Clone(); // 0x00000001819BDF80-0x00000001819BE020
	}
}
