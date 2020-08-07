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
	public class CameraFOVModifier : CameraStateModifierBase // TypeDefIndex: 14533
	{
		// Fields
		[NonNegative] // 0x0000000180255B50-0x0000000180255BA0
		[SerializeField] // 0x0000000180255B50-0x0000000180255BA0
		[Tooltip] // 0x0000000180255B50-0x0000000180255BA0
		public float _fieldOfView; // 0x50
		private float _cachedFoV; // 0x54
	
		// Properties
		public override string Name { get; } // 0x0000000180CA7A60-0x0000000180CA7A90 
	
		// Constructors
		public CameraFOVModifier(); // 0x0000000180CA7A30-0x0000000180CA7A60
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000180CA7770-0x0000000180CA7960
		public override bool Enable(); // 0x0000000180CA79C0-0x0000000180CA7A30
		public override void Cleanup(); // 0x0000000180CA7960-0x0000000180CA79C0
	}
}
