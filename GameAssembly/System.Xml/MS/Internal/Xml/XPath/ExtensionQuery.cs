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
	internal abstract class ExtensionQuery : Query // TypeDefIndex: 1943
	{
		// Fields
		protected string prefix; // 0x18
		protected string name; // 0x20
		protected XsltContext xsltContext; // 0x28
		private ResetableIterator queryIterator; // 0x30
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001819BEB90-0x00000001819BEC30 
		public override int CurrentPosition { get; } // 0x00000001819BEB70-0x00000001819BEB90 
		protected string QName { get; } // 0x00000001819BEC30-0x00000001819BEC90 
		public override int Count { get; } // 0x00000001819BEB50-0x00000001819BEB70 
		public override XPathResultType StaticType { get; } // 0x000000018040D640-0x000000018040D650 
	
		// Constructors
		public ExtensionQuery(string prefix, string name); // 0x00000001819BEA30-0x00000001819BEA70
		protected ExtensionQuery(ExtensionQuery other); // 0x00000001819BEA70-0x00000001819BEB50
	
		// Methods
		public override void Reset(); // 0x00000001819BEA10-0x00000001819BEA30
		public override XPathNavigator Advance(); // 0x00000001819BE2F0-0x00000001819BE380
		protected object ProcessResult(object value); // 0x00000001819BE380-0x00000001819BEA10
	}
}
