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
	internal sealed class GroupQuery : BaseAxisQuery // TypeDefIndex: 1848
	{
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C89210-0x0000000180C89240 
		public override QueryProps Properties { get; } // 0x000000018042E670-0x000000018042E680 
	
		// Constructors
		public GroupQuery(Query qy); // 0x0000000180C89200-0x0000000180C89210
		private GroupQuery(GroupQuery other); // 0x00000001809A75A0-0x00000001809A75B0
	
		// Methods
		public override XPathNavigator Advance(); // 0x0000000180C89130-0x0000000180C89170
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C891D0-0x0000000180C89200
		public override XPathNodeIterator Clone(); // 0x0000000180C89170-0x0000000180C891D0
	}
}
