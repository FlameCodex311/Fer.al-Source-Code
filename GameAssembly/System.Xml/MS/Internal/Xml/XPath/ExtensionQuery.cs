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
	internal abstract class ExtensionQuery : Query // TypeDefIndex: 1838
	{
		// Fields
		protected string prefix; // 0x18
		protected string name; // 0x20
		protected XsltContext xsltContext; // 0x28
		private ResetableIterator queryIterator; // 0x30
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180C86DD0-0x0000000180C86E70 
		public override int CurrentPosition { get; } // 0x0000000180C86DB0-0x0000000180C86DD0 
		protected string QName { get; } // 0x0000000180C86E70-0x0000000180C86ED0 
		public override int Count { get; } // 0x0000000180C86D90-0x0000000180C86DB0 
		public override XPathResultType StaticType { get; } // 0x000000018035E180-0x000000018035E190 
	
		// Constructors
		public ExtensionQuery(string prefix, string name); // 0x0000000180C86C60-0x0000000180C86CA0
		protected ExtensionQuery(ExtensionQuery other); // 0x0000000180C86CA0-0x0000000180C86D90
	
		// Methods
		public override void Reset(); // 0x0000000180C86C40-0x0000000180C86C60
		public override XPathNavigator Advance(); // 0x0000000180C86520-0x0000000180C865B0
		protected object ProcessResult(object value); // 0x0000000180C865B0-0x0000000180C86C40
	}
}
