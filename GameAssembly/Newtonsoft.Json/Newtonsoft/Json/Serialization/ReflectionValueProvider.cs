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
	public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 7947
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
	
		// Constructors
		public ReflectionValueProvider(MemberInfo memberInfo); // 0x000000018059A210-0x000000018059A3A0
	
		// Methods
		public void SetValue(object target, object value); // 0x000000018059A0D0-0x000000018059A210
		public object GetValue(object target); // 0x0000000180599F90-0x000000018059A0D0
	}
}
