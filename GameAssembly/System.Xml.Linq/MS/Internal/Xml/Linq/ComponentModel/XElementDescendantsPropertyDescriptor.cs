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
using System.Xml.Linq;

// Image 21: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 4994-5056

namespace MS.Internal.Xml.Linq.ComponentModel
{
	internal class XElementDescendantsPropertyDescriptor : XPropertyDescriptor<XElement, IEnumerable<XElement>> // TypeDefIndex: 5043
	{
		// Fields
		private XDeferredAxis<XElement> value; // 0x88
		private XName changeState; // 0x90
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 5044
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<XElement, XName, IEnumerable<XElement>> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180D6DBA0-0x0000000180D6DC00
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal IEnumerable<XElement> <GetValue>b__3_0(XElement e, XName n); // 0x0000000180D6D9D0-0x0000000180D6DA80
		}
	
		// Constructors
		public XElementDescendantsPropertyDescriptor(); // 0x0000000180D75130-0x0000000180D75170
	
		// Methods
		public override object GetValue(object component); // 0x0000000180D74D30-0x0000000180D74EA0
		protected override void OnChanged(object sender, XObjectChangeEventArgs args); // 0x0000000180D74EA0-0x0000000180D75070
		protected override void OnChanging(object sender, XObjectChangeEventArgs args); // 0x0000000180D75070-0x0000000180D75130
	}
}
