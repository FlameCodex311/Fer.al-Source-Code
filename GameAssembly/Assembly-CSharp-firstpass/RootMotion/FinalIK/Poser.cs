/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public abstract class Poser : SolverManager // TypeDefIndex: 9439
	{
		// Fields
		public Transform poseRoot; // 0x38
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float weight; // 0x40
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float localRotationWeight; // 0x44
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser(); // 0x0000000181B0AE40-0x0000000181B0AE60
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual(); // 0x00000001805A9250-0x00000001805A9270
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver(); // 0x0000000181B0ADF0-0x0000000181B0AE40
		protected override void InitiateSolver(); // 0x0000000181B0ADC0-0x0000000181B0ADF0
		protected override void FixTransforms(); // 0x0000000181B0ADA0-0x0000000181B0ADC0
	}
}
