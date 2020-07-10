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
	[AddComponentMenu] // 0x00000001801378A0-0x00000001801378D0
	public class VRIK : IK // TypeDefIndex: 9364
	{
		// Fields
		[ContextMenuItem] // 0x00000001801379A0-0x0000000180137A20
		[Tooltip] // 0x00000001801379A0-0x0000000180137A20
		public References references; // 0x38
		[Tooltip] // 0x0000000180137B80-0x0000000180137BB0
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 9365
		{
			// Fields
			public Transform root; // 0x10
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform chest; // 0x28
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform neck; // 0x30
			public Transform head; // 0x38
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform leftShoulder; // 0x40
			public Transform leftUpperArm; // 0x48
			public Transform leftForearm; // 0x50
			public Transform leftHand; // 0x58
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform rightShoulder; // 0x60
			public Transform rightUpperArm; // 0x68
			public Transform rightForearm; // 0x70
			public Transform rightHand; // 0x78
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform leftThigh; // 0x80
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform leftCalf; // 0x88
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform leftFoot; // 0x90
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform leftToes; // 0x98
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform rightThigh; // 0xA0
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform rightCalf; // 0xA8
			[Tooltip] // 0x00000001801385B0-0x00000001801385E0
			public Transform rightFoot; // 0xB0
			[Tooltip] // 0x0000000180138060-0x0000000180138090
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get; } // 0x0000000182285880-0x0000000182285DA0 
			public bool isEmpty { get; } // 0x0000000182285370-0x0000000182285880 
	
			// Constructors
			public References(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public Transform[] GetTransforms(); // 0x0000000182284B80-0x0000000182285370
			public static bool AutoDetectReferences(Transform root, out References references); // 0x0000000182284700-0x0000000182284B80
		}
	
		// Constructors
		public VRIK(); // 0x0000000182291610-0x0000000182291690
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000182291430-0x0000000182291480
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x00000001822913A0-0x00000001822913F0
		[ContextMenu] // 0x0000000180137E90-0x0000000180137EC0
		private void OpenSetupTutorial(); // 0x00000001822913F0-0x0000000182291430
		[ContextMenu] // 0x0000000180135970-0x00000001801359A0
		public void AutoDetectReferences(); // 0x00000001822912B0-0x00000001822912E0
		[ContextMenu] // 0x0000000180137F60-0x0000000180137F90
		public void GuessHandOrientations(); // 0x00000001822912E0-0x0000000182291310
		public override IKSolver GetIKSolver(); // 0x0000000180369B30-0x0000000180369B40
		protected override void InitiateSolver(); // 0x0000000182291310-0x00000001822913A0
		protected override void UpdateSolver(); // 0x0000000182291480-0x0000000182291610
	}
}
