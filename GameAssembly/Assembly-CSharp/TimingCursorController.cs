/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TimingCursorController : MonoBehaviour // TypeDefIndex: 11721
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
	public TimingCursorController(); // 0x0000000180FA2F00-0x0000000180FA2F20

	// Methods
	private void Init(); // 0x0000000180FA29C0-0x0000000180FA2BB0
	public void QuickGameUpdate(); // 0x0000000180FA2BC0-0x0000000180FA2D80
	public void SetBounds(float x, float y, float width, float height); // 0x0000000180FA2D80-0x0000000180FA2F00
	public void Stop(); // 0x0000000180A860A0-0x0000000180A860B0
	public bool IsStoppedInRegion(Rect region); // 0x0000000180FA2BB0-0x0000000180FA2BC0
}

