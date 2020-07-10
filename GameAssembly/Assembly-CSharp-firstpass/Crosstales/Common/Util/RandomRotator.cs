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
	public class RandomRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 9961
	{
		// Fields
		[Tooltip] // 0x0000000180119FE0-0x000000018011A010
		public bool UseInterval; // 0x18
		[Tooltip] // 0x000000018011A1C0-0x000000018011A1F0
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x000000018011A3D0-0x000000018011A400
		public Vector3 SpeedMin; // 0x24
		[Tooltip] // 0x000000018011A870-0x000000018011A8A0
		public Vector3 SpeedMax; // 0x30
		[Tooltip] // 0x000000018011AAB0-0x000000018011AAE0
		public bool RandomRotationAtStart; // 0x3C
		private Transform tf; // 0x40
		private Vector3 speed; // 0x48
		private float elapsedTime; // 0x54
		private float changeTime; // 0x58
	
		// Constructors
		public RandomRotator(); // 0x00000001815EB4A0-0x00000001815EB570
	
		// Methods
		public void Start(); // 0x00000001815EB1B0-0x00000001815EB230
		public void Update(); // 0x00000001815EB230-0x00000001815EB4A0
	}
}
