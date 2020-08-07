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
	public class FingerRig : SolverManager // TypeDefIndex: 9872
	{
		// Fields
		[Range] // 0x00000001802260F0-0x0000000180226150
		[Tooltip] // 0x00000001802260F0-0x0000000180226150
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initiated>k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
	
		// Constructors
		public FingerRig(); // 0x0000000181433AC0-0x0000000181433B10
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000181433680-0x0000000181433710
		[ContextMenu] // 0x0000000180226820-0x0000000180226850
		public void AutoDetect(); // 0x0000000181433070-0x0000000181433400
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null); // 0x0000000181432EC0-0x0000000181433070
		public void RemoveFinger(int index); // 0x0000000181433710-0x00000001814338F0
		private void AddChildrenRecursive(Transform parent, ref Transform[] array); // 0x0000000181432DC0-0x0000000181432EC0
		protected override void InitiateSolver(); // 0x0000000181433580-0x0000000181433680
		public void UpdateFingerSolvers(); // 0x0000000181433A40-0x0000000181433AC0
		public void FixFingerTransforms(); // 0x0000000181433400-0x0000000181433580
		public void StoreDefaultLocalState(); // 0x00000001814338F0-0x0000000181433A40
		protected override void UpdateSolver(); // 0x0000000181433A40-0x0000000181433AC0
		protected override void FixTransforms(); // 0x0000000181433400-0x0000000181433580
	}
}
