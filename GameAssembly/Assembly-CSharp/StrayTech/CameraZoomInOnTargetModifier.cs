/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech.CustomAttributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class CameraZoomInOnTargetModifier : CameraStateModifierBase // TypeDefIndex: 14537
	{
		// Fields
		[SerializeField] // 0x0000000180256B80-0x0000000180256BC0
		[Tooltip] // 0x0000000180256B80-0x0000000180256BC0
		private Transform _target; // 0x50
		[SerializeField] // 0x0000000180256D90-0x0000000180256DD0
		[Tooltip] // 0x0000000180256D90-0x0000000180256DD0
		private Vector3 _targetOffset; // 0x58
		[NonNegative] // 0x0000000180257060-0x00000001802570B0
		[SerializeField] // 0x0000000180257060-0x00000001802570B0
		[Tooltip] // 0x0000000180257060-0x00000001802570B0
		private float _distanceFromTarget; // 0x64
	
		// Properties
		public override string Name { get; } // 0x0000000180CAEE00-0x0000000180CAEE30 
	
		// Constructors
		public CameraZoomInOnTargetModifier(); // 0x0000000180CAEDD0-0x0000000180CAEE00
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000180CAEB20-0x0000000180CAEDD0
	}
}
