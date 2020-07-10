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
using System.Xml.Xsl;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class MergeFilterQuery : CacheOutputQuery // TypeDefIndex: 1854
	{
		// Fields
		private Query child; // 0x28
	
		// Constructors
		public MergeFilterQuery(Query input, Query child); // 0x0000000180C8DAA0-0x0000000180C8DAD0
		private MergeFilterQuery(MergeFilterQuery other); // 0x0000000180C8D9C0-0x0000000180C8DAA0
	
		// Methods
		public override void SetXsltContext(XsltContext xsltContext); // 0x0000000180C8D960-0x0000000180C8D9C0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C8D8B0-0x0000000180C8D960
		public override XPathNodeIterator Clone(); // 0x0000000180C8D7A0-0x0000000180C8D8B0
	}
}
