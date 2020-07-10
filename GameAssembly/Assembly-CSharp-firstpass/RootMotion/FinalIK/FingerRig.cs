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
	public class FingerRig : SolverManager // TypeDefIndex: 9338
	{
		// Fields
		[Range] // 0x000000018011FF70-0x000000018011FFD0
		[Tooltip] // 0x000000018011FF70-0x000000018011FFD0
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <initiated>k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
	
		// Constructors
		public FingerRig(); // 0x0000000181C155F0-0x0000000181C15640
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000181C15190-0x0000000181C15220
		[ContextMenu] // 0x00000001801207A0-0x00000001801207D0
		public void AutoDetect(); // 0x0000000181C14B30-0x0000000181C14EF0
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null); // 0x0000000181C14970-0x0000000181C14B30
		public void RemoveFinger(int index); // 0x0000000181C15220-0x0000000181C15410
		private void AddChildrenRecursive(Transform parent, ref Transform[] array); // 0x0000000181C14870-0x0000000181C14970
		protected override void InitiateSolver(); // 0x0000000181C15080-0x0000000181C15190
		public void UpdateFingerSolvers(); // 0x0000000181C15570-0x0000000181C155F0
		public void FixFingerTransforms(); // 0x0000000181C14EF0-0x0000000181C15080
		public void StoreDefaultLocalState(); // 0x0000000181C15410-0x0000000181C15570
		protected override void UpdateSolver(); // 0x0000000181C15570-0x0000000181C155F0
		protected override void FixTransforms(); // 0x0000000181C14EF0-0x0000000181C15080
	}
}
