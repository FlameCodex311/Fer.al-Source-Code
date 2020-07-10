/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FTail
{
	public class FTail_Animator : FTail_AnimatorBase // TypeDefIndex: 9868
	{
		// Fields
		public bool UseWaving; // 0x138
		[Tooltip] // 0x00000001800F6AF0-0x00000001800F6B20
		public bool CosinusAdd; // 0x139
		public float WavingSpeed; // 0x13C
		public float WavingRange; // 0x140
		public Vector3 WavingAxis; // 0x144
		public Vector3 TailRotationOffset; // 0x150
		[Tooltip] // 0x00000001800F6D90-0x00000001800F6DC0
		public bool DisconnectTransforms; // 0x15C
		protected static Transform disconnectedContainer; // 0x00
		protected Transform localDisconnectedContainer; // 0x160
		protected float waveTime; // 0x168
		protected float cosTime; // 0x16C
		private int RefreshCounter; // 0x170
	
		// Constructors
		public FTail_Animator(); // 0x0000000181B70880-0x0000000181B70950
	
		// Methods
		protected override void Init(); // 0x0000000181B6DBA0-0x0000000181B6DC00
		protected virtual void WavingCalculations(); // 0x0000000181B70210-0x0000000181B70880
		public override void CalculateOffsets(); // 0x0000000181B6F6F0-0x0000000181B6F780
		protected override void ConfigureBonesTransforms(); // 0x0000000181B6F780-0x0000000181B6F870
		protected Transform GetDisconnectedContainer(); // 0x0000000181B6F8A0-0x0000000181B6FA40
		internal virtual void Update(); // 0x0000000181B701E0-0x0000000181B70210
		internal virtual void LateUpdate(); // 0x0000000181B6FA40-0x0000000181B6FA90
		internal virtual void FixedUpdate(); // 0x0000000181B6F870-0x0000000181B6F8A0
		protected override void OnDestroy(); // 0x0000000181B70130-0x0000000181B701E0
	}
}
