/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization
{
	[Serializable]
	public class SerializedMethodInfo : ISerializedMethodBaseInfo // TypeDefIndex: 15879
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _paramsInfo; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _genericArgumentsInfo; // 0x20
		[NonSerialized]
		private MethodInfo _method; // 0x28
		[NonSerialized]
		private bool _hasChanged; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15880
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__5_0; // 0x08
			public static Func<Type, string> <>9__5_1; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001811AC090-0x00000001811AC0F0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize>b__5_0(ParameterInfo p); // 0x00000001811ABBB0-0x00000001811ABC00
			internal string <UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize>b__5_1(Type a); // 0x00000001811ABC00-0x00000001811ABC30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 15881
		{
			// Fields
			public string name; // 0x10
			public Type[] parameterTypes; // 0x18
			public bool isSerializedGeneric; // 0x20
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__0(MethodInfo m); // 0x00000001811ABE20-0x00000001811ABED0
			internal bool <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__1(MethodInfo m); // 0x00000001811ABED0-0x00000001811ABF10
		}
	
		// Constructors
		public SerializedMethodInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedMethodInfo(MethodInfo method); // 0x00000001811AAE00-0x00000001811AAE30
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811AAA70-0x00000001811AAE00
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811AA1A0-0x00000001811AAA70
		public MemberInfo AsMemberInfo(); // 0x00000001803745B0-0x00000001803745C0
		public MethodBase GetMethodBase(); // 0x00000001803745B0-0x00000001803745C0
		public bool HasChanged(); // 0x0000000180455B90-0x0000000180455BA0
		public string AsString(); // 0x00000001811AA100-0x00000001811AA1A0
		public override string ToString(); // 0x00000001811AA100-0x00000001811AA1A0
		public static implicit operator MethodInfo(SerializedMethodInfo value); // 0x00000001811AAE30-0x00000001811AAE40
	}
}
