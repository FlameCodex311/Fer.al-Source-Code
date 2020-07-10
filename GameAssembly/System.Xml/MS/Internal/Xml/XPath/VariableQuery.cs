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
	internal sealed class VariableQuery : ExtensionQuery // TypeDefIndex: 1878
	{
		// Fields
		private IXsltContextVariable variable; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C950D0-0x0000000180C95130 
	
		// Constructors
		public VariableQuery(string name, string prefix); // 0x0000000180C95050-0x0000000180C95090
		private VariableQuery(VariableQuery other); // 0x0000000180C95090-0x0000000180C950D0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C94F90-0x0000000180C95050
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C94E90-0x0000000180C94F90
		public override XPathNodeIterator Clone(); // 0x0000000180C94E20-0x0000000180C94E90
	}
}
