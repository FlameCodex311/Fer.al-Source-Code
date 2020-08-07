/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class AnimationWarping : OffsetModifier // TypeDefIndex: 9792
	{
		// Fields
		[Tooltip] // 0x000000018020A4C0-0x000000018020A4F0
		public Animator animator; // 0x30
		[Tooltip] // 0x000000018020A660-0x000000018020A690
		public EffectorMode effectorMode; // 0x38
		[Space] // 0x000000018020A810-0x000000018020A860
		[Tooltip] // 0x000000018020A810-0x000000018020A860
		public Warp[] warps; // 0x40
		private EffectorMode lastMode; // 0x48
	
		// Nested types
		[Serializable]
		public struct Warp // TypeDefIndex: 9793
		{
			// Fields
			[Tooltip] // 0x000000018020AA20-0x000000018020AA50
			public int animationLayer; // 0x00
			[Tooltip] // 0x000000018020ABC0-0x000000018020ABF0
			public string animationState; // 0x08
			[Tooltip] // 0x000000018020AD60-0x000000018020AD90
			public AnimationCurve weightCurve; // 0x10
			[Tooltip] // 0x000000018020AF90-0x000000018020AFC0
			public Transform warpFrom; // 0x18
			[Tooltip] // 0x000000018020B1F0-0x000000018020B220
			public Transform warpTo; // 0x20
			[Tooltip] // 0x000000018020B3A0-0x000000018020B3D0
			public FullBodyBipedEffector effector; // 0x28
		}
	
		[Serializable]
		public enum EffectorMode // TypeDefIndex: 9794
		{
			PositionOffset = 0,
			Position = 1
		}
	
		// Constructors
		public AnimationWarping(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void Start(); // 0x0000000181365EC0-0x0000000181365EE0
		public float GetWarpWeight(int warpIndex); // 0x0000000181365530-0x0000000181365800
		protected override void OnModifyOffset(); // 0x00000001813658C0-0x0000000181365EC0
		private void OnDisable(); // 0x0000000181365800-0x00000001813658C0
	}
}
