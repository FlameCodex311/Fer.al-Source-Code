/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: AmplifyOcclusion.dll - Assembly: AmplifyOcclusion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9107-9123

public class MouseLook : UnityEngine.MonoBehaviour // TypeDefIndex: 9118
{
	// Fields
	public RotationAxes axes; // 0x18
	public float sensitivityX; // 0x1C
	public float sensitivityY; // 0x20
	public float minimumX; // 0x24
	public float maximumX; // 0x28
	public float minimumY; // 0x2C
	public float maximumY; // 0x30
	public float forwardSpeedScale; // 0x34
	public float strafeSpeedScale; // 0x38
	private float rotationX; // 0x3C
	private float rotationY; // 0x40
	private bool look; // 0x44
	private Quaternion originalRotation; // 0x48

	// Nested types
	public enum RotationAxes // TypeDefIndex: 9119
	{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	// Constructors
	public MouseLook(); // 0x00000001820980C0-0x0000000182098100

	// Methods
	private void Update(); // 0x0000000182097900-0x00000001820980C0
	private void Start(); // 0x0000000182097830-0x0000000182097900
	public static float ClampAngle(float angle, float min, float max); // 0x0000000182097790-0x0000000182097830
}

