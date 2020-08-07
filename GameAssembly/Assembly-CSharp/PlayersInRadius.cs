/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PlayersInRadius : MonoBehaviour // TypeDefIndex: 13182
{
	// Fields
	public int playersInRadius; // 0x20
	public int localPlayersInRadius; // 0x24
	public int networkPlayersInRadius; // 0x28
	public float checkRadius; // 0x2C
	private float checkTimer; // 0x30

	// Constructors
	public PlayersInRadius(); // 0x00000001804E53E0-0x00000001804E5400

	// Methods
	private void Start(); // 0x00000001803774A0-0x00000001803774B0
	private void Update(); // 0x00000001804E51B0-0x00000001804E53E0
	private void OnTriggerEnter(Collider other); // 0x00000001804E50B0-0x00000001804E5130
	private void OnTriggerExit(Collider other); // 0x00000001804E5130-0x00000001804E51B0
}

