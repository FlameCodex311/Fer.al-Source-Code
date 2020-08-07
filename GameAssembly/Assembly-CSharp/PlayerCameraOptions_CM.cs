/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class PlayerCameraOptions_CM // TypeDefIndex: 12991
{
	// Fields
	public string virtualCameraID; // 0x10
	public float zoomMultiply; // 0x18
	public float minZoomLevel; // 0x1C
	public float maxZoomLevel; // 0x20
	public float reduceZoomNearColliderDistance; // 0x24
	public float yaw; // 0x28
	public float tilt; // 0x2C
	public float distance; // 0x30
	public float height; // 0x34
	public float keyboardHeight; // 0x38
	public float minZoomTiltOffset; // 0x3C
	public float maxZoomTiltOffset; // 0x40
	[NonSerialized]
	public float strength; // 0x44

	// Constructors
	public PlayerCameraOptions_CM(); // 0x00000001804E32E0-0x00000001804E32F0

	// Methods
	public static bool Combine(PlayerCameraOptions_CM outOptions, PlayerCameraOptions_CM inOptions1, PlayerCameraOptions_CM inOptions2); // 0x00000001804E30F0-0x00000001804E32E0
}

