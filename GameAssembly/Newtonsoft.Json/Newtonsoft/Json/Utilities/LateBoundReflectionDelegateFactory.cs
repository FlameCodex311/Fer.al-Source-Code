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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 8001
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get; } // 0x0000000180C2BC50-0x0000000180C2BCB0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 8002
		{
			// Fields
			public ConstructorInfo c; // 0x10
			public MethodBase method; // 0x18
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <CreateParameterizedConstructor>b__0(object[] a); // 0x0000000180C351D0-0x0000000180C351F0
			internal object <CreateParameterizedConstructor>b__1(object[] a); // 0x0000000180C351F0-0x0000000180C35220
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0<T> // TypeDefIndex: 8003
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
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0<T> // TypeDefIndex: 8004
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
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0<T> // TypeDefIndex: 8005
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public <>c__DisplayClass6_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass7_0<T> // TypeDefIndex: 8006
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public <>c__DisplayClass7_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0<T> // TypeDefIndex: 8007
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public <>c__DisplayClass8_0();
	
			// Methods
			internal void <CreateSet>b__0(T o, object v);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0<T> // TypeDefIndex: 8008
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal void <CreateSet>b__0(T o, object v);
		}
	
		// Constructors
		public LateBoundReflectionDelegateFactory(); // 0x0000000180373240-0x0000000180373250
		static LateBoundReflectionDelegateFactory(); // 0x0000000180C2BBF0-0x0000000180C2BC50
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x0000000180C2BAF0-0x0000000180C2BBF0
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public override Func<T> CreateDefaultConstructor<T>(Type type);
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
