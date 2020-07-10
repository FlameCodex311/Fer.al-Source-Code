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
	public class SerializedConstructorInfo : SerializedMethodBaseInfo // TypeDefIndex: 15288
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _baseInfo; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _paramsInfo; // 0x18
		[NonSerialized]
		private ConstructorInfo _constructor; // 0x20
		[NonSerialized]
		private bool _hasChanged; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15289
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__4_0; // 0x08
			public static Func<string, Type> <>9__5_0; // 0x10
			public static Func<Type, bool> <>9__5_1; // 0x18
	
			// Constructors
			static <>c(); // 0x000000018117C240-0x000000018117C2A0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <OnBeforeSerialize>b__4_0(ParameterInfo p); // 0x000000018117B540-0x000000018117B590
			internal Type <OnAfterDeserialize>b__5_0(string n); // 0x000000018117B360-0x000000018117B3C0
			internal bool <OnAfterDeserialize>b__5_1(Type t); // 0x000000018117B3C0-0x000000018117B420
		}
	
		// Constructors
		public SerializedConstructorInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		public SerializedConstructorInfo(ConstructorInfo constructor); // 0x00000001811753A0-0x00000001811753D0
	
		// Methods
		public override void OnBeforeSerialize(); // 0x00000001811751B0-0x00000001811753A0
		public override void OnAfterDeserialize(); // 0x0000000181174DB0-0x00000001811751B0
		public ConstructorInfo Get(); // 0x000000018036AC70-0x000000018036AC80
		public override MethodBase GetBase(); // 0x000000018036AC70-0x000000018036AC80
		public override bool HasChanged(); // 0x00000001803A2790-0x00000001803A27A0
		public override string GetMethodString(); // 0x0000000181174D10-0x0000000181174DB0
	}
}
