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
	internal sealed class BooleanFunctions : ValueQuery // TypeDefIndex: 1929
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType funcType; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Constructors
		public BooleanFunctions(Function.FunctionType funcType, Query arg); // 0x00000001819BC1C0-0x00000001819BC200
		private BooleanFunctions(BooleanFunctions other); // 0x00000001819BC0E0-0x00000001819BC1C0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819BC0C0-0x00000001819BC0E0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819BBCE0-0x00000001819BBF20
		internal static bool toBoolean(double number); // 0x00000001819BC3D0-0x00000001819BC450
		internal static bool toBoolean(string str); // 0x00000001819BC3B0-0x00000001819BC3D0
		internal bool toBoolean(XPathNodeIterator nodeIterator); // 0x00000001819BC200-0x00000001819BC3B0
		private bool Not(XPathNodeIterator nodeIterator); // 0x00000001819BC030-0x00000001819BC0C0
		private bool Lang(XPathNodeIterator nodeIterator); // 0x00000001819BBF20-0x00000001819BC030
		public override XPathNodeIterator Clone(); // 0x00000001819BBBD0-0x00000001819BBCE0
	}
}
