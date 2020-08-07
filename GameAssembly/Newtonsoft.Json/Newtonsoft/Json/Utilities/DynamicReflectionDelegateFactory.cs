/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class DynamicReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 7994
	{
		// Fields
		public static DynamicReflectionDelegateFactory Instance; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0<T> // TypeDefIndex: 7995
		{
			// Fields
			public object constantValue;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		// Constructors
		public DynamicReflectionDelegateFactory(); // 0x0000000180373240-0x0000000180373250
		static DynamicReflectionDelegateFactory(); // 0x0000000180C21230-0x0000000180C21290
	
		// Methods
		private static DynamicMethod CreateDynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner); // 0x0000000180C1F940-0x0000000180C1FA40
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x0000000180C1FA40-0x0000000180C1FCF0
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		private void GenerateCreateMethodCallIL(MethodBase method, ILGenerator generator, int argsIndex); // 0x0000000180C20390-0x0000000180C20E10
		public override Func<T> CreateDefaultConstructor<T>(Type type);
		private void GenerateCreateDefaultConstructorIL(Type type, ILGenerator generator); // 0x0000000180C1FCF0-0x0000000180C1FF70
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		private void GenerateCreateGetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator); // 0x0000000180C20110-0x0000000180C20390
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		private void GenerateCreateGetFieldIL(FieldInfo fieldInfo, ILGenerator generator); // 0x0000000180C1FF70-0x0000000180C20110
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator); // 0x0000000180C20E10-0x0000000180C20FF0
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator); // 0x0000000180C20FF0-0x0000000180C21230
	}
}
