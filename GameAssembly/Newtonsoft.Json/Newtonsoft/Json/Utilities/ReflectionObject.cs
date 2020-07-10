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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class ReflectionObject // TypeDefIndex: 7845
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ObjectConstructor<object> <Creator>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18
	
		// Properties
		public ObjectConstructor<object> Creator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public IDictionary<string, ReflectionMember> Members { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 7846
		{
			// Fields
			public Func<object> ctor; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <Create>b__0(object[] args); // 0x000000018059CA10-0x000000018059CA60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass13_1 // TypeDefIndex: 7847
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <Create>b__1(object target); // 0x000000018059CA60-0x000000018059CAD0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass13_2 // TypeDefIndex: 7848
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_2(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Create>b__2(object target, object arg); // 0x000000018059CAD0-0x000000018059CBB0
		}
	
		// Constructors
		public ReflectionObject(); // 0x0000000180595B70-0x0000000180595BD0
	
		// Methods
		public object GetValue(object target, string member); // 0x0000000180595AE0-0x0000000180595B70
		public Type GetType(string member); // 0x0000000180595A70-0x0000000180595AE0
		public static ReflectionObject Create(Type t, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] memberNames); // 0x0000000180595A60-0x0000000180595A70
		public static ReflectionObject Create(Type t, MethodBase creator, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] memberNames); // 0x0000000180595200-0x0000000180595A60
	}
}
