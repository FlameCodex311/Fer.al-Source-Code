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
	public class CameraFOVModifier : CameraStateModifierBase // TypeDefIndex: 13866
	{
		// Fields
		[NonNegative] // 0x000000018012A8E0-0x000000018012A930
		[SerializeField] // 0x000000018012A8E0-0x000000018012A930
		[Tooltip] // 0x000000018012A8E0-0x000000018012A930
		public float _fieldOfView; // 0x50
		private float _cachedFoV; // 0x54
	
		// Properties
		public override string Name { get; } // 0x0000000181349340-0x0000000181349370 
	
		// Constructors
		public CameraFOVModifier(); // 0x0000000181349310-0x0000000181349340
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000181349040-0x0000000181349240
		public override bool Enable(); // 0x00000001813492A0-0x0000000181349310
		public override void Cleanup(); // 0x0000000181349240-0x00000001813492A0
	}
}
