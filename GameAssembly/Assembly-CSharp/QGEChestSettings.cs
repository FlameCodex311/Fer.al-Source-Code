/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QGEChestSettings : MonoBehaviour // TypeDefIndex: 11716
{
	// Fields
	[RootSelectorCompact] // 0x00000001801038C0-0x0000000180103920
	public string chestSettingsDefId; // 0x20
	public bool debugChest; // 0x28
	public const int kMaxRingsPerLevel = 6; // Metadata: 0x00782B59
	private QGEChestDefComponent _chestSettingsDef; // 0x30

	// Properties
	public QGEChestDefComponent ChestSettings { get; } // 0x00000001815EEA60-0x00000001815EEB20 

	// Nested types
	public enum RingSize // TypeDefIndex: 11717
	{
		Disabled = -1,
		Expert = 0,
		Hard = 1,
		Medium = 2,
		Easy = 3
	}

	public enum RingSpeed // TypeDefIndex: 11718
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
	public class RingInfo // TypeDefIndex: 11719
	{
		// Fields
		[ChartEnum] // 0x0000000180103B40-0x0000000180103B90
		public RingSize ringSize; // 0x10
		[ChartEnum] // 0x0000000180103D20-0x0000000180103D70
		public RingSpeed ringSpeed; // 0x14

		// Constructors
		public RingInfo(); // 0x00000001815FFD60-0x00000001815FFD80
	}

	[Serializable]
	public class ChestLevel // TypeDefIndex: 11720
	{
		// Fields
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring1; // 0x10
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring2; // 0x18
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring3; // 0x20
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring4; // 0x28
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring5; // 0x30
		[ChartClassHorizontal] // 0x00000001800B5960-0x00000001800B5970
		public RingInfo ring6; // 0x38

		// Constructors
		public ChestLevel(); // 0x00000001815EDA70-0x00000001815EDBB0
	}

	// Constructors
	public QGEChestSettings(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public int GetAvailalbeLockPickCount(); // 0x00000001815EE6B0-0x00000001815EE6E0
	public int GetLevelCount(); // 0x00000001815EE740-0x00000001815EE7A0
	public int GetChestTypeIndex(); // 0x00000001815EE6E0-0x00000001815EE740
	public RingInfo GetLevelRing(int inLevel, int inRing); // 0x00000001815EE8D0-0x00000001815EEA60
	public int GetLevelRingCount(int inLevel); // 0x00000001815EE7A0-0x00000001815EE8D0
}

