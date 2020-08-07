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
	public class FBasic_ObjectVibrate : UnityEngine.MonoBehaviour // TypeDefIndex: 10344
	{
		// Fields
		[Tooltip] // 0x00000001801E3880-0x00000001801E38B0
		public float VibrationRate; // 0x18
		[Tooltip] // 0x00000001801E3A20-0x00000001801E3A50
		public float BaseRange; // 0x1C
		[Range] // 0x00000001801E3CF0-0x00000001801E3D50
		[Tooltip] // 0x00000001801E3CF0-0x00000001801E3D50
		public float SmoothTranslation; // 0x20
		private float[] randomOffsets; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <initialPosition>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <localPosition>k__BackingField; // 0x3C
		private float time; // 0x48
		private float speed; // 0x4C
		private float range; // 0x50
		internal float intensity; // 0x54
		public Vector3 AxesMultiplier; // 0x58
		public bool ChangeObjectPosition; // 0x64
	
		// Properties
		public Vector3 initialPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001810806C0-0x00000001810806E0 0x00000001810806E0-0x00000001810806F0
		public Vector3 localPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180CBD400-0x0000000180CBD420 0x0000000180CBD420-0x0000000180CBD600
	
		// Constructors
		public FBasic_ObjectVibrate(); // 0x0000000181080620-0x00000001810806C0
	
		// Methods
		private void Start(); // 0x000000018107FB10-0x000000018107FD50
		private void Update(); // 0x000000018107FD50-0x0000000181080620
		public void ChooseNewSeed(); // 0x000000018107F9F0-0x000000018107FB10
	}
}
