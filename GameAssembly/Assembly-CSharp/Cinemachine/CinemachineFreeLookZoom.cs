/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Cinemachine
{
	[RequireComponent] // 0x00000001800DCC80-0x00000001800DCCE0
	[SaveDuringPlay] // 0x00000001800DCC80-0x00000001800DCCE0
	internal class CinemachineFreeLookZoom : MonoBehaviour // TypeDefIndex: 15966
	{
		// Fields
		private CinemachineFreeLook freelook; // 0x20
		public CinemachineFreeLook.Orbit[] originalOrbits; // 0x28
		[Range] // 0x00000001800DD080-0x00000001800DD0E0
		[Tooltip] // 0x00000001800DD080-0x00000001800DD0E0
		public float minScale; // 0x30
		[Range] // 0x00000001800DD4B0-0x00000001800DD510
		[Tooltip] // 0x00000001800DD4B0-0x00000001800DD510
		public float maxScale; // 0x34
		[AxisStateProperty] // 0x00000001800DD8A0-0x00000001800DD8F0
		[Tooltip] // 0x00000001800DD8A0-0x00000001800DD8F0
		public AxisState zAxis; // 0x38
	
		// Constructors
		public CinemachineFreeLookZoom(); // 0x000000018102CD80-0x000000018102CE90
	
		// Methods
		private void OnValidate(); // 0x000000018102CA30-0x000000018102CAC0
		private void Awake(); // 0x000000018102C8C0-0x000000018102C9B0
		private void Update(); // 0x000000018102CD70-0x000000018102CD80
		private void UpdateZoom(); // 0x000000018102CAC0-0x000000018102CD70
		private float Log_erp(float a, float b, float t); // 0x000000018102C9B0-0x000000018102CA30
	}
}
