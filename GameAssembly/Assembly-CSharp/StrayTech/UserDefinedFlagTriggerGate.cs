/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class UserDefinedFlagTriggerGate : MonoBehaviour, ITriggerGate // TypeDefIndex: 13922
	{
		// Fields
		[SerializeField] // 0x00000001801513C0-0x0000000180151400
		[Tooltip] // 0x00000001801513C0-0x0000000180151400
		private string _userDefinedFlagName; // 0x20
	
		// Properties
		public bool IsActive { get; } // 0x0000000180EDE160-0x0000000180EDE190 
	
		// Constructors
		public UserDefinedFlagTriggerGate(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void Start(); // 0x0000000181213B20-0x0000000181213C40
		public void TriggerWasEntered(Collider other); // 0x00000001803581E0-0x00000001803581F0
		public bool IsTriggerBlocked(); // 0x0000000181213AC0-0x0000000181213B20
	}
}
