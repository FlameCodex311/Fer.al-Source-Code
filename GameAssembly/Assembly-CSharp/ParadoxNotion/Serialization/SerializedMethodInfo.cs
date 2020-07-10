/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization
{
	[Serializable]
	public class SerializedMethodInfo : SerializedMethodBaseInfo // TypeDefIndex: 15293
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _baseInfo; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _paramsInfo; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _genericArgumentsInfo; // 0x20
		[NonSerialized]
		private MethodInfo _method; // 0x28
		[NonSerialized]
		private bool _hasChanged; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15294
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__5_0; // 0x08
			public static Func<Type, string> <>9__5_1; // 0x10
			public static Func<string, Type> <>9__6_0; // 0x18
			public static Func<Type, bool> <>9__6_1; // 0x20
			public static Func<string, Type> <>9__6_3; // 0x28
			public static Func<ParameterInfo, Type> <>9__6_5; // 0x30
	
			// Constructors
			static <>c(); // 0x000000018117C2A0-0x000000018117C300
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <OnBeforeSerialize>b__5_0(ParameterInfo p); // 0x000000018117B540-0x000000018117B590
			internal string <OnBeforeSerialize>b__5_1(Type a); // 0x000000018117B590-0x000000018117B5C0
			internal Type <OnAfterDeserialize>b__6_0(string n); // 0x000000018117B420-0x000000018117B480
			internal bool <OnAfterDeserialize>b__6_1(Type t); // 0x000000018117B480-0x000000018117B4E0
			internal Type <OnAfterDeserialize>b__6_3(string x); // 0x000000018117B4E0-0x000000018117B540
			internal Type <OnAfterDeserialize>b__6_5(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 15295
		{
			// Fields
			public string name; // 0x10
			public Type[] parameterTypes; // 0x18
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnAfterDeserialize>b__2(MethodInfo m); // 0x000000018117BEB0-0x000000018117BEF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_1 // TypeDefIndex: 15296
		{
			// Fields
			public Type[] genericArgumentTypes; // 0x10
			public <>c__DisplayClass6_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass6_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnAfterDeserialize>b__4(MethodInfo m); // 0x000000018117BEF0-0x000000018117C120
		}
	
		// Constructors
		public SerializedMethodInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		public SerializedMethodInfo(MethodInfo method); // 0x0000000181176650-0x0000000181176680
	
		// Methods
		public override void OnBeforeSerialize(); // 0x00000001811762C0-0x0000000181176650
		public override void OnAfterDeserialize(); // 0x0000000181175990-0x00000001811762C0
		public MethodInfo Get(); // 0x0000000180369B60-0x0000000180369B70
		public override MethodBase GetBase(); // 0x0000000180369B60-0x0000000180369B70
		public override bool HasChanged(); // 0x000000018048B840-0x000000018048B850
		public override string GetMethodString(); // 0x00000001811758F0-0x0000000181175990
	}
}
