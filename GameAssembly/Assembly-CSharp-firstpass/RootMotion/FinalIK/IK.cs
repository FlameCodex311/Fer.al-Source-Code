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
	public abstract class IK : SolverManager // TypeDefIndex: 9892
	{
		// Constructors
		protected IK(); // 0x00000001819F5F80-0x00000001819F5F90
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver(); // 0x00000001819F5E90-0x00000001819F5F80
		protected override void InitiateSolver(); // 0x00000001819F5E10-0x00000001819F5E90
		protected override void FixTransforms(); // 0x00000001819F5DA0-0x00000001819F5E10
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
