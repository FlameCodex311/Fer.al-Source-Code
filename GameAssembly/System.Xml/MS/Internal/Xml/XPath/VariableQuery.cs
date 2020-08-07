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
	internal sealed class VariableQuery : ExtensionQuery // TypeDefIndex: 1983
	{
		// Fields
		private IXsltContextVariable variable; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819CCDA0-0x00000001819CCE00 
	
		// Constructors
		public VariableQuery(string name, string prefix); // 0x00000001819CCD20-0x00000001819CCD60
		private VariableQuery(VariableQuery other); // 0x00000001819CCD60-0x00000001819CCDA0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819CCC60-0x00000001819CCD20
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819CCB60-0x00000001819CCC60
		public override XPathNodeIterator Clone(); // 0x00000001819CCAF0-0x00000001819CCB60
	}
}
