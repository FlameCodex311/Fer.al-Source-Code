/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FakeSanctuaryLights : MonoBehaviour // TypeDefIndex: 11952
{
	// Fields
	private static FakeSanctuaryLights _instance; // 0x00
	private Color? _initialColor; // 0x20
	private Color _currentcolor; // 0x34
	private bool? _isInterior; // 0x44

	// Properties
	public static FakeSanctuaryLights instance { get; } // 0x00000001808699B0-0x0000000180869AE0 

	// Constructors
	public FakeSanctuaryLights(); // 0x0000000180869980-0x00000001808699B0
	static FakeSanctuaryLights(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public void Initialize(); // 0x00000001803774A0-0x00000001803774B0
	private void Update(); // 0x0000000180869600-0x0000000180869980
	public void ChangeLightsInRoom(Color? inColor = default); // 0x00000001808692B0-0x0000000180869500
	private void OnDestroy(); // 0x0000000180869500-0x0000000180869570
	private void SetInitialColor(); // 0x0000000180869570-0x0000000180869600
	private void ResetVars(); // 0x0000000180869500-0x0000000180869570
}

