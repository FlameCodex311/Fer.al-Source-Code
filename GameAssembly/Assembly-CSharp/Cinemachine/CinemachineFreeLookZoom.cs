/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Cinemachine
{
	[RequireComponent] // 0x000000018021E390-0x000000018021E3F0
	[SaveDuringPlay] // 0x000000018021E390-0x000000018021E3F0
	internal class CinemachineFreeLookZoom : MonoBehaviour // TypeDefIndex: 14353
	{
		// Fields
		private CinemachineFreeLook freelook; // 0x20
		public CinemachineFreeLook.Orbit[] originalOrbits; // 0x28
		[Range] // 0x000000018021E6F0-0x000000018021E750
		[Tooltip] // 0x000000018021E6F0-0x000000018021E750
		public float minScale; // 0x30
		[Range] // 0x000000018021EA80-0x000000018021EAE0
		[Tooltip] // 0x000000018021EA80-0x000000018021EAE0
		public float maxScale; // 0x34
		[AxisStateProperty] // 0x000000018021EDB0-0x000000018021EE00
		[Tooltip] // 0x000000018021EDB0-0x000000018021EE00
		public AxisState zAxis; // 0x38
	
		// Constructors
		public CinemachineFreeLookZoom(); // 0x00000001805221F0-0x0000000180522300
	
		// Methods
		private void OnValidate(); // 0x0000000180521EB0-0x0000000180521F40
		private void Awake(); // 0x0000000180521D40-0x0000000180521E30
		private void Update(); // 0x00000001805221E0-0x00000001805221F0
		private void UpdateZoom(); // 0x0000000180521F40-0x00000001805221E0
		private float Log_erp(float a, float b, float t); // 0x0000000180521E30-0x0000000180521EB0
	}
}
