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
	public class CameraStateTransitionTrigger : CameraSystemTriggerBase // TypeDefIndex: 13919
	{
		// Fields
		[SerializeField] // 0x00000001801509C0-0x0000000180150A00
		[Tooltip] // 0x00000001801509C0-0x0000000180150A00
		private CameraStateDefinition _targetCameraStateDefinition; // 0x70
	
		// Properties
		public CameraStateDefinition TargetCameraStateDefinition { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
	
		// Constructors
		public CameraStateTransitionTrigger(); // 0x000000018134AF00-0x000000018134AF70
	
		// Methods
		protected override void TriggerEntered(); // 0x000000018134AF70-0x000000018134AFD0
		protected override void TriggerExited(); // 0x000000018134AFD0-0x000000018134B090
	}
}
