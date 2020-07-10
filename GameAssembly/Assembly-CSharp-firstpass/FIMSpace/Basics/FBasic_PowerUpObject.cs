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
	public class FBasic_PowerUpObject : UnityEngine.MonoBehaviour // TypeDefIndex: 9891
	{
		// Fields
		[Header] // 0x0000000180104FF0-0x0000000180105020
		public float YFloatingValue; // 0x18
		public float FloatingSpeedRate; // 0x1C
		public float RotationSpeed; // 0x20
		[Header] // 0x0000000180105180-0x00000001801051B0
		public string TagToCollideWith; // 0x28
		private Vector3 initPosition; // 0x30
		private float randomOffset; // 0x3C
	
		// Constructors
		public FBasic_PowerUpObject(); // 0x00000001815D6EA0-0x00000001815D6F00
	
		// Methods
		private void Start(); // 0x00000001815D6C10-0x00000001815D6CC0
		private void Update(); // 0x00000001815D6CC0-0x00000001815D6EA0
		private void OnTriggerEnter(Collider other); // 0x00000001815D6B60-0x00000001815D6C10
		protected void Collect(); // 0x00000001815D6B00-0x00000001815D6B60
	}
}
