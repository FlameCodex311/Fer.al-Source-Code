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
	[RequireComponent] // 0x000000018011DA80-0x000000018011DAD0
	public class CharacterControl : MonoBehaviour // TypeDefIndex: 13847
	{
		// Fields
		public CameraStateDefinition cameraStateOrbit; // 0x20
		private Character _character; // 0x28
		private Vector3 _camForward; // 0x30
		private Vector3 _move; // 0x3C
		private bool _jump; // 0x48
	
		// Constructors
		public CharacterControl(); // 0x0000000181350D40-0x0000000181350DD0
	
		// Methods
		private void Start(); // 0x0000000181350CB0-0x0000000181350CF0
		private void Update(); // 0x0000000181350CF0-0x0000000181350D40
		private void LateUpdate(); // 0x00000001803581E0-0x00000001803581F0
		private void FixedUpdate(); // 0x0000000181350410-0x0000000181350CB0
	}
}
