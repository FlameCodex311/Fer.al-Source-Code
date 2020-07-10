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
	internal class XAttributeValuePropertyDescriptor : XPropertyDescriptor<XAttribute, string> // TypeDefIndex: 5051
	{
		// Fields
		private XAttribute attribute; // 0x88
	
		// Properties
		public override bool IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public XAttributeValuePropertyDescriptor(); // 0x0000000180D6DF20-0x0000000180D6DF60
	
		// Methods
		public override object GetValue(object component); // 0x0000000180D6DC00-0x0000000180D6DCB0
		public override void SetValue(object component, object value); // 0x0000000180D6DD60-0x0000000180D6DF20
		protected override void OnChanged(object sender, XObjectChangeEventArgs args); // 0x0000000180D6DCB0-0x0000000180D6DD60
	}
}
