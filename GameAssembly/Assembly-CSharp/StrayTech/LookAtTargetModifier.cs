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
	public class LookAtTargetModifier : CameraStateModifierBase // TypeDefIndex: 14538
	{
		// Fields
		[SerializeField] // 0x0000000180257240-0x0000000180257280
		[Tooltip] // 0x0000000180257240-0x0000000180257280
		private Transform _lookAtTarget; // 0x50
	
		// Properties
		public override string Name { get; } // 0x0000000180CB5DC0-0x0000000180CB5DF0 
	
		// Constructors
		public LookAtTargetModifier(); // 0x0000000180CA9640-0x0000000180CA9660
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000180CB5B00-0x0000000180CB5DC0
	}
}
