/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001800D5700-0x00000001800D5750
	public class CharacterController3rdPerson : UnityEngine.MonoBehaviour // TypeDefIndex: 9511
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CameraController cam; // 0x18
		private AnimatorController3rdPerson animatorController; // 0x20
	
		// Properties
		private static Vector3 inputVector { get; } // 0x0000000181649CF0-0x0000000181649D70 
		private static Vector3 inputVectorRaw { get; } // 0x0000000181649C70-0x0000000181649CF0 
	
		// Constructors
		public CharacterController3rdPerson(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x0000000181649C10-0x0000000181649C70
		private void LateUpdate(); // 0x0000000181649810-0x0000000181649C10
	}
}
