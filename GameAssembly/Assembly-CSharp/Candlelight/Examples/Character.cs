/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight.Examples
{
	[Serializable]
	public class Character : BackingFieldCompatibleObject // TypeDefIndex: 14506
	{
		// Fields
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private string m_Name; // 0x10
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private float m_MaxHealth; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x000000018049DFD0-0x000000018049E020 0x000000018049E0F0-0x000000018049E1A0
		public float MaxHealth { get; set; } // 0x000000018049DFC0-0x000000018049DFD0 0x000000018049E020-0x000000018049E0F0
	
		// Constructors
		private Character(); // 0x000000018049DF80-0x000000018049DFC0
		public Character(string name, float maxHealth = 1f /* Metadata: 0x007BAC7C */); // 0x000000018049DDE0-0x000000018049DF80
	
		// Methods
		public override object Clone(); // 0x000000018049DBC0-0x000000018049DC80
		public override int GetSerializedPropertiesHash(); // 0x000000018049DC80-0x000000018049DD40
		public override string ToString(); // 0x000000018049DD40-0x000000018049DDE0
	}
}
