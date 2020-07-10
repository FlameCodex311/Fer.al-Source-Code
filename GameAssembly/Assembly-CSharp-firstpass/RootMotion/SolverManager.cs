/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class SolverManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9323
	{
		// Fields
		[Tooltip] // 0x000000018011DB30-0x000000018011DB60
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get; } // 0x000000018228A360-0x000000018228A440 
		private bool isAnimated { get; } // 0x000000018228A440-0x000000018228A4F0 
	
		// Constructors
		public SolverManager(); // 0x00000001817BA9B0-0x00000001817BA9C0
	
		// Methods
		public void Disable(); // 0x0000000182289F70-0x0000000182289FF0
		protected virtual void InitiateSolver(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void UpdateSolver(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void FixTransforms(); // 0x00000001803581E0-0x00000001803581F0
		private void OnDisable(); // 0x000000018228A280-0x000000018228A2E0
		private void Start(); // 0x000000018228A1E0-0x000000018228A230
		private void Initiate(); // 0x000000018228A1E0-0x000000018228A230
		private void Update(); // 0x000000018228A320-0x000000018228A360
		private void FindAnimatorRecursive(Transform t, bool findInChildren); // 0x0000000182289FF0-0x000000018228A190
		private void FixedUpdate(); // 0x000000018228A190-0x000000018228A1E0
		private void LateUpdate(); // 0x000000018228A230-0x000000018228A280
		public void UpdateSolverExternal(); // 0x000000018228A2E0-0x000000018228A320
	}
}
