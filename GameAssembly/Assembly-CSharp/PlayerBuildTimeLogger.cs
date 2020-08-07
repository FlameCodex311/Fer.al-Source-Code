/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PlayerBuildTimeLogger : MonoBehaviour // TypeDefIndex: 11884
{
	// Fields
	public static PlayerBuildTimeLogger instance; // 0x00
	private const int timeBetweenLogs = 30; // Metadata: 0x007B9313
	private float lastLoggedTime; // 0x20

	// Constructors
	public PlayerBuildTimeLogger(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void OnRuntimeMethodLoad(); // 0x00000001804E2F90-0x00000001804E3080
	public void Start(); // 0x00000001804E3080-0x00000001804E30B0
	public void Update(); // 0x00000001804E30B0-0x00000001804E30F0
	private void Log(); // 0x00000001804E2F00-0x00000001804E2F90
}

