/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MothsAndFlamesBetSpot : MonoBehaviour // TypeDefIndex: 13070
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
	public MothsAndFlamesBetSpot(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	internal void Init(int inIndex); // 0x00000001812DE6E0-0x00000001812DE780
	private void OnMouseDown(); // 0x00000001812DE780-0x00000001812DE960
	private void OnTriggerEnter(Collider other); // 0x00000001812DE960-0x00000001812DEA20
	private void OnTriggerExit(Collider other); // 0x00000001812DEA20-0x00000001812DEAA0
}

