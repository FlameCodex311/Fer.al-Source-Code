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
	public class FBasic_ObjectVibrate : UnityEngine.MonoBehaviour // TypeDefIndex: 9890
	{
		// Fields
		[Tooltip] // 0x0000000180104400-0x0000000180104430
		public float VibrationRate; // 0x18
		[Tooltip] // 0x00000001801045C0-0x00000001801045F0
		public float BaseRange; // 0x1C
		[Range] // 0x00000001801047C0-0x0000000180104820
		[Tooltip] // 0x00000001801047C0-0x0000000180104820
		public float SmoothTranslation; // 0x20
		private float[] randomOffsets; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <initialPosition>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <localPosition>k__BackingField; // 0x3C
		private float time; // 0x48
		private float speed; // 0x4C
		private float range; // 0x50
		internal float intensity; // 0x54
		public Vector3 AxesMultiplier; // 0x58
		public bool ChangeObjectPosition; // 0x64
	
		// Properties
		public Vector3 initialPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001815D6AD0-0x00000001815D6AF0 0x00000001815D6AF0-0x00000001815D6B00
		public Vector3 localPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181211870-0x0000000181211890 0x0000000181211890-0x00000001812118A0
	
		// Constructors
		public FBasic_ObjectVibrate(); // 0x00000001815D6A30-0x00000001815D6AD0
	
		// Methods
		private void Start(); // 0x00000001815D5EC0-0x00000001815D6110
		private void Update(); // 0x00000001815D6110-0x00000001815D6A30
		public void ChooseNewSeed(); // 0x00000001815D5D90-0x00000001815D5EC0
	}
}
