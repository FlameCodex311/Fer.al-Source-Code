/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech.CustomAttributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class CameraZoomInOnTargetModifier : CameraStateModifierBase // TypeDefIndex: 13870
	{
		// Fields
		[SerializeField] // 0x000000018012D1F0-0x000000018012D230
		[Tooltip] // 0x000000018012D1F0-0x000000018012D230
		private Transform _target; // 0x50
		[SerializeField] // 0x000000018012D360-0x000000018012D3A0
		[Tooltip] // 0x000000018012D360-0x000000018012D3A0
		private Vector3 _targetOffset; // 0x58
		[NonNegative] // 0x000000018012D610-0x000000018012D660
		[SerializeField] // 0x000000018012D610-0x000000018012D660
		[Tooltip] // 0x000000018012D610-0x000000018012D660
		private float _distanceFromTarget; // 0x64
	
		// Properties
		public override string Name { get; } // 0x00000001813503E0-0x0000000181350410 
	
		// Constructors
		public CameraZoomInOnTargetModifier(); // 0x00000001813503B0-0x00000001813503E0
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000181350100-0x00000001813503B0
	}
}
