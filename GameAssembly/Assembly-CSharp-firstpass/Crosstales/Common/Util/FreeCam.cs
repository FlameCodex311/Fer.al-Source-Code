/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class FreeCam : UnityEngine.MonoBehaviour // TypeDefIndex: 9957
	{
		// Fields
		public float MovementSpeed; // 0x18
		public float FastMovementSpeed; // 0x1C
		public float FreeLookSensitivity; // 0x20
		public float ZoomSensitivity; // 0x24
		public float FastZoomSensitivity; // 0x28
		private Transform tf; // 0x30
		private bool looking; // 0x38
	
		// Constructors
		public FreeCam(); // 0x00000001815E95A0-0x00000001815E95D0
	
		// Methods
		public void Start(); // 0x00000001815E89A0-0x00000001815E89C0
		public void Update(); // 0x00000001815E89C0-0x00000001815E95A0
		public void OnDisable(); // 0x00000001815E8960-0x00000001815E8980
		public void StartLooking(); // 0x00000001815E8980-0x00000001815E89A0
		public void StopLooking(); // 0x00000001815E8960-0x00000001815E8980
	}
}
