/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight.Examples
{
	[Serializable]
	public class Character : BackingFieldCompatibleObject // TypeDefIndex: 13839
	{
		// Fields
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private string m_Name; // 0x10
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private float m_MaxHealth; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x0000000181025660-0x00000001810256B0 0x0000000181025780-0x0000000181025830
		public float MaxHealth { get; set; } // 0x00000001805D9080-0x00000001805D9090 0x00000001810256B0-0x0000000181025780
	
		// Constructors
		private Character(); // 0x0000000181025620-0x0000000181025660
		public Character(string name, float maxHealth = 1f /* Metadata: 0x007841B9 */); // 0x0000000181025480-0x0000000181025620
	
		// Methods
		public override object Clone(); // 0x0000000181025260-0x0000000181025320
		public override int GetSerializedPropertiesHash(); // 0x0000000181025320-0x00000001810253E0
		public override string ToString(); // 0x00000001810253E0-0x0000000181025480
	}
}
