/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TimeClock : ManagedBehaviour // TypeDefIndex: 10652
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _secondHandPivot; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _minuteHandPivot; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _hourHandPivot; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _dayHandPivot; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ERotator _secondHandRotator; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ERotator _minuteHandRotator; // 0x74
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ERotator _hourHandRotator; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ERotator _dayHandRotator; // 0x7C
	private Vector3 _initialEulerSecondHand; // 0x80
	private Vector3 _initialEulerMinuteHand; // 0x8C
	private Vector3 _initialEulerHourHand; // 0x98
	private Vector3 _initialEulerDayHand; // 0xA4

	// Nested types
	public enum ERotator // TypeDefIndex: 10653
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	// Constructors
	public TimeClock(); // 0x0000000181A0C3E0-0x0000000181A0C500

	// Methods
	public override void MStart(); // 0x0000000181A0BE50-0x0000000181A0C0C0
	public override void MUpdate(); // 0x0000000181A0C0C0-0x0000000181A0C2A0
	private void SetRotation(Transform inTransform, ERotator inRotator, float inValue, Vector3 inInitialEuler); // 0x0000000181A0C2A0-0x0000000181A0C3E0
}

