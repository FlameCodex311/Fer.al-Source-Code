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
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 7835
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get; } // 0x0000000180593AB0-0x0000000180593B10 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 7836
		{
			// Fields
			public ConstructorInfo c; // 0x10
			public MethodBase method; // 0x18
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <CreateParameterizedConstructor>b__0(object[] a); // 0x000000018059CFC0-0x000000018059CFE0
			internal object <CreateParameterizedConstructor>b__1(object[] a); // 0x000000018059CFE0-0x000000018059D010
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0<T> // TypeDefIndex: 7837
		{
			// Fields
			public ConstructorInfo c;
			public MethodBase method;
	
			// Constructors
			public <>c__DisplayClass4_0();
	
			// Methods
			internal object <CreateMethodCall>b__0(T o, object[] a);
			internal object <CreateMethodCall>b__1(T o, object[] a);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0<T> // TypeDefIndex: 7838
		{
			// Fields
			public Type type;
			public ConstructorInfo constructorInfo;
	
			// Constructors
			public <>c__DisplayClass5_0();
	
			// Methods
			internal T <CreateDefaultConstructor>b__0();
			internal T <CreateDefaultConstructor>b__1();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0<T> // TypeDefIndex: 7839
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public <>c__DisplayClass6_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass7_0<T> // TypeDefIndex: 7840
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public <>c__DisplayClass7_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass8_0<T> // TypeDefIndex: 7841
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public <>c__DisplayClass8_0();
	
			// Methods
			internal void <CreateSet>b__0(T o, object v);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_0<T> // TypeDefIndex: 7842
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal void <CreateSet>b__0(T o, object v);
		}
	
		// Constructors
		public LateBoundReflectionDelegateFactory(); // 0x000000018036B6C0-0x000000018036B6D0
		static LateBoundReflectionDelegateFactory(); // 0x0000000180593A50-0x0000000180593AB0
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x0000000180593940-0x0000000180593A50
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public override Func<T> CreateDefaultConstructor<T>(Type type);
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
