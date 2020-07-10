/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class DynamicValueProvider : IValueProvider // TypeDefIndex: 7899
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
		private Func<object, object> _getter; // 0x18
		private Action<object, object> _setter; // 0x20
	
		// Constructors
		public DynamicValueProvider(MemberInfo memberInfo); // 0x00000001804E1010-0x00000001804E1070
	
		// Methods
		public void SetValue(object target, object value); // 0x00000001804E0E80-0x00000001804E1010
		public object GetValue(object target); // 0x00000001804E0CF0-0x00000001804E0E80
	}
}
