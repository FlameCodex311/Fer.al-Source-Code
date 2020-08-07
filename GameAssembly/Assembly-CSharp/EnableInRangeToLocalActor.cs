/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class EnableInRangeToLocalActor : ManagedBehaviour // TypeDefIndex: 11897
{
	// Fields
	public float range; // 0x50
	public GameObject gameObjectReference; // 0x58
	public bool disableOffScreen; // 0x60
	private float? _rangeSq; // 0x64
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public ERangeState desiredRangeState; // 0x6C
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public ERangeState currentRangeState; // 0x70
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public EScreenState desiredScreenState; // 0x74
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public EScreenState currentScreenState; // 0x78

	// Properties
	public float rangeSq { get; } // 0x000000018085EA20-0x000000018085EA90 

	// Nested types
	public enum ERangeState // TypeDefIndex: 11898
	{
		NONE = 0,
		OUTOFRANGE = 1,
		INRANGE = 2
	}

	public enum EScreenState // TypeDefIndex: 11899
	{
		NONE = 0,
		OFFSCREEN = 1,
		ONSCREEN = 2
	}

	// Constructors
	public EnableInRangeToLocalActor(); // 0x000000018085E9C0-0x000000018085EA20

	// Methods
	public static void Setup(GameObject inParentGameObject, GameObject inGameObjectReference, float inRange, bool inDisableOffScreen); // 0x000000018085E920-0x000000018085E9B0
	public override void MOnEnable(); // 0x000000018085E7F0-0x000000018085E880
	public override void MOnDisable(); // 0x000000018085E760-0x000000018085E7F0
	public void Setup(GameObject inGameObjectReference, float inRange, bool inDisableOffScreen); // 0x000000018085E9B0-0x000000018085E9C0
	private void OnDrawGizmosSelected(); // 0x000000018085E880-0x000000018085E920
}

