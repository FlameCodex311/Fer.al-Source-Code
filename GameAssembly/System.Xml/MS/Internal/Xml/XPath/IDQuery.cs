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
	internal sealed class IDQuery : CacheOutputQuery // TypeDefIndex: 1849
	{
		// Constructors
		public IDQuery(Query arg); // 0x0000000180C864F0-0x0000000180C86500
		private IDQuery(IDQuery other); // 0x0000000180C864E0-0x0000000180C864F0
	
		// Methods
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C892A0-0x0000000180C896D0
		private void ProcessIds(XPathNavigator contextNode, string val); // 0x0000000180C896D0-0x0000000180C897C0
		public override XPathNodeIterator Clone(); // 0x0000000180C89240-0x0000000180C892A0
	}
}
