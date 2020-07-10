/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Boxophobic;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ADSGlobalMotion : MonoBehaviour // TypeDefIndex: 13774
{
	// Fields
	[BCategory] // 0x000000018010A940-0x000000018010A970
	public int category_Update; // 0x20
	public UpdateMode realtimeUpdate; // 0x24
	[BMessage] // 0x000000018010AAB0-0x000000018010AB10
	public bool message_Update; // 0x28
	[BCategory] // 0x000000018010AE00-0x000000018010AE30
	public int category_Motion; // 0x2C
	public float motionAmplitude; // 0x30
	public float motionSpeed; // 0x34
	public float motionScale; // 0x38
	[BCategory] // 0x000000018010AF30-0x000000018010AF60
	public int category_Turbulence; // 0x3C
	public Texture2D turbulenceTexture; // 0x40
	public float turbulenceContrast; // 0x48
	public float turbulenceSpeed; // 0x4C
	public float turbulenceScale; // 0x50

	// Nested types
	public enum UpdateMode // TypeDefIndex: 13775
	{
		Off = 0,
		On = 1
	}

	// Constructors
	public ADSGlobalMotion(); // 0x000000018122E090-0x000000018122E0D0

	// Methods
	private void Start(); // 0x000000018122DF50-0x000000018122E080
	private void Update(); // 0x000000018122E080-0x000000018122E090
	private void SetGlobalShaderProperties(); // 0x000000018122DD20-0x000000018122DF50
}

