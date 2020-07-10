/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PlayerCameraOptions : MonoBehaviour // TypeDefIndex: 11471
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
	public PlayerCameraOptions(); // 0x000000018115A260-0x000000018115A270

	// Methods
	public static bool Combine(PlayerCameraOptions outOptions, PlayerCameraOptions inOptions1, PlayerCameraOptions inOptions2); // 0x000000018115A090-0x000000018115A260
}

