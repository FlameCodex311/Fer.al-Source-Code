/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FTail
{
	public class FTail_AnimatorLegacy : FTail_Animator // TypeDefIndex: 9873
	{
		// Fields
		public SkinnedMeshRenderer BonesOwner; // 0x178
		[Range] // 0x00000001800F8A60-0x00000001800F8AC0
		[Tooltip] // 0x00000001800F8A60-0x00000001800F8AC0
		public float BlendToOriginal; // 0x180
		protected List<Transform> newSkinnedBones; // 0x188
		protected List<Transform> previousSkinnedBones; // 0x190
	
		// Constructors
		public FTail_AnimatorLegacy(); // 0x0000000181B6F4A0-0x0000000181B6F4B0
	
		// Methods
		protected override void Reset(); // 0x0000000181B6EF80-0x0000000181B6EF90
		protected override void Init(); // 0x0000000181B6E3A0-0x0000000181B6E6B0
		protected override void ConfigureBonesTransforms(); // 0x0000000181B6DE30-0x0000000181B6E3A0
		protected override void MotionCalculations(); // 0x0000000181B6E6B0-0x0000000181B6EF80
		public override void CalculateOffsets(); // 0x0000000181B6DDF0-0x0000000181B6DE30
		public void TryFindBonesOwner(); // 0x0000000181B6EF90-0x0000000181B6F4A0
	}
}
