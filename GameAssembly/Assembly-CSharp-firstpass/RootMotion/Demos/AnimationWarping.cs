/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class AnimationWarping : OffsetModifier // TypeDefIndex: 9505
	{
		// Fields
		[Tooltip] // 0x00000001800D38D0-0x00000001800D3900
		public Animator animator; // 0x30
		[Tooltip] // 0x00000001800D3A20-0x00000001800D3A50
		public EffectorMode effectorMode; // 0x38
		[Space] // 0x00000001800D3D30-0x00000001800D3D80
		[Tooltip] // 0x00000001800D3D30-0x00000001800D3D80
		public Warp[] warps; // 0x40
		private EffectorMode lastMode; // 0x48
	
		// Nested types
		[Serializable]
		public struct Warp // TypeDefIndex: 9506
		{
			// Fields
			[Tooltip] // 0x00000001800D40D0-0x00000001800D4100
			public int animationLayer; // 0x00
			[Tooltip] // 0x00000001800D4300-0x00000001800D4330
			public string animationState; // 0x08
			[Tooltip] // 0x00000001800D44C0-0x00000001800D44F0
			public AnimationCurve weightCurve; // 0x10
			[Tooltip] // 0x00000001800D46E0-0x00000001800D4710
			public Transform warpFrom; // 0x18
			[Tooltip] // 0x00000001800D4890-0x00000001800D48C0
			public Transform warpTo; // 0x20
			[Tooltip] // 0x00000001800D4AE0-0x00000001800D4B10
			public FullBodyBipedEffector effector; // 0x28
		}
	
		[Serializable]
		public enum EffectorMode // TypeDefIndex: 9507
		{
			PositionOffset = 0,
			Position = 1
		}
	
		// Constructors
		public AnimationWarping(); // 0x0000000181638E90-0x0000000181638EA0
	
		// Methods
		protected override void Start(); // 0x0000000181638E70-0x0000000181638E90
		public float GetWarpWeight(int warpIndex); // 0x0000000181638510-0x00000001816387D0
		protected override void OnModifyOffset(); // 0x00000001816388A0-0x0000000181638E70
		private void OnDisable(); // 0x00000001816387D0-0x00000001816388A0
	}
}
