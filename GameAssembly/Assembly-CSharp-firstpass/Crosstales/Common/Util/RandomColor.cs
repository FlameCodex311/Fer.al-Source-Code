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
	public class RandomColor : UnityEngine.MonoBehaviour // TypeDefIndex: 9746
	{
		// Fields
		[Tooltip] // 0x00000001801FE060-0x00000001801FE090
		public bool UseInterval; // 0x18
		[Tooltip] // 0x00000001801FE310-0x00000001801FE340
		public Vector2 ChangeInterval; // 0x1C
		[Tooltip] // 0x00000001801FE5E0-0x00000001801FE610
		public Vector2 HueRange; // 0x24
		[Tooltip] // 0x00000001801FE720-0x00000001801FE750
		public Vector2 SaturationRange; // 0x2C
		[Tooltip] // 0x00000001801FE9A0-0x00000001801FE9D0
		public Vector2 ValueRange; // 0x34
		[Tooltip] // 0x00000001801FEAA0-0x00000001801FEAD0
		public Vector2 AlphaRange; // 0x3C
		[Tooltip] // 0x00000001801FEC70-0x00000001801FECA0
		public bool GrayScale; // 0x44
		[Tooltip] // 0x00000001801FEEA0-0x00000001801FEED0
		public Material Material; // 0x48
		[Tooltip] // 0x00000001801FF090-0x00000001801FF0C0
		public bool RandomColorAtStart; // 0x50
		private float elapsedTime; // 0x54
		private float changeTime; // 0x58
		private Renderer currentRenderer; // 0x60
		private Color32 startColor; // 0x68
		private Color32 endColor; // 0x6C
		private float lerpProgress; // 0x70
		private static readonly int colorID; // 0x00
	
		// Constructors
		public RandomColor(); // 0x000000018108AD90-0x000000018108AE90
		static RandomColor(); // 0x000000018108AD40-0x000000018108AD90
	
		// Methods
		public void Start(); // 0x000000018108A580-0x000000018108A910
		public void Update(); // 0x000000018108A910-0x000000018108AD40
	}
}
