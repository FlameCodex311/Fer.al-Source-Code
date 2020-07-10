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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class DynamicReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 7828
	{
		// Fields
		public static DynamicReflectionDelegateFactory Instance; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_0<T> // TypeDefIndex: 7829
		{
			// Fields
			public object constantValue;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal object <CreateGet>b__0(T o);
		}
	
		// Constructors
		public DynamicReflectionDelegateFactory(); // 0x000000018036B6C0-0x000000018036B6D0
		static DynamicReflectionDelegateFactory(); // 0x0000000180588C40-0x0000000180588CA0
	
		// Methods
		private static DynamicMethod CreateDynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner); // 0x00000001805872F0-0x00000001805873F0
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x00000001805873F0-0x00000001805876B0
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		private void GenerateCreateMethodCallIL(MethodBase method, ILGenerator generator, int argsIndex); // 0x0000000180587D80-0x0000000180588810
		public override Func<T> CreateDefaultConstructor<T>(Type type);
		private void GenerateCreateDefaultConstructorIL(Type type, ILGenerator generator); // 0x00000001805876B0-0x0000000180587940
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		private void GenerateCreateGetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator); // 0x0000000180587AF0-0x0000000180587D80
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		private void GenerateCreateGetFieldIL(FieldInfo fieldInfo, ILGenerator generator); // 0x0000000180587940-0x0000000180587AF0
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator); // 0x0000000180588810-0x00000001805889F0
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator); // 0x00000001805889F0-0x0000000180588C40
	}
}
