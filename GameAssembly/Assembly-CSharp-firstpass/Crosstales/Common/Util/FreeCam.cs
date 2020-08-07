/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class FreeCam : UnityEngine.MonoBehaviour // TypeDefIndex: 9743
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
		public FreeCam(); // 0x0000000181089090-0x00000001810890C0
	
		// Methods
		public void Start(); // 0x00000001810884B0-0x00000001810884D0
		public void Update(); // 0x00000001810884D0-0x0000000181089090
		public void OnDisable(); // 0x0000000181088470-0x0000000181088490
		public void StartLooking(); // 0x0000000181088490-0x00000001810884B0
		public void StopLooking(); // 0x0000000181088470-0x0000000181088490
	}
}
