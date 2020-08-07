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
	internal sealed class IDQuery : CacheOutputQuery // TypeDefIndex: 1954
	{
		// Constructors
		public IDQuery(Query arg); // 0x00000001819BE2C0-0x00000001819BE2D0
		private IDQuery(IDQuery other); // 0x00000001819BE2B0-0x00000001819BE2C0
	
		// Methods
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819C0FF0-0x00000001819C1410
		private void ProcessIds(XPathNavigator contextNode, string val); // 0x00000001819C1410-0x00000001819C1500
		public override XPathNodeIterator Clone(); // 0x00000001819C0F90-0x00000001819C0FF0
	}
}
