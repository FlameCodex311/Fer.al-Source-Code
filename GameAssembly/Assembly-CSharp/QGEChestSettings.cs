/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QGEChestSettings : MonoBehaviour // TypeDefIndex: 13243
{
	// Fields
	[RootSelectorCompact] // 0x00000001801DDF20-0x00000001801DDF80
	public string chestSettingsDefId; // 0x20
	public bool debugChest; // 0x28
	public const int kMaxRingsPerLevel = 6; // Metadata: 0x007BA267
	private QGEChestDefComponent _chestSettingsDef; // 0x30

	// Properties
	public QGEChestDefComponent ChestSettings { get; } // 0x0000000180A2C650-0x0000000180A2C710 

	// Nested types
	public enum RingSize // TypeDefIndex: 13244
	{
		Disabled = -1,
		Expert = 0,
		Hard = 1,
		Medium = 2,
		Easy = 3
	}

	public enum RingSpeed // TypeDefIndex: 13245
	{
		Speed1 = 75,
		Speed2 = 90,
		Speed3 = 105,
		Speed4 = 120,
		Speed5 = 135,
		Speed6 = 150,
		Speed7 = 165,
		Speed8 = 180,
		Speed9 = 195,
		Speed10 = 210,
		Speed11 = 225
	}

	[Serializable]
	public class RingInfo // TypeDefIndex: 13246
	{
		// Fields
		[ChartEnum] // 0x00000001801DE0C0-0x00000001801DE110
		public RingSize ringSize; // 0x10
		[ChartEnum] // 0x00000001801DE2D0-0x00000001801DE320
		public RingSpeed ringSpeed; // 0x14

		// Constructors
		public RingInfo(); // 0x0000000180A3C0F0-0x0000000180A3C110
	}

	[Serializable]
	public class ChestLevel // TypeDefIndex: 13247
	{
		// Fields
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring1; // 0x10
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring2; // 0x18
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring3; // 0x20
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring4; // 0x28
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring5; // 0x30
		[ChartClassHorizontal] // 0x00000001801DE450-0x00000001801DE460
		public RingInfo ring6; // 0x38

		// Constructors
		public ChestLevel(); // 0x0000000180A2B670-0x0000000180A2B7B0
	}

	// Constructors
	public QGEChestSettings(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public int GetAvailalbeLockPickCount(); // 0x0000000180A2C2C0-0x0000000180A2C2F0
	public int GetLevelCount(); // 0x0000000180A2C350-0x0000000180A2C3B0
	public int GetChestTypeIndex(); // 0x0000000180A2C2F0-0x0000000180A2C350
	public RingInfo GetLevelRing(int inLevel, int inRing); // 0x0000000180A2C4D0-0x0000000180A2C650
	public int GetLevelRingCount(int inLevel); // 0x0000000180A2C3B0-0x0000000180A2C4D0
}

