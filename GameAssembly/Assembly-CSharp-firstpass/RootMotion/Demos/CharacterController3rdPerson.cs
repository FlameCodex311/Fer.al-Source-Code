/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018020BC70-0x000000018020BCC0
	public class CharacterController3rdPerson : UnityEngine.MonoBehaviour // TypeDefIndex: 9798
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CameraController cam; // 0x18
		private AnimatorController3rdPerson animatorController; // 0x20
	
		// Properties
		private static Vector3 inputVector { get; } // 0x0000000181370780-0x0000000181370800 
		private static Vector3 inputVectorRaw { get; } // 0x0000000181370700-0x0000000181370780 
	
		// Constructors
		public CharacterController3rdPerson(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x00000001813706A0-0x0000000181370700
		private void LateUpdate(); // 0x00000001813702B0-0x00000001813706A0
	}
}
