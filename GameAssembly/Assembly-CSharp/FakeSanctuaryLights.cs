/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FakeSanctuaryLights : MonoBehaviour // TypeDefIndex: 10442
{
	// Fields
	private static FakeSanctuaryLights _instance; // 0x00
	private Color? _initialColor; // 0x20
	private Color _currentcolor; // 0x34
	private bool _isInterior; // 0x44

	// Properties
	public static FakeSanctuaryLights instance { get; } // 0x0000000181491ED0-0x0000000181492000 

	// Constructors
	public FakeSanctuaryLights(); // 0x0000000181491EA0-0x0000000181491ED0
	static FakeSanctuaryLights(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private void Update(); // 0x0000000181491CA0-0x0000000181491EA0
	public void ChangeLightsInRoom(); // 0x0000000181491940-0x0000000181491BA0
	private void OnDestroy(); // 0x0000000181491BA0-0x0000000181491C10
	private void SetInitialColor(); // 0x0000000181491C10-0x0000000181491CA0
	private void ResetVars(); // 0x0000000181491BA0-0x0000000181491C10
}

