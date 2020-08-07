/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public abstract class Poser : SolverManager // TypeDefIndex: 9973
	{
		// Fields
		public Transform poseRoot; // 0x38
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float weight; // 0x40
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float localRotationWeight; // 0x44
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser(); // 0x000000018163BBA0-0x000000018163BBC0
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual(); // 0x00000001808A0430-0x00000001808A0450
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver(); // 0x000000018163BB50-0x000000018163BBA0
		protected override void InitiateSolver(); // 0x000000018163BB20-0x000000018163BB50
		protected override void FixTransforms(); // 0x000000018163BB00-0x000000018163BB20
	}
}
