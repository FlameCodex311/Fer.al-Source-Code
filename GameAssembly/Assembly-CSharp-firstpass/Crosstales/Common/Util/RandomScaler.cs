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
	public class RandomScaler : UnityEngine.MonoBehaviour // TypeDefIndex: 9748
	{
		// Fields
		[Tooltip] // 0x00000001801FFA90-0x00000001801FFAC0
		public bool UseInterval; // 0x18
		[Tooltip] // 0x00000001801FF3B0-0x00000001801FF3E0
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x00000001801FF640-0x00000001801FF670
		public Vector3 ScaleMin; // 0x24
		[Tooltip] // 0x00000001801FFCA0-0x00000001801FFCD0
		public Vector3 ScaleMax; // 0x30
		[Tooltip] // 0x00000001801FFE80-0x00000001801FFEB0
		public bool Uniform; // 0x3C
		[Tooltip] // 0x00000001802000B0-0x00000001802000E0
		public bool RandomScaleAtStart; // 0x3D
		private Transform tf; // 0x40
		private Vector3 startScale; // 0x48
		private Vector3 endScale; // 0x54
		private float elapsedTime; // 0x60
		private float changeTime; // 0x64
		private float lerpTime; // 0x68
	
		// Constructors
		public RandomScaler(); // 0x000000018108B690-0x000000018108B760
	
		// Methods
		public void Start(); // 0x000000018108B240-0x000000018108B3F0
		public void Update(); // 0x000000018108B3F0-0x000000018108B690
	}
}
