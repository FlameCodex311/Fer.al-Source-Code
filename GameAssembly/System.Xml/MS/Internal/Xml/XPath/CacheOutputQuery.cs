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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal abstract class CacheOutputQuery : Query // TypeDefIndex: 1932
	{
		// Fields
		internal Query input; // 0x18
		protected List<XPathNavigator> outputBuffer; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001819BD180-0x00000001819BD1F0 
		public override XPathResultType StaticType { get; } // 0x000000018043E010-0x000000018043E020 
		public override int CurrentPosition { get; } // 0x0000000180387590-0x0000000180387930 
		public override int Count { get; } // 0x00000001819BD140-0x00000001819BD180 
		public override QueryProps Properties { get; } // 0x0000000181451370-0x0000000181451380 
	
		// Constructors
		public CacheOutputQuery(Query input); // 0x00000001819BD0C0-0x00000001819BD140
		protected CacheOutputQuery(CacheOutputQuery other); // 0x00000001819BCF90-0x00000001819BD0C0
	
		// Methods
		public override void Reset(); // 0x00000001819BC570-0x00000001819BC580
		public override void SetXsltContext(XsltContext context); // 0x00000001819BCF60-0x00000001819BCF90
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819BCEE0-0x00000001819BCF60
		public override XPathNavigator Advance(); // 0x00000001819BCE50-0x00000001819BCEE0
	}
}
