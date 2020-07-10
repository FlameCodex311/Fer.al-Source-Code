/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PlayerBuildTimeLogger : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	public static PlayerBuildTimeLogger instance; // 0x00
	private const int timeBetweenLogs = 30; // Metadata: 0x00781C68
	private float lastLoggedTime; // 0x20

	// Constructors
	public PlayerBuildTimeLogger(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void OnRuntimeMethodLoad(); // 0x0000000181159D30-0x0000000181159E20
	public void Start(); // 0x0000000181159E20-0x0000000181159E50
	public void Update(); // 0x0000000181159E50-0x0000000181159E90
	private void Log(); // 0x0000000181159CA0-0x0000000181159D30
}

