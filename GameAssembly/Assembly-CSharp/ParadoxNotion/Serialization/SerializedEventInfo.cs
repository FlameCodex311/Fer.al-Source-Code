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
	public class SerializedEventInfo : ISerializedReflectedInfo // TypeDefIndex: 15877
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedEventInfo(EventInfo info); // 0x000000018056B4B0-0x000000018056B4E0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811A9D20-0x00000001811A9E00
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811A9B80-0x00000001811A9D20
		public MemberInfo AsMemberInfo(); // 0x0000000180372430-0x0000000180372440
		public string AsString(); // 0x00000001811A9B30-0x00000001811A9B80
		public override string ToString(); // 0x00000001811A9B30-0x00000001811A9B80
		public static implicit operator EventInfo(SerializedEventInfo value); // 0x00000001811A9E00-0x00000001811A9E10
	}
}
