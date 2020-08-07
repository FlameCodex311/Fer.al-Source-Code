/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MothsAndFlamesBetSpot : MonoBehaviour // TypeDefIndex: 10735
{
	// Fields
	public Transform selectedPositionLocator; // 0x20
	public GameObject LocationIndicator; // 0x28
	public GameObject circleGlowBlueFX; // 0x30
	public GameObject circleGlowOrangeFX; // 0x38
	internal Vector3 selectedPosition; // 0x40
	internal MothsAndFlamesGame.EBetTypes betType; // 0x4C
	private MothsAndFlamesToken _token; // 0x50
	private MothsAndFlamesGame _game; // 0x58
	private MothsAndFlamesBetSpotManager _betSpotManager; // 0x60

	// Constructors
	public MothsAndFlamesBetSpot(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	internal void Init(int inIndex); // 0x0000000180C11910-0x0000000180C119A0
	private void OnMouseDown(); // 0x0000000180C119A0-0x0000000180C119F0
	private void OnTriggerEnter(Collider other); // 0x0000000180C119F0-0x0000000180C11AA0
	private void OnTriggerExit(Collider other); // 0x0000000180C11AA0-0x0000000180C11B20
}

