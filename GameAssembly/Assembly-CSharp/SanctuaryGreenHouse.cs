/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryGreenHouse : ManagedBehaviour // TypeDefIndex: 13262
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static SanctuaryGreenHouse <instance>k__BackingField; // 0x00
	public SanctuaryGreenHouseInterior interior; // 0x50
	public SanctuaryGreenHouseExterior exterior; // 0x58
	public bool insideGreenhouse; // 0x60
	public bool onGreenhouseIsland; // 0x61
	public GameObject _island; // 0x68
	public Transform _placementNode; // 0x70
	public Transform _blockerNode; // 0x78
	public Transform _bridgeNode; // 0x80

	// Properties
	public static SanctuaryGreenHouse instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001807B4930-0x00000001807B4970 0x00000001807B4970-0x00000001807B49B0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnGreenhouse>d__13 : IEnumerator<object> // TypeDefIndex: 13263
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefId; // 0x20
		public SanctuaryGreenHouse <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnGreenhouse>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807C0EE0-0x00000001807C1420
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807C1420-0x00000001807C1470
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 13264
	{
		// Fields
		public SanctuaryGreenHouse <>4__this; // 0x10
		public BaseDef inBaseDef; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnGreenhouseExterior>b__0(GameObject gObject); // 0x00000001807C2700-0x00000001807C27A0
	}

	// Constructors
	public SanctuaryGreenHouse(); // 0x00000001807B48D0-0x00000001807B4930

	// Methods
	public void Setup(string inDefId, GameObject inIsland); // 0x00000001807B4160-0x00000001807B4240
	[IteratorStateMachine] // 0x00000001801E3D50-0x00000001801E3DA0
	private IEnumerator SpawnGreenhouse(string inDefId); // 0x00000001807B4800-0x00000001807B4870
	private void SpawnGreenHouseTriggerVolume(); // 0x00000001807B4240-0x00000001807B4430
	private void SpawnGreenhouseInterior(BaseDef inBaseDef); // 0x00000001807B4610-0x00000001807B4800
	private void SpawnGreenhouseExterior(BaseDef inBaseDef); // 0x00000001807B4430-0x00000001807B4610
	public override void MStart(); // 0x00000001807B4010-0x00000001807B4120
	public override void MOnDestroy(); // 0x00000001807B3F00-0x00000001807B4010
	private void OnSanctuaryGreenhouseEntered(SanctuaryGreenhouseEntered inMessage); // 0x00000001807B4120-0x00000001807B4140
	private void OnSanctuaryGreenhouseIslandEntered(SanctuaryGreenhouseIslandEntered inMessage); // 0x00000001807B4140-0x00000001807B4160
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnGreenhouseInterior>b__15_0(GameObject gObject); // 0x00000001807B4870-0x00000001807B48D0
}

