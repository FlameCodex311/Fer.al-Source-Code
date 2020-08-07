/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class UserDefinedFlagTriggerGate : MonoBehaviour, ITriggerGate // TypeDefIndex: 14590
	{
		// Fields
		[SerializeField] // 0x000000018027DB80-0x000000018027DBC0
		[Tooltip] // 0x000000018027DB80-0x000000018027DBC0
		private string _userDefinedFlagName; // 0x20
	
		// Properties
		public bool IsActive { get; } // 0x00000001803F1920-0x00000001803F1950 
	
		// Constructors
		public UserDefinedFlagTriggerGate(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void Start(); // 0x0000000180CBE4C0-0x0000000180CBE5E0
		public void TriggerWasEntered(Collider other); // 0x00000001803774A0-0x00000001803774B0
		public bool IsTriggerBlocked(); // 0x0000000180CBE410-0x0000000180CBE4C0
	}
}
