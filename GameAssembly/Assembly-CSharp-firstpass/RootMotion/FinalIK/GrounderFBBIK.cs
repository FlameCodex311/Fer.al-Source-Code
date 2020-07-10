/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x00000001801243B0-0x0000000180124410
	[HelpURL] // 0x00000001801243B0-0x0000000180124410
	public class GrounderFBBIK : Grounder // TypeDefIndex: 9342
	{
		// Fields
		[Tooltip] // 0x0000000180124700-0x0000000180124730
		public FullBodyBipedIK ik; // 0x40
		[Tooltip] // 0x0000000180122A00-0x0000000180122A30
		public float spineBend; // 0x48
		[Tooltip] // 0x0000000180122C10-0x0000000180122C40
		public float spineSpeed; // 0x4C
		public SpineEffector[] spine; // 0x50
		private Transform[] feet; // 0x58
		private Vector3 spineOffset; // 0x60
		private bool firstSolve; // 0x6C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 9343
		{
			// Fields
			[Tooltip] // 0x0000000180124E50-0x0000000180124E80
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip] // 0x0000000180125150-0x0000000180125180
			public float horizontalWeight; // 0x14
			[Tooltip] // 0x00000001801253A0-0x00000001801253D0
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector(); // 0x000000018127EAF0-0x000000018127EB00
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight); // 0x0000000181C36650-0x0000000181C366A0
		}
	
		// Constructors
		public GrounderFBBIK(); // 0x0000000181C19EF0-0x0000000181C19F60
	
		// Methods
		[ContextMenu] // 0x0000000180124A10-0x0000000180124A40
		private void OpenTutorial(); // 0x0000000181C19A50-0x0000000181C19A90
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000181C19A90-0x0000000181C19AD0
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x0000000181C19A10-0x0000000181C19A50
		public override void ResetPosition(); // 0x0000000181C19AD0-0x0000000181C19B50
		private bool IsReadyToInitiate(); // 0x0000000181C18FF0-0x0000000181C19090
		private void Update(); // 0x0000000181C19DC0-0x0000000181C19EF0
		private void FixedUpdate(); // 0x0000000181C18CD0-0x0000000181C18CE0
		private void LateUpdate(); // 0x0000000181C18CD0-0x0000000181C18CE0
		private void Initiate(); // 0x0000000181C18CE0-0x0000000181C18FF0
		private void OnSolverUpdate(); // 0x0000000181C192A0-0x0000000181C19A10
		private void SetLegIK(IKEffector effector, Grounding.Leg leg); // 0x0000000181C19B50-0x0000000181C19DC0
		private void OnDrawGizmosSelected(); // 0x0000000181C19190-0x0000000181C192A0
		private void OnDestroy(); // 0x0000000181C19090-0x0000000181C19190
	}
}
