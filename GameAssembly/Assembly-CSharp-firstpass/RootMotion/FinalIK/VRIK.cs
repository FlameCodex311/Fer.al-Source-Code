/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018023D620-0x000000018023D650
	public class VRIK : IK // TypeDefIndex: 9898
	{
		// Fields
		[ContextMenuItem] // 0x000000018023D740-0x000000018023D7C0
		[Tooltip] // 0x000000018023D740-0x000000018023D7C0
		public References references; // 0x38
		[Tooltip] // 0x000000018023D940-0x000000018023D970
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 9899
		{
			// Fields
			public Transform root; // 0x10
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform chest; // 0x28
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform neck; // 0x30
			public Transform head; // 0x38
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform leftShoulder; // 0x40
			public Transform leftUpperArm; // 0x48
			public Transform leftForearm; // 0x50
			public Transform leftHand; // 0x58
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform rightShoulder; // 0x60
			public Transform rightUpperArm; // 0x68
			public Transform rightForearm; // 0x70
			public Transform rightHand; // 0x78
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform leftThigh; // 0x80
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform leftCalf; // 0x88
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform leftFoot; // 0x90
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform leftToes; // 0x98
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform rightThigh; // 0xA0
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform rightCalf; // 0xA8
			[Tooltip] // 0x000000018023E6C0-0x000000018023E6F0
			public Transform rightFoot; // 0xB0
			[Tooltip] // 0x000000018023E150-0x000000018023E180
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get; } // 0x0000000182021040-0x0000000182021560 
			public bool isEmpty { get; } // 0x0000000182020B30-0x0000000182021040 
	
			// Constructors
			public References(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public Transform[] GetTransforms(); // 0x00000001820203C0-0x0000000182020B30
			public static bool AutoDetectReferences(Transform root, out References references); // 0x000000018201FF70-0x00000001820203C0
		}
	
		// Constructors
		public VRIK(); // 0x0000000182029A90-0x0000000182029B10
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x00000001820298C0-0x0000000182029910
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x0000000182029830-0x0000000182029880
		[ContextMenu] // 0x000000018023DCA0-0x000000018023DCD0
		private void OpenSetupTutorial(); // 0x0000000182029880-0x00000001820298C0
		[ContextMenu] // 0x000000018023A280-0x000000018023A2B0
		public void AutoDetectReferences(); // 0x0000000182029740-0x0000000182029770
		[ContextMenu] // 0x000000018023DFA0-0x000000018023DFD0
		public void GuessHandOrientations(); // 0x0000000182029770-0x00000001820297A0
		public override IKSolver GetIKSolver(); // 0x00000001803C7290-0x00000001803C72A0
		protected override void InitiateSolver(); // 0x00000001820297A0-0x0000000182029830
		protected override void UpdateSolver(); // 0x0000000182029910-0x0000000182029A90
	}
}
