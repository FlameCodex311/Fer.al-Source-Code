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
	public class RandomScaler : UnityEngine.MonoBehaviour // TypeDefIndex: 9962
	{
		// Fields
		[Tooltip] // 0x000000018011AB70-0x000000018011ABA0
		public bool UseInterval; // 0x18
		[Tooltip] // 0x000000018011A1C0-0x000000018011A1F0
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x000000018011A3D0-0x000000018011A400
		public Vector3 ScaleMin; // 0x24
		[Tooltip] // 0x000000018011AFB0-0x000000018011AFE0
		public Vector3 ScaleMax; // 0x30
		[Tooltip] // 0x000000018011B100-0x000000018011B130
		public bool Uniform; // 0x3C
		[Tooltip] // 0x000000018011B1D0-0x000000018011B200
		public bool RandomScaleAtStart; // 0x3D
		private Transform tf; // 0x40
		private Vector3 startScale; // 0x48
		private Vector3 endScale; // 0x54
		private float elapsedTime; // 0x60
		private float changeTime; // 0x64
		private float lerpTime; // 0x68
	
		// Constructors
		public RandomScaler(); // 0x00000001815EB9C0-0x00000001815EBA90
	
		// Methods
		public void Start(); // 0x00000001815EB570-0x00000001815EB720
		public void Update(); // 0x00000001815EB720-0x00000001815EB9C0
	}
}
