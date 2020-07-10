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
	public class RandomColor : UnityEngine.MonoBehaviour // TypeDefIndex: 9960
	{
		// Fields
		[Tooltip] // 0x0000000180119270-0x00000001801192A0
		public bool UseInterval; // 0x18
		[Tooltip] // 0x00000001801193E0-0x0000000180119410
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x0000000180119600-0x0000000180119630
		public Vector2 HueRange; // 0x24
		[Tooltip] // 0x00000001801196C0-0x00000001801196F0
		public Vector2 SaturationRange; // 0x2C
		[Tooltip] // 0x0000000180119790-0x00000001801197C0
		public Vector2 ValueRange; // 0x34
		[Tooltip] // 0x00000001801198C0-0x00000001801198F0
		public Vector2 AlphaRange; // 0x3C
		[Tooltip] // 0x0000000180119A80-0x0000000180119AB0
		public bool GrayScale; // 0x44
		[Tooltip] // 0x0000000180119BF0-0x0000000180119C20
		public Material Material; // 0x48
		[Tooltip] // 0x0000000180119DD0-0x0000000180119E00
		public bool RandomColorAtStart; // 0x50
		private float elapsedTime; // 0x54
		private float changeTime; // 0x58
		private Renderer currentRenderer; // 0x60
		private Color32 startColor; // 0x68
		private Color32 endColor; // 0x6C
		private float lerpProgress; // 0x70
		private static readonly int colorID; // 0x00
	
		// Constructors
		public RandomColor(); // 0x00000001815EB0B0-0x00000001815EB1B0
		static RandomColor(); // 0x00000001815EB060-0x00000001815EB0B0
	
		// Methods
		public void Start(); // 0x00000001815EA8A0-0x00000001815EAC30
		public void Update(); // 0x00000001815EAC30-0x00000001815EB060
	}
}
