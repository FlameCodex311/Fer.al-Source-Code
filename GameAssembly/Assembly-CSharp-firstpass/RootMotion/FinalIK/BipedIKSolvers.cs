/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 9863
	{
		// Fields
		public IKSolverLimb leftFoot; // 0x10
		public IKSolverLimb rightFoot; // 0x18
		public IKSolverLimb leftHand; // 0x20
		public IKSolverLimb rightHand; // 0x28
		public IKSolverFABRIK spine; // 0x30
		public IKSolverLookAt lookAt; // 0x38
		public IKSolverAim aim; // 0x40
		public Constraints pelvis; // 0x48
		private IKSolverLimb[] _limbs; // 0x50
		private IKSolver[] _ikSolvers; // 0x58
	
		// Properties
		public IKSolverLimb[] limbs { get; } // 0x0000000181423930-0x0000000181423AF0 
		public IKSolver[] ikSolvers { get; } // 0x0000000181423680-0x0000000181423930 
	
		// Constructors
		public BipedIKSolvers(); // 0x0000000181423540-0x0000000181423680
	
		// Methods
		public void AssignReferences(BipedReferences references); // 0x0000000181423350-0x0000000181423540
	}
}
