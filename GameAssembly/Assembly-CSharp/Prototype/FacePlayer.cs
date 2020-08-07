/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class FacePlayer : ManagedBehaviour // TypeDefIndex: 14808
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _targetFacingRotationSpeed; // 0x50
		private Transform _playerTransform; // 0x58
	
		// Properties
		private Transform playerTransform { get; } // 0x0000000180AD8BA0-0x0000000180AD8C80 
		private Vector3 _relativePosition { get; } // 0x0000000180AD8A00-0x0000000180AD8BA0 
	
		// Constructors
		public FacePlayer(); // 0x0000000180AD89A0-0x0000000180AD8A00
	
		// Methods
		public override void MUpdate(); // 0x0000000180AD8630-0x0000000180AD89A0
	}
}
