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
	public class LookAtTargetModifier : CameraStateModifierBase // TypeDefIndex: 13871
	{
		// Fields
		[SerializeField] // 0x000000018012D930-0x000000018012D970
		[Tooltip] // 0x000000018012D930-0x000000018012D970
		private Transform _lookAtTarget; // 0x50
	
		// Properties
		public override string Name { get; } // 0x00000001812010C0-0x00000001812010F0 
	
		// Constructors
		public LookAtTargetModifier(); // 0x00000001812010B0-0x00000001812010C0
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000181200DE0-0x00000001812010B0
	}
}
