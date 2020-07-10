/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class FacePlayer : ManagedBehaviour // TypeDefIndex: 16069
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _targetFacingRotationSpeed; // 0x50
		private Transform _playerTransform; // 0x58
	
		// Properties
		private Transform playerTransform { get; } // 0x00000001813A27C0-0x00000001813A28A0 
		private Vector3 _relativePosition { get; } // 0x00000001813A2620-0x00000001813A27C0 
	
		// Constructors
		public FacePlayer(); // 0x00000001813A25C0-0x00000001813A2620
	
		// Methods
		public override void MUpdate(); // 0x00000001813A2240-0x00000001813A25C0
	}
}
