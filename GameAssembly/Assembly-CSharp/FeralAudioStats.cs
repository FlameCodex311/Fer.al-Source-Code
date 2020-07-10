/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioStats : ManagedBehaviour // TypeDefIndex: 13707
{
	// Fields
	public UnityEngine.UI.Text dspCPUText; // 0x50
	public UnityEngine.UI.Text studioCPUText; // 0x58
	public UnityEngine.UI.Text memoryText; // 0x60
	public UnityEngine.UI.Text realChannelText; // 0x68
	public UnityEngine.UI.Text totalChannelText; // 0x70
	private float updateStatsTime; // 0x78
	private float elapsedWaitTime; // 0x7C
	private bool systemValid; // 0x80
	private List<StatsEntry> statsEntries; // 0x88

	// Nested types
	private class StatsEntry // TypeDefIndex: 13708
	{
		// Fields
		public int index; // 0x10
		public float dspUsage; // 0x14
		public float studioUsage; // 0x18
		public int memoryAlloc; // 0x1C
		public int realChannels; // 0x20
		public int totalChannels; // 0x24

		// Constructors
		public StatsEntry(int tI, float dU, float sU, int mA, int rC, int tC); // 0x0000000181110B90-0x0000000181110BF0

		// Methods
		public string GetStats(); // 0x0000000181110130-0x0000000181110B90
	}

	// Constructors
	public FeralAudioStats(); // 0x0000000181100650-0x00000001811006B0

	// Methods
	public override void MStart(); // 0x0000000181100520-0x0000000181100590
	public override void MUpdate(); // 0x0000000181100590-0x0000000181100650
	public void LogStatEntries(); // 0x00000001811003C0-0x0000000181100520
	private void UpdateStats(); // 0x00000001803581E0-0x00000001803581F0
	private void DrawStats(StatsEntry entry); // 0x0000000181100210-0x00000001811003C0
}

