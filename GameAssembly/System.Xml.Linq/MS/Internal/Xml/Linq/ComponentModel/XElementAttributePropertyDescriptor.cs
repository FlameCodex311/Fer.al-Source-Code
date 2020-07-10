/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

// Image 21: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 4994-5056

namespace MS.Internal.Xml.Linq.ComponentModel
{
	internal class XElementAttributePropertyDescriptor : XPropertyDescriptor<XElement, object> // TypeDefIndex: 5041
	{
		// Fields
		private XDeferredSingleton<XAttribute> value; // 0x88
		private XAttribute changeState; // 0x90
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 5042
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<XElement, XName, XAttribute> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180D6DA80-0x0000000180D6DAE0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal XAttribute <GetValue>b__3_0(XElement e, XName n); // 0x0000000180D6D8B0-0x0000000180D6D8F0
		}
	
		// Constructors
		public XElementAttributePropertyDescriptor(); // 0x0000000180D74CF0-0x0000000180D74D30
	
		// Methods
		public override object GetValue(object component); // 0x0000000180D74900-0x0000000180D74A70
		protected override void OnChanged(object sender, XObjectChangeEventArgs args); // 0x0000000180D74A70-0x0000000180D74C20
		protected override void OnChanging(object sender, XObjectChangeEventArgs args); // 0x0000000180D74C20-0x0000000180D74CF0
	}
}
