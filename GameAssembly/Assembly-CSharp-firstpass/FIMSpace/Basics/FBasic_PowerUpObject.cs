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
	public class FBasic_PowerUpObject : UnityEngine.MonoBehaviour // TypeDefIndex: 10345
	{
		// Fields
		[Header] // 0x00000001801E4C70-0x00000001801E4CA0
		public float YFloatingValue; // 0x18
		public float FloatingSpeedRate; // 0x1C
		public float RotationSpeed; // 0x20
		[Header] // 0x00000001801E4F40-0x00000001801E4F70
		public string TagToCollideWith; // 0x28
		private Vector3 initPosition; // 0x30
		private float randomOffset; // 0x3C
	
		// Constructors
		public FBasic_PowerUpObject(); // 0x0000000181080A90-0x0000000181080AF0
	
		// Methods
		private void Start(); // 0x0000000181080800-0x00000001810808B0
		private void Update(); // 0x00000001810808B0-0x0000000181080A90
		private void OnTriggerEnter(Collider other); // 0x0000000181080750-0x0000000181080800
		protected void Collect(); // 0x00000001810806F0-0x0000000181080750
	}
}
