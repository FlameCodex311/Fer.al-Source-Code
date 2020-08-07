/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018021C2F0-0x000000018021C340
	public class CharacterAnimationSimple : CharacterAnimationBase // TypeDefIndex: 9847
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float pivotOffset; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve moveSpeed; // 0x70
		private Animator animator; // 0x78
	
		// Constructors
		public CharacterAnimationSimple(); // 0x000000018136E100-0x000000018136E120
	
		// Methods
		protected override void Start(); // 0x000000018136E2E0-0x000000018136E330
		public override Vector3 GetPivotPoint(); // 0x000000018136E120-0x000000018136E2E0
		private void Update(); // 0x000000018136E330-0x000000018136E510
	}
}
