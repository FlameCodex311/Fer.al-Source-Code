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
	internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery // TypeDefIndex: 1940
	{
		// Fields
		private int level; // 0x60
	
		// Constructors
		public DescendantOverDescendantQuery(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis); // 0x00000001819BDD20-0x00000001819BDDF0
		private DescendantOverDescendantQuery(DescendantOverDescendantQuery other); // 0x00000001819BDCD0-0x00000001819BDD20
	
		// Methods
		public override void Reset(); // 0x00000001819BDC90-0x00000001819BDCD0
		public override XPathNavigator Advance(); // 0x00000001819BD9D0-0x00000001819BDB50
		private bool MoveToFirstChild(); // 0x00000001819BDBD0-0x00000001819BDC10
		private bool MoveUpUntillNext(); // 0x00000001819BDC10-0x00000001819BDC90
		public override XPathNodeIterator Clone(); // 0x00000001819BDB50-0x00000001819BDBD0
	}
}
