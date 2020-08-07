/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class SolverManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9777
	{
		// Fields
		[Tooltip] // 0x0000000180206D70-0x0000000180206DA0
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get; } // 0x0000000182022A40-0x0000000182022B20 
		private bool isAnimated { get; } // 0x0000000182022B20-0x0000000182022BD0 
	
		// Constructors
		public SolverManager(); // 0x000000018100CA10-0x000000018100CA20
	
		// Methods
		public void Disable(); // 0x0000000182022650-0x00000001820226D0
		protected virtual void InitiateSolver(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void UpdateSolver(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void FixTransforms(); // 0x00000001803774A0-0x00000001803774B0
		private void OnDisable(); // 0x0000000182022960-0x00000001820229C0
		private void Start(); // 0x00000001820228C0-0x0000000182022910
		private void Initiate(); // 0x00000001820228C0-0x0000000182022910
		private void Update(); // 0x0000000182022A00-0x0000000182022A40
		private void FindAnimatorRecursive(Transform t, bool findInChildren); // 0x00000001820226D0-0x0000000182022870
		private void FixedUpdate(); // 0x0000000182022870-0x00000001820228C0
		private void LateUpdate(); // 0x0000000182022910-0x0000000182022960
		public void UpdateSolverExternal(); // 0x00000001820229C0-0x0000000182022A00
	}
}
