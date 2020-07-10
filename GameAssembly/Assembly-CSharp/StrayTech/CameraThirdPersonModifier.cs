/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class CameraThirdPersonModifier : CameraStateModifierBase // TypeDefIndex: 13869
	{
		// Fields
		public FeralCameraStateSettings stateSettings; // 0x50
	
		// Properties
		public override string Name { get; } // 0x00000001813500D0-0x0000000181350100 
	
		// Constructors
		public CameraThirdPersonModifier(); // 0x000000018134FE80-0x00000001813500D0
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x000000018134F7E0-0x000000018134FA20
		public override bool Enable(); // 0x000000018134FB00-0x000000018134FE80
		public override void Cleanup(); // 0x000000018134FA20-0x000000018134FB00
	}
}
