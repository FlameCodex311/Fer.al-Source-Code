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
	public class SerializedTypeInfo : ISerializedReflectedInfo // TypeDefIndex: 15882
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[NonSerialized]
		private Type _type; // 0x18
	
		// Constructors
		public SerializedTypeInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedTypeInfo(Type info); // 0x00000001811AAF40-0x00000001811AAF70
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811AAEB0-0x00000001811AAF40
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811AAE40-0x00000001811AAEB0
		public MemberInfo AsMemberInfo(); // 0x0000000180372430-0x0000000180372440
		public string AsString(); // 0x0000000180372440-0x0000000180372450
		public override string ToString(); // 0x0000000180372440-0x0000000180372450
		public static implicit operator Type(SerializedTypeInfo value); // 0x00000001811A9E00-0x00000001811A9E10
	}
}
