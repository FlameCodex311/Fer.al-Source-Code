/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Boxophobic;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ADSGlobalMotion : MonoBehaviour // TypeDefIndex: 11447
{
	// Fields
	[BCategory] // 0x00000001801E41B0-0x00000001801E41E0
	public int category_Update; // 0x20
	public UpdateMode realtimeUpdate; // 0x24
	[BMessage] // 0x00000001801E4350-0x00000001801E43B0
	public bool message_Update; // 0x28
	[BCategory] // 0x00000001801E4610-0x00000001801E4640
	public int category_Motion; // 0x2C
	public float motionAmplitude; // 0x30
	public float motionSpeed; // 0x34
	public float motionScale; // 0x38
	[BCategory] // 0x00000001801E4AF0-0x00000001801E4B20
	public int category_Turbulence; // 0x3C
	public Texture2D turbulenceTexture; // 0x40
	public float turbulenceContrast; // 0x48
	public float turbulenceSpeed; // 0x4C
	public float turbulenceScale; // 0x50

	// Nested types
	public enum UpdateMode // TypeDefIndex: 11448
	{
		Off = 0,
		On = 1
	}

	// Constructors
	public ADSGlobalMotion(); // 0x0000000182163330-0x0000000182163370

	// Methods
	private void Start(); // 0x0000000182163200-0x0000000182163320
	private void Update(); // 0x0000000182163320-0x0000000182163330
	private void SetGlobalShaderProperties(); // 0x0000000182162FE0-0x0000000182163200
}

