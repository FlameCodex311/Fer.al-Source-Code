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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 7952
	{
		// Properties
		public override Type ComponentType { get; } // 0x00000001809544A0-0x0000000180954500 
		public override bool IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override Type PropertyType { get; } // 0x0000000180954500-0x0000000180954560 
		protected override int NameHashCode { get; } // 0x00000001803C2700-0x00000001803C2710 
	
		// Constructors
		public JPropertyDescriptor(string name); // 0x0000000180954490-0x00000001809544A0
	
		// Methods
		private static JObject CastInstance(object instance); // 0x0000000180954060-0x00000001809540E0
		public override bool CanResetValue(object component); // 0x00000001803C28F0-0x00000001803C2900
		public override object GetValue(object component); // 0x00000001809540E0-0x0000000180954200
		public override void ResetValue(object component); // 0x00000001803581E0-0x00000001803581F0
		public override void SetValue(object component, object value); // 0x0000000180954200-0x0000000180954490
		public override bool ShouldSerializeValue(object component); // 0x00000001803C28F0-0x00000001803C2900
	}
}
