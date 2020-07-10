/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal abstract class CacheOutputQuery : Query // TypeDefIndex: 1827
	{
		// Fields
		internal Query input; // 0x18
		protected List<XPathNavigator> outputBuffer; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180C85390-0x0000000180C85400 
		public override XPathResultType StaticType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override int CurrentPosition { get; } // 0x000000018036CFF0-0x000000018036D000 
		public override int Count { get; } // 0x0000000180C85350-0x0000000180C85390 
		public override QueryProps Properties { get; } // 0x00000001809EE170-0x00000001809EE180 
	
		// Constructors
		public CacheOutputQuery(Query input); // 0x0000000180C852D0-0x0000000180C85350
		protected CacheOutputQuery(CacheOutputQuery other); // 0x0000000180C851A0-0x0000000180C852D0
	
		// Methods
		public override void Reset(); // 0x0000000180C84750-0x0000000180C84760
		public override void SetXsltContext(XsltContext context); // 0x0000000180C85170-0x0000000180C851A0
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C850F0-0x0000000180C85170
		public override XPathNavigator Advance(); // 0x0000000180C85050-0x0000000180C850F0
	}
}
