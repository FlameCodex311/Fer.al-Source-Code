/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_SlideObjectTo : UnityEngine.MonoBehaviour // TypeDefIndex: 9897
	{
		// Fields
		public FEasing.EFease EaseFunction; // 0x18
		[Tooltip] // 0x0000000180106240-0x0000000180106270
		public float Duration; // 0x1C
		[Tooltip] // 0x0000000180106350-0x0000000180106380
		public Vector3 OffsetPosition; // 0x20
		[Tooltip] // 0x0000000180106510-0x0000000180106540
		public Vector3 OffsetRotation; // 0x2C
		protected bool goToTarget; // 0x38
		protected float time; // 0x3C
		protected Vector3 initPos; // 0x40
		protected Quaternion initRot; // 0x4C
		protected FEasing.Function func; // 0x60
	
		// Constructors
		public FBasic_SlideObjectTo(); // 0x00000001815D7B50-0x00000001815D7BF0
	
		// Methods
		private void Start(); // 0x00000001815D77D0-0x00000001815D7850
		protected virtual void Update(); // 0x00000001815D7890-0x00000001815D7B50
		public void ToggleMove(); // 0x00000001815D7850-0x00000001815D7890
		public void MoveToTarget(); // 0x00000001815D77A0-0x00000001815D77D0
		public void MoveBack(); // 0x00000001815D7770-0x00000001815D77A0
	}
}
