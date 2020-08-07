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
	[RequireComponent] // 0x000000018024A6D0-0x000000018024A720
	public class CharacterControl : MonoBehaviour // TypeDefIndex: 14514
	{
		// Fields
		public CameraStateDefinition cameraStateOrbit; // 0x20
		private Character _character; // 0x28
		private Vector3 _camForward; // 0x30
		private Vector3 _move; // 0x3C
		private bool _jump; // 0x48
	
		// Constructors
		public CharacterControl(); // 0x0000000180CAF740-0x0000000180CAF7D0
	
		// Methods
		private void Start(); // 0x0000000180CAF6B0-0x0000000180CAF6F0
		private void Update(); // 0x0000000180CAF6F0-0x0000000180CAF740
		private void LateUpdate(); // 0x00000001803774A0-0x00000001803774B0
		private void FixedUpdate(); // 0x0000000180CAEE30-0x0000000180CAF6B0
	}
}
