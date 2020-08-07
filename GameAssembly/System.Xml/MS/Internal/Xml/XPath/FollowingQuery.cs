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
	internal sealed class FollowingQuery : BaseAxisQuery // TypeDefIndex: 1946
	{
		// Fields
		private XPathNavigator input; // 0x58
		private XPathNodeIterator iterator; // 0x60
	
		// Constructors
		public FollowingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x00000001819BB140-0x00000001819BB200
		private FollowingQuery(FollowingQuery other); // 0x00000001819BFE60-0x00000001819BFEE0
	
		// Methods
		public override void Reset(); // 0x00000001819BE020-0x00000001819BE060
		public override XPathNavigator Advance(); // 0x00000001819BFAF0-0x00000001819BFDB0
		public override XPathNodeIterator Clone(); // 0x00000001819BFDB0-0x00000001819BFE60
	}
}
