/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioStats : ManagedBehaviour // TypeDefIndex: 11380
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
	private class StatsEntry // TypeDefIndex: 11381
	{
		// Fields
		public int index; // 0x10
		public float dspUsage; // 0x14
		public float studioUsage; // 0x18
		public int memoryAlloc; // 0x1C
		public int realChannels; // 0x20
		public int totalChannels; // 0x24

		// Constructors
		public StatsEntry(int tI, float dU, float sU, int mA, int rC, int tC); // 0x00000001806A68E0-0x00000001806A6940

		// Methods
		public string GetStats(); // 0x00000001806A5F20-0x00000001806A68E0
	}

	// Constructors
	public FeralAudioStats(); // 0x0000000180695DA0-0x0000000180695E00

	// Methods
	public override void MStart(); // 0x0000000180695C70-0x0000000180695CE0
	public override void MUpdate(); // 0x0000000180695CE0-0x0000000180695DA0
	public void LogStatEntries(); // 0x0000000180695B20-0x0000000180695C70
	private void UpdateStats(); // 0x00000001803774A0-0x00000001803774B0
	private void DrawStats(StatsEntry entry); // 0x0000000180695980-0x0000000180695B20
}

