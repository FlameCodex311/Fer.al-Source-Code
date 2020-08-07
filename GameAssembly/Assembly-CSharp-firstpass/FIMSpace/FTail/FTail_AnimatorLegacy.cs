/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FTail
{
	public class FTail_AnimatorLegacy : FTail_Animator // TypeDefIndex: 10325
	{
		// Fields
		public SkinnedMeshRenderer BonesOwner; // 0x178
		[Range] // 0x00000001801D5AB0-0x00000001801D5B10
		[Tooltip] // 0x00000001801D5AB0-0x00000001801D5B10
		public float BlendToOriginal; // 0x180
		protected List<Transform> newSkinnedBones; // 0x188
		protected List<Transform> previousSkinnedBones; // 0x190
	
		// Constructors
		public FTail_AnimatorLegacy(); // 0x00000001817433B0-0x00000001817433C0
	
		// Methods
		protected override void Reset(); // 0x0000000181742EB0-0x0000000181742EC0
		protected override void Init(); // 0x0000000181742340-0x0000000181742630
		protected override void ConfigureBonesTransforms(); // 0x0000000181741DF0-0x0000000181742340
		protected override void MotionCalculations(); // 0x0000000181742630-0x0000000181742EB0
		public override void CalculateOffsets(); // 0x0000000181741DB0-0x0000000181741DF0
		public void TryFindBonesOwner(); // 0x0000000181742EC0-0x00000001817433B0
	}
}
