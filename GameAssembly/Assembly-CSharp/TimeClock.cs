/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TimeClock : ManagedBehaviour // TypeDefIndex: 12155
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _secondHandPivot; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _minuteHandPivot; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _hourHandPivot; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _dayHandPivot; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ERotator _secondHandRotator; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ERotator _minuteHandRotator; // 0x74
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ERotator _hourHandRotator; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ERotator _dayHandRotator; // 0x7C
	private Vector3 _initialEulerSecondHand; // 0x80
	private Vector3 _initialEulerMinuteHand; // 0x8C
	private Vector3 _initialEulerHourHand; // 0x98
	private Vector3 _initialEulerDayHand; // 0xA4

	// Nested types
	public enum ERotator // TypeDefIndex: 12156
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	// Constructors
	public TimeClock(); // 0x0000000180F8D860-0x0000000180F8D980

	// Methods
	public override void MStart(); // 0x0000000180F8D2F0-0x0000000180F8D550
	public override void MUpdate(); // 0x0000000180F8D550-0x0000000180F8D720
	private void SetRotation(Transform inTransform, ERotator inRotator, float inValue, Vector3 inInitialEuler); // 0x0000000180F8D720-0x0000000180F8D860
}

