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
	public abstract class IK : SolverManager // TypeDefIndex: 9358
	{
		// Constructors
		protected IK(); // 0x0000000181C31930-0x0000000181C31940
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver(); // 0x0000000181C31840-0x0000000181C31930
		protected override void InitiateSolver(); // 0x0000000181C317C0-0x0000000181C31840
		protected override void FixTransforms(); // 0x0000000181C31750-0x0000000181C317C0
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
