/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class DynamicValueProvider : IValueProvider // TypeDefIndex: 8065
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
		private Func<object, object> _getter; // 0x18
		private Action<object, object> _setter; // 0x20
	
		// Constructors
		public DynamicValueProvider(MemberInfo memberInfo); // 0x0000000180E8B7C0-0x0000000180E8B820
	
		// Methods
		public void SetValue(object target, object value); // 0x0000000180E8B640-0x0000000180E8B7C0
		public object GetValue(object target); // 0x0000000180E8B4B0-0x0000000180E8B640
	}
}
