/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal class ReflectionObject // TypeDefIndex: 8011
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ObjectConstructor<object> <Creator>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18
	
		// Properties
		public ObjectConstructor<object> Creator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public IDictionary<string, ReflectionMember> Members { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 8012
		{
			// Fields
			public Func<object> ctor; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <Create>b__0(object[] args); // 0x0000000180C34C30-0x0000000180C34C80
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_1 // TypeDefIndex: 8013
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <Create>b__1(object target); // 0x0000000180C34C80-0x0000000180C34CF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_2 // TypeDefIndex: 8014
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_2(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Create>b__2(object target, object arg); // 0x0000000180C34CF0-0x0000000180C34DD0
		}
	
		// Constructors
		public ReflectionObject(); // 0x0000000180C2DC80-0x0000000180C2DCE0
	
		// Methods
		public object GetValue(object target, string member); // 0x0000000180C2DBF0-0x0000000180C2DC80
		public Type GetType(string member); // 0x0000000180C2DB80-0x0000000180C2DBF0
		public static ReflectionObject Create(Type t, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] memberNames); // 0x0000000180C2DB70-0x0000000180C2DB80
		public static ReflectionObject Create(Type t, MethodBase creator, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] memberNames); // 0x0000000180C2D340-0x0000000180C2DB70
	}
}
