/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class CameraThirdPersonModifier : CameraStateModifierBase // TypeDefIndex: 14536
	{
		// Fields
		public FeralCameraStateSettings stateSettings; // 0x50
		private FeralCameraStateSettings _feralCameraState; // 0x58
	
		// Properties
		public override string Name { get; } // 0x0000000180CAEAF0-0x0000000180CAEB20 
	
		// Constructors
		public CameraThirdPersonModifier(); // 0x0000000180CAE8A0-0x0000000180CAEAF0
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000180CAE380-0x0000000180CAE520
		public override bool Enable(); // 0x0000000180CAE550-0x0000000180CAE8A0
		public override void Cleanup(); // 0x0000000180CAE520-0x0000000180CAE550
	}
}
