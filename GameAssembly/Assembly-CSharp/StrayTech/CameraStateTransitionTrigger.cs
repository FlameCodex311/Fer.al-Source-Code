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
	public class CameraStateTransitionTrigger : CameraSystemTriggerBase // TypeDefIndex: 14587
	{
		// Fields
		[SerializeField] // 0x000000018027D240-0x000000018027D280
		[Tooltip] // 0x000000018027D240-0x000000018027D280
		private CameraStateDefinition _targetCameraStateDefinition; // 0x70
	
		// Properties
		public CameraStateDefinition TargetCameraStateDefinition { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
	
		// Constructors
		public CameraStateTransitionTrigger(); // 0x0000000180CA9B20-0x0000000180CA9B90
	
		// Methods
		protected override void TriggerEntered(); // 0x0000000180CA9C60-0x0000000180CA9CB0
		protected override void TriggerExited(); // 0x0000000180CA9CB0-0x0000000180CA9D70
	}
}
