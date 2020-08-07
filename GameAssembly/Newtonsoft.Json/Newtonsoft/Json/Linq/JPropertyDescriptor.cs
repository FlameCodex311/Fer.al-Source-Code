/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 8118
	{
		// Properties
		public override Type ComponentType { get; } // 0x000000018183AA50-0x000000018183AAB0 
		public override bool IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
		public override Type PropertyType { get; } // 0x000000018183AAB0-0x000000018183AB10 
		protected override int NameHashCode { get; } // 0x00000001803FB670-0x00000001803FB680 
	
		// Constructors
		public JPropertyDescriptor(string name); // 0x000000018183AA40-0x000000018183AA50
	
		// Methods
		private static JObject CastInstance(object instance); // 0x000000018183A620-0x000000018183A6A0
		public override bool CanResetValue(object component); // 0x0000000180380950-0x0000000180380960
		public override object GetValue(object component); // 0x000000018183A6A0-0x000000018183A7C0
		public override void ResetValue(object component); // 0x00000001803774A0-0x00000001803774B0
		public override void SetValue(object component, object value); // 0x000000018183A7C0-0x000000018183AA40
		public override bool ShouldSerializeValue(object component); // 0x0000000180380950-0x0000000180380960
	}
}
