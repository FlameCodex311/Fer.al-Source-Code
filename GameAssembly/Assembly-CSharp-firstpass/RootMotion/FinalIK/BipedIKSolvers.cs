/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 9329
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
		public IKSolverLimb[] limbs { get; } // 0x000000018181E1A0-0x000000018181E380 
		public IKSolver[] ikSolvers { get; } // 0x000000018181DEC0-0x000000018181E1A0 
	
		// Constructors
		public BipedIKSolvers(); // 0x000000018181DD80-0x000000018181DEC0
	
		// Methods
		public void AssignReferences(BipedReferences references); // 0x000000018181DB90-0x000000018181DD80
	}
}
