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
	internal class ChildrenQuery : BaseAxisQuery // TypeDefIndex: 1933
	{
		// Fields
		private XPathNodeIterator iterator; // 0x58
	
		// Constructors
		public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x00000001819BD520-0x00000001819BD630
		protected ChildrenQuery(ChildrenQuery other); // 0x00000001819BD460-0x00000001819BD520
	
		// Methods
		public override void Reset(); // 0x00000001819BD3D0-0x00000001819BD460
		public override XPathNavigator Advance(); // 0x00000001819BD1F0-0x00000001819BD370
		public override XPathNodeIterator Clone(); // 0x00000001819BD370-0x00000001819BD3D0
	}
}
