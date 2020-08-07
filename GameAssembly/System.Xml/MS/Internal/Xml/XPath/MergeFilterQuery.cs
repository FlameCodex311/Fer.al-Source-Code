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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class MergeFilterQuery : CacheOutputQuery // TypeDefIndex: 1959
	{
		// Fields
		private Query child; // 0x28
	
		// Constructors
		public MergeFilterQuery(Query input, Query child); // 0x00000001819C56A0-0x00000001819C56D0
		private MergeFilterQuery(MergeFilterQuery other); // 0x00000001819C55C0-0x00000001819C56A0
	
		// Methods
		public override void SetXsltContext(XsltContext xsltContext); // 0x00000001819C5560-0x00000001819C55C0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C54B0-0x00000001819C5560
		public override XPathNodeIterator Clone(); // 0x00000001819C53A0-0x00000001819C54B0
	}
}
