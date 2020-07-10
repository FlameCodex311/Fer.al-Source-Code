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
	public class SerializedEventInfo : ISerializationCallbackReceiver // TypeDefIndex: 15290
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		public SerializedEventInfo(EventInfo info); // 0x0000000180626C40-0x0000000180626C70
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000181175580-0x0000000181175660
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001811753D0-0x0000000181175580
		public EventInfo Get(); // 0x000000018038B150-0x000000018038B160
	}
}
