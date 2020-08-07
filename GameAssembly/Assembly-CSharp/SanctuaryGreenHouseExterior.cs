/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryGreenHouseExterior : ManagedBehaviour // TypeDefIndex: 13268
{
	// Fields
	public Transform spawn; // 0x50
	public List<Transform> enterVolumes; // 0x58

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13269
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001807C3790-0x00000001807C37F0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnGreenhouseDoor>b__4_0(GameObject gObject); // 0x00000001807C24D0-0x00000001807C2520
	}

	// Constructors
	public SanctuaryGreenHouseExterior(); // 0x00000001807B04C0-0x00000001807B0520

	// Methods
	public void TeleportToSpawn(); // 0x00000001807B0300-0x00000001807B04C0
	public void Setup(BaseDef inBaseDef); // 0x00000001807AFCF0-0x00000001807B0060
	private void SpawnGreenhouseDoor(GameObject inGreenhouse, BaseDef inBaseDef); // 0x00000001807B0060-0x00000001807B0300
}

