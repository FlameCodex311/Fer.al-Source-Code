/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryGreenHousePlot : ManagedBehaviour // TypeDefIndex: 11739
{
	// Fields
	private DateTime? _timeToHarvest; // 0x50
	private Vector3 _startSize; // 0x60
	private Vector3 _endSize; // 0x6C
	private int? _growTime; // 0x78
	private GameObject _harvestable; // 0x80
	private GameObject _sprout; // 0x88
	private string _seedDefId; // 0x90
	private SanctuaryGreenHouseBox.EType _type; // 0x98
	private int _boxIndex; // 0x9C
	private int _plotIndex; // 0xA0
	private static Selected _selected; // 0x00

	// Nested types
	public class Selected // TypeDefIndex: 11740
	{
		// Fields
		public int boxIndex; // 0x10
		public int plotIndex; // 0x14

		// Constructors
		public Selected(); // 0x00000001805E3AF0-0x00000001805E3B00
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11741
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001812A0760-0x00000001812A07C0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Plant>b__18_0(GameObject gLoaded); // 0x00000001803581E0-0x00000001803581F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 11742
	{
		// Fields
		public SanctuaryGreenhouseSeedDefComponent cSanctuaryGreenhouseSeedDefComponent; // 0x10
		public SanctuaryGreenHousePlot <>4__this; // 0x18
		public BaseDef cBaseDef; // 0x20

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SpawnHarvestable>b__0(GameObject gLoaded); // 0x000000018129F9A0-0x000000018129FC00
	}

	// Constructors
	public SanctuaryGreenHousePlot(); // 0x0000000181288D80-0x0000000181288E60
	static SanctuaryGreenHousePlot(); // 0x0000000181288D20-0x0000000181288D80

	// Methods
	public static SanctuaryGreenHousePlot Create(Transform inParent, SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex); // 0x0000000181287580-0x0000000181287630
	public void Setup(SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex); // 0x00000001812888A0-0x00000001812888C0
	public override void MStart(); // 0x0000000181287810-0x00000001812878B0
	public override void MOnDestroy(); // 0x0000000181287770-0x0000000181287810
	private void OnGUI(); // 0x0000000181287AE0-0x0000000181288350
	public override void MUpdate(); // 0x00000001812878B0-0x0000000181287AE0
	public void Plant(string inSeedDefId); // 0x0000000181288450-0x00000001812888A0
	private void SpawnHarvestable(); // 0x00000001812888C0-0x0000000181288D20
	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseWater inMessage); // 0x0000000181288350-0x0000000181288450
	public void Harvest(); // 0x0000000181287720-0x0000000181287730
	public double GetSecondsRemaining(); // 0x0000000181287630-0x0000000181287720
	public bool HasPlanted(); // 0x0000000181287730-0x0000000181287770
	public bool CanHarvest(); // 0x00000001812874D0-0x0000000181287540
	public bool CanPlant(); // 0x0000000181287540-0x0000000181287580
}

