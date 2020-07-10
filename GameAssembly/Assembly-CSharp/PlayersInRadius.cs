/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PlayersInRadius : MonoBehaviour // TypeDefIndex: 11657
{
	// Fields
	public int playersInRadius; // 0x20
	public int localPlayersInRadius; // 0x24
	public int networkPlayersInRadius; // 0x28
	public float checkRadius; // 0x2C
	private float checkTimer; // 0x30

	// Constructors
	public PlayersInRadius(); // 0x000000018115C120-0x000000018115C140

	// Methods
	private void Start(); // 0x00000001803581E0-0x00000001803581F0
	private void Update(); // 0x000000018115BEE0-0x000000018115C120
	private void OnTriggerEnter(Collider other); // 0x000000018115BDE0-0x000000018115BE60
	private void OnTriggerExit(Collider other); // 0x000000018115BE60-0x000000018115BEE0
}

