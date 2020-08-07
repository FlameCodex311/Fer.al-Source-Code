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
	internal sealed class CacheChildrenQuery : ChildrenQuery // TypeDefIndex: 1931
	{
		// Fields
		private XPathNavigator nextInput; // 0x60
		private ClonableStack<XPathNavigator> elementStk; // 0x68
		private ClonableStack<int> positionStk; // 0x70
		private bool needInput; // 0x78
	
		// Constructors
		public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x00000001819BCCD0-0x00000001819BCD90
		private CacheChildrenQuery(CacheChildrenQuery other); // 0x00000001819BCD90-0x00000001819BCE50
	
		// Methods
		public override void Reset(); // 0x00000001819BCBD0-0x00000001819BCCD0
		public override XPathNavigator Advance(); // 0x00000001819BC7D0-0x00000001819BC970
		private bool DecideNextNode(); // 0x00000001819BCA50-0x00000001819BCB70
		private XPathNavigator GetNextInput(); // 0x00000001819BCB70-0x00000001819BCBD0
		public override XPathNodeIterator Clone(); // 0x00000001819BC970-0x00000001819BCA50
	}
}
