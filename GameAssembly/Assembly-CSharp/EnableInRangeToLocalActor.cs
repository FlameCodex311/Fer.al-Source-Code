/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class EnableInRangeToLocalActor : ManagedBehaviour // TypeDefIndex: 10409
{
	// Fields
	public float range; // 0x50
	public GameObject gameObjectReference; // 0x58
	public bool disableOffScreen; // 0x60
	private float? _rangeSq; // 0x64
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public ERangeState desiredRangeState; // 0x6C
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public ERangeState currentRangeState; // 0x70
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public EScreenState desiredScreenState; // 0x74
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public EScreenState currentScreenState; // 0x78

	// Properties
	public float rangeSq { get; } // 0x0000000181191E70-0x0000000181191EE0 

	// Nested types
	public enum ERangeState // TypeDefIndex: 10410
	{
		NONE = 0,
		OUTOFRANGE = 1,
		INRANGE = 2
	}

	public enum EScreenState // TypeDefIndex: 10411
	{
		NONE = 0,
		OFFSCREEN = 1,
		ONSCREEN = 2
	}

	// Constructors
	public EnableInRangeToLocalActor(); // 0x0000000181191E10-0x0000000181191E70

	// Methods
	public static void Setup(GameObject inParentGameObject, GameObject inGameObjectReference, float inRange, bool inDisableOffScreen); // 0x0000000181191D70-0x0000000181191E00
	public override void MOnEnable(); // 0x0000000181191C30-0x0000000181191CD0
	public override void MOnDisable(); // 0x0000000181191B90-0x0000000181191C30
	public void Setup(GameObject inGameObjectReference, float inRange, bool inDisableOffScreen); // 0x0000000181191E00-0x0000000181191E10
	private void OnDrawGizmosSelected(); // 0x0000000181191CD0-0x0000000181191D70
}

