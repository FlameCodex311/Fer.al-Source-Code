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
	public class SerializedConstructorInfo : ISerializedMethodBaseInfo // TypeDefIndex: 15874
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _paramsInfo; // 0x18
		[NonSerialized]
		private ConstructorInfo _constructor; // 0x20
		[NonSerialized]
		private bool _hasChanged; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15875
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, string> <>9__4_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001811ABFD0-0x00000001811AC030
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize>b__4_0(ParameterInfo p); // 0x00000001811ABBB0-0x00000001811ABC00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 15876
		{
			// Fields
			public Type[] parameterTypes; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__0(ConstructorInfo c); // 0x00000001811ABDC0-0x00000001811ABE20
		}
	
		// Constructors
		public SerializedConstructorInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedConstructorInfo(ConstructorInfo constructor); // 0x00000001811A9AF0-0x00000001811A9B20
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811A9900-0x00000001811A9AF0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811A9470-0x00000001811A9900
		public MemberInfo AsMemberInfo(); // 0x0000000180374AF0-0x0000000180374B00
		public MethodBase GetMethodBase(); // 0x0000000180374AF0-0x0000000180374B00
		public bool HasChanged(); // 0x00000001804C6790-0x00000001804C67A0
		public string AsString(); // 0x00000001811A93D0-0x00000001811A9470
		public override string ToString(); // 0x00000001811A93D0-0x00000001811A9470
		public static implicit operator ConstructorInfo(SerializedConstructorInfo value); // 0x00000001811A9B20-0x00000001811A9B30
	}
}
