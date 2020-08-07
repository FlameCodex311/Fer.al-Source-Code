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
	internal sealed class GroupQuery : BaseAxisQuery // TypeDefIndex: 1953
	{
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819C0F60-0x00000001819C0F90 
		public override QueryProps Properties { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		public GroupQuery(Query qy); // 0x00000001819C0F50-0x00000001819C0F60
		private GroupQuery(GroupQuery other); // 0x00000001813BC150-0x00000001813BC160
	
		// Methods
		public override XPathNavigator Advance(); // 0x00000001819C0E80-0x00000001819C0EC0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C0F20-0x00000001819C0F50
		public override XPathNodeIterator Clone(); // 0x00000001819C0EC0-0x00000001819C0F20
	}
}
