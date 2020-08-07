/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TimingCursorController : MonoBehaviour // TypeDefIndex: 13248
{
	// Fields
	public float velocity; // 0x20
	public int direction; // 0x24
	public Rect movementBounds; // 0x28
	public bool moving; // 0x38
	private RectTransform rectTransform; // 0x40
	private Vector3 posA; // 0x48
	private Vector3 posB; // 0x54
	private float width; // 0x60

	// Constructors
	public TimingCursorController(); // 0x0000000180F90DA0-0x0000000180F90DC0

	// Methods
	private void Init(); // 0x0000000180F90880-0x0000000180F90A60
	public void QuickGameUpdate(); // 0x0000000180F90A70-0x0000000180F90C30
	public void SetBounds(float x, float y, float width, float height); // 0x0000000180F90C30-0x0000000180F90DA0
	public void Stop(); // 0x0000000180E1A420-0x0000000180E1A430
	public bool IsStoppedInRegion(Rect region); // 0x0000000180F90A60-0x0000000180F90A70
}

