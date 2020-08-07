/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver // TypeDefIndex: 15807
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _ID; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _name; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _type; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <type>k__BackingField; // 0x28
	
		// Properties
		public string ID { get; private set; } // 0x00000001806C5640-0x00000001806C5670 0x0000000180379F20-0x0000000180379F30
		public string name { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public Type type { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public DynamicParameterDefinition(); // 0x0000000180373240-0x0000000180373250
		public DynamicParameterDefinition(string name, Type type); // 0x00000001806C55A0-0x00000001806C5640
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001806C5510-0x00000001806C55A0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001806C54A0-0x00000001806C5510
	}
}
