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
	public class FTail_AnimatorBlending : FTail_Animator // TypeDefIndex: 9872
	{
		// Fields
		[Header] // 0x00000001800F8210-0x00000001800F8290
		[Range] // 0x00000001800F8210-0x00000001800F8290
		[Tooltip] // 0x00000001800F8210-0x00000001800F8290
		public float BlendToOriginal; // 0x178
		[Range] // 0x00000001800F85B0-0x00000001800F8610
		[Tooltip] // 0x00000001800F85B0-0x00000001800F8610
		public float BlendChainValue; // 0x17C
		[Tooltip] // 0x00000001800F87E0-0x00000001800F8810
		public bool PositionsNotAnimated; // 0x180
		private float smoothChainBlend; // 0x184
		private List<Vector3> staticPositions; // 0x188
	
		// Constructors
		public FTail_AnimatorBlending(); // 0x0000000181B6DD70-0x0000000181B6DDF0
	
		// Methods
		protected override void Init(); // 0x0000000181B6DBA0-0x0000000181B6DC00
		protected override void CoputeHelperVariables(); // 0x0000000181B6DA60-0x0000000181B6DBA0
		protected override void Reset(); // 0x0000000181B6DC20-0x0000000181B6DC30
		internal override void Update(); // 0x0000000181B6DC30-0x0000000181B6DD70
		internal override void FixedUpdate(); // 0x00000001803581E0-0x00000001803581F0
		public override void CalculateOffsets(); // 0x0000000181B6CDB0-0x0000000181B6DA60
		internal override void LateUpdate(); // 0x0000000181B6DC00-0x0000000181B6DC20
		protected override void SetTailTransformsFromPoints(); // 0x00000001803581E0-0x00000001803581F0
	}
}
