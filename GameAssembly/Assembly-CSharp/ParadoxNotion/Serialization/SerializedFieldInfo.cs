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
	public class SerializedFieldInfo : ISerializedReflectedInfo // TypeDefIndex: 15878
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[NonSerialized]
		private FieldInfo _field; // 0x18
	
		// Constructors
		public SerializedFieldInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedFieldInfo(FieldInfo info); // 0x000000018056B4B0-0x000000018056B4E0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811AA020-0x00000001811AA100
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811A9E70-0x00000001811AA020
		public MemberInfo AsMemberInfo(); // 0x0000000180372430-0x0000000180372440
		public string AsString(); // 0x00000001811A9E10-0x00000001811A9E70
		public override string ToString(); // 0x00000001811A9E10-0x00000001811A9E70
		public static implicit operator FieldInfo(SerializedFieldInfo value); // 0x00000001811A9E00-0x00000001811A9E10
	}
}
