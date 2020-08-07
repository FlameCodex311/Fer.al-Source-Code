/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FTail
{
	public class FTail_Animator : FTail_AnimatorBase // TypeDefIndex: 10322
	{
		// Fields
		public bool UseWaving; // 0x138
		[Tooltip] // 0x00000001801D4F60-0x00000001801D4F90
		public bool CosinusAdd; // 0x139
		public float WavingSpeed; // 0x13C
		public float WavingRange; // 0x140
		public Vector3 WavingAxis; // 0x144
		public Vector3 TailRotationOffset; // 0x150
		[Tooltip] // 0x00000001801D5250-0x00000001801D5280
		public bool DisconnectTransforms; // 0x15C
		protected static Transform disconnectedContainer; // 0x00
		protected Transform localDisconnectedContainer; // 0x160
		protected float waveTime; // 0x168
		protected float cosTime; // 0x16C
		private int RefreshCounter; // 0x170
	
		// Constructors
		public FTail_Animator(); // 0x0000000181744730-0x0000000181744800
	
		// Methods
		protected override void Init(); // 0x0000000181741B70-0x0000000181741BD0
		protected virtual void WavingCalculations(); // 0x00000001817440E0-0x0000000181744730
		public override void CalculateOffsets(); // 0x0000000181743600-0x0000000181743690
		protected override void ConfigureBonesTransforms(); // 0x0000000181743690-0x0000000181743770
		protected Transform GetDisconnectedContainer(); // 0x00000001817437A0-0x0000000181743930
		internal virtual void Update(); // 0x00000001817440B0-0x00000001817440E0
		internal virtual void LateUpdate(); // 0x0000000181743930-0x0000000181743980
		internal virtual void FixedUpdate(); // 0x0000000181743770-0x00000001817437A0
		protected override void OnDestroy(); // 0x0000000181744000-0x00000001817440B0
	}
}
