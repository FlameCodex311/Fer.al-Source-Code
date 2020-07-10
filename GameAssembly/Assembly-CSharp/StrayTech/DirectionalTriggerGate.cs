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
	public class DirectionalTriggerGate : MonoBehaviour, ITriggerGate // TypeDefIndex: 13920
	{
		// Fields
		[Range] // 0x0000000180150CE0-0x0000000180150D40
		[SerializeField] // 0x0000000180150CE0-0x0000000180150D40
		[Tooltip] // 0x0000000180150CE0-0x0000000180150D40
		private float _angle; // 0x20
		[Range] // 0x0000000180151060-0x00000001801510C0
		[SerializeField] // 0x0000000180151060-0x00000001801510C0
		[Tooltip] // 0x0000000180151060-0x00000001801510C0
		private float _angleSpan; // 0x24
		private bool _enteredFromValidDirection; // 0x28
		private Vector3 _validDirection; // 0x2C
	
		// Properties
		public bool IsActive { get; } // 0x0000000180EDE160-0x0000000180EDE190 
	
		// Constructors
		public DirectionalTriggerGate(); // 0x0000000181352EA0-0x0000000181352EB0
	
		// Methods
		private void Start(); // 0x0000000181352AB0-0x0000000181352D00
		public void TriggerWasEntered(Collider other); // 0x0000000181352D00-0x0000000181352EA0
		public bool IsTriggerBlocked(); // 0x0000000181352AA0-0x0000000181352AB0
	}
}
