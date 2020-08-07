/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PlayerCameraOptions : MonoBehaviour // TypeDefIndex: 12992
{
	// Fields
	public string optionsName; // 0x20
	public float zoomMultiply; // 0x28
	public float minZoomLevel; // 0x2C
	public float maxZoomLevel; // 0x30
	public float reduceZoomNearColliderDistance; // 0x34
	public float tilt; // 0x38
	public float distance; // 0x3C
	public float height; // 0x40
	public float keyboardHeight; // 0x44
	public float minTilt; // 0x48
	public float maxTilt; // 0x4C
	[NonSerialized]
	public float strength; // 0x50

	// Constructors
	public PlayerCameraOptions(); // 0x00000001804E34C0-0x00000001804E34D0

	// Methods
	public static bool Combine(PlayerCameraOptions outOptions, PlayerCameraOptions inOptions1, PlayerCameraOptions inOptions2); // 0x00000001804E32F0-0x00000001804E34C0
}

