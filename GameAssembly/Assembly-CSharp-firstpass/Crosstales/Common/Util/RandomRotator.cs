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
	public class RandomRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 9747
	{
		// Fields
		[Tooltip] // 0x00000001801FF1B0-0x00000001801FF1E0
		public bool UseInterval; // 0x18
		[Tooltip] // 0x00000001801FF3B0-0x00000001801FF3E0
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x00000001801FF640-0x00000001801FF670
		public Vector3 SpeedMin; // 0x24
		[Tooltip] // 0x00000001801FF7D0-0x00000001801FF800
		public Vector3 SpeedMax; // 0x30
		[Tooltip] // 0x00000001801FF980-0x00000001801FF9B0
		public bool RandomRotationAtStart; // 0x3C
		private Transform tf; // 0x40
		private Vector3 speed; // 0x48
		private float elapsedTime; // 0x54
		private float changeTime; // 0x58
	
		// Constructors
		public RandomRotator(); // 0x000000018108B170-0x000000018108B240
	
		// Methods
		public void Start(); // 0x000000018108AE90-0x000000018108AF00
		public void Update(); // 0x000000018108AF00-0x000000018108B170
	}
}
