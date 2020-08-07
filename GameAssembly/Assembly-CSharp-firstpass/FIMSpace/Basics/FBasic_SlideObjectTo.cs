/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_SlideObjectTo : UnityEngine.MonoBehaviour // TypeDefIndex: 10351
	{
		// Fields
		public FEasing.EFease EaseFunction; // 0x18
		[Tooltip] // 0x00000001801E6BE0-0x00000001801E6C10
		public float Duration; // 0x1C
		[Tooltip] // 0x00000001801E6F90-0x00000001801E6FC0
		public Vector3 OffsetPosition; // 0x20
		[Tooltip] // 0x00000001801E7250-0x00000001801E7280
		public Vector3 OffsetRotation; // 0x2C
		protected bool goToTarget; // 0x38
		protected float time; // 0x3C
		protected Vector3 initPos; // 0x40
		protected Quaternion initRot; // 0x4C
		protected FEasing.Function func; // 0x60
	
		// Constructors
		public FBasic_SlideObjectTo(); // 0x0000000181081710-0x00000001810817B0
	
		// Methods
		private void Start(); // 0x0000000181081390-0x0000000181081410
		protected virtual void Update(); // 0x0000000181081450-0x0000000181081710
		public void ToggleMove(); // 0x0000000181081410-0x0000000181081450
		public void MoveToTarget(); // 0x0000000181081360-0x0000000181081390
		public void MoveBack(); // 0x0000000181081330-0x0000000181081360
	}
}
