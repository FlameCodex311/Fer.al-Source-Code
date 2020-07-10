/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal abstract class ReflectionDelegateFactory // TypeDefIndex: 7834
	{
		// Constructors
		protected ReflectionDelegateFactory(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo);
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo);
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
