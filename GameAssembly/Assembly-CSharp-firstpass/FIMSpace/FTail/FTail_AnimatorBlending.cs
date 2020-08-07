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
	public class FTail_AnimatorBlending : FTail_Animator // TypeDefIndex: 10324
	{
		// Fields
		[Header] // 0x00000001801D5410-0x00000001801D5490
		[Range] // 0x00000001801D5410-0x00000001801D5490
		[Tooltip] // 0x00000001801D5410-0x00000001801D5490
		public float BlendToOriginal; // 0x178
		[Range] // 0x00000001801D5650-0x00000001801D56B0
		[Tooltip] // 0x00000001801D5650-0x00000001801D56B0
		public float BlendChainValue; // 0x17C
		[Tooltip] // 0x00000001801D5940-0x00000001801D5970
		public bool PositionsNotAnimated; // 0x180
		private float smoothChainBlend; // 0x184
		private List<Vector3> staticPositions; // 0x188
	
		// Constructors
		public FTail_AnimatorBlending(); // 0x0000000181741D30-0x0000000181741DB0
	
		// Methods
		protected override void Init(); // 0x0000000181741B70-0x0000000181741BD0
		protected override void CoputeHelperVariables(); // 0x0000000181741A40-0x0000000181741B70
		protected override void Reset(); // 0x0000000181741BF0-0x0000000181741C00
		internal override void Update(); // 0x0000000181741C00-0x0000000181741D30
		internal override void FixedUpdate(); // 0x00000001803774A0-0x00000001803774B0
		public override void CalculateOffsets(); // 0x0000000181740DE0-0x0000000181741A40
		internal override void LateUpdate(); // 0x0000000181741BD0-0x0000000181741BF0
		protected override void SetTailTransformsFromPoints(); // 0x00000001803774A0-0x00000001803774B0
	}
}
