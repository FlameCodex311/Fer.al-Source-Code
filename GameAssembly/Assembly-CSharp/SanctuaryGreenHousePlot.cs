/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryGreenHousePlot : ManagedBehaviour // TypeDefIndex: 13272
{
	// Fields
	private DateTime? _timeToHarvest; // 0x50
	private Vector3 _startSize; // 0x60
	private Vector3 _endSize; // 0x6C
	private int? _growTime; // 0x78
	private GameObject _matured; // 0x80
	private GameObject _sapling; // 0x88
	private string _seedDefId; // 0x90
	public SanctuaryGreenHouseBox.EType type; // 0x98
	public int boxIndex; // 0x9C
	public int plotIndex; // 0xA0
	public static Selected selected; // 0x00

	// Nested types
	public class Selected // TypeDefIndex: 13273
	{
		// Fields
		public int boxIndex; // 0x10
		public int plotIndex; // 0x14

		// Constructors
		public Selected(); // 0x00000001807B85F0-0x00000001807B8600
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 13274
	{
		// Fields
		public SeedDefComponent cSanctuaryGreenhouseSeedDefComponent; // 0x10
		public SanctuaryGreenHousePlot <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Plant>b__0(GameObject gLoaded); // 0x00000001807C2890-0x00000001807C2A10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 13275
	{
		// Fields
		public SeedDefComponent cSanctuaryGreenhouseSeedDefComponent; // 0x10
		public SanctuaryGreenHousePlot <>4__this; // 0x18
		public BaseDef cBaseDef; // 0x20

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SpawnHarvestable>b__0(GameObject gLoaded); // 0x00000001807C2A70-0x00000001807C2C90
	}

	// Constructors
	public SanctuaryGreenHousePlot(); // 0x00000001807B3760-0x00000001807B3840
	static SanctuaryGreenHousePlot(); // 0x00000001807B3700-0x00000001807B3760

	// Methods
	public static SanctuaryGreenHousePlot Create(Transform inParent, SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex); // 0x00000001807B26C0-0x00000001807B27D0
	public void Setup(SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex); // 0x00000001807B3390-0x00000001807B33B0
	public override void MStart(); // 0x00000001807B2A10-0x00000001807B2AB0
	public override void MOnDestroy(); // 0x00000001807B2970-0x00000001807B2A10
	private void OnGUI(); // 0x00000001807B2BE0-0x00000001807B2ED0
	public override void MUpdate(); // 0x00000001807B2AB0-0x00000001807B2BE0
	public void Plant(string inSeedDefId); // 0x00000001807B2FD0-0x00000001807B3390
	private void SpawnHarvestable(); // 0x00000001807B33B0-0x00000001807B3700
	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseWater inMessage); // 0x00000001807B2ED0-0x00000001807B2FD0
	public void Harvest(); // 0x00000001807B28C0-0x00000001807B2930
	public double GetSecondsRemaining(); // 0x00000001807B27D0-0x00000001807B28C0
	public bool HasPlanted(); // 0x00000001807B2930-0x00000001807B2970
	public bool CanHarvest(); // 0x00000001807B2610-0x00000001807B2680
	public bool CanPlant(); // 0x00000001807B2680-0x00000001807B26C0
}

