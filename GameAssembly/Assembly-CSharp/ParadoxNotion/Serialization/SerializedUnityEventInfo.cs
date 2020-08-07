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
	public class SerializedUnityEventInfo : ISerializedReflectedInfo // TypeDefIndex: 15883
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _baseInfo; // 0x10
		[NonSerialized]
		private MemberInfo _memberInfo; // 0x18
	
		// Properties
		public bool isStatic { get; } // 0x00000001811AB5E0-0x00000001811AB7B0 
		public Type memberType { get; } // 0x00000001811AB7B0-0x00000001811AB990 
	
		// Constructors
		public SerializedUnityEventInfo(); // 0x0000000180373240-0x0000000180373250
		public SerializedUnityEventInfo(FieldInfo info); // 0x000000018056B4B0-0x000000018056B4E0
		public SerializedUnityEventInfo(PropertyInfo info); // 0x000000018056B4B0-0x000000018056B4E0
		public SerializedUnityEventInfo(MemberInfo info); // 0x00000001811AB4E0-0x00000001811AB5E0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001811AB400-0x00000001811AB4E0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811AAFD0-0x00000001811AB400
		public MemberInfo AsMemberInfo(); // 0x0000000180372430-0x0000000180372440
		public string AsString(); // 0x00000001811AAF70-0x00000001811AAFD0
		public override string ToString(); // 0x00000001811AAF70-0x00000001811AAFD0
		public static implicit operator FieldInfo(SerializedUnityEventInfo value); // 0x00000001811ABA10-0x00000001811ABA90
		public static implicit operator PropertyInfo(SerializedUnityEventInfo value); // 0x00000001811AB990-0x00000001811ABA10
	}
}
