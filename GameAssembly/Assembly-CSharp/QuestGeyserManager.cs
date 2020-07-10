/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestGeyserManager : MonoBehaviour // TypeDefIndex: 11662
{
	// Fields
	public GraphOwner respawnGraphOwner; // 0x20
	public QuestGeyserTimedSequence[] timedSequences; // 0x28
	public GameObject randomGeysersParent; // 0x30
	private QuestGeyser[] _randomGeysers; // 0x38
	public GameObject alwaysOnGeysersParent; // 0x40
	private QuestGeyser[] _alwaysOnGeysers; // 0x48
	public float randomTimeOnMin; // 0x50
	public float randomTimeOffMin; // 0x54
	public float randomTimeOnMax; // 0x58
	public float randomTimeOffMax; // 0x5C
	public FeralAudioEmitter impactAudio; // 0x60
	private static bool _respawning; // 0x00
	private bool _controlsEnabled; // 0x68
	private bool _active; // 0x69
	internal static QuestGeyserManager instance; // 0x08

	// Nested types
	[Serializable]
	public class QuestGeyserCollection // TypeDefIndex: 11663
	{
		// Fields
		public GameObject geysersParent; // 0x10
		internal QuestGeyser[] geysers; // 0x18

		// Constructors
		public QuestGeyserCollection(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void Init(); // 0x0000000181005BB0-0x0000000181005C70
	}

	[Serializable]
	public class QuestGeyserTimedSequence // TypeDefIndex: 11664
	{
		// Fields
		public float geysersOnTime; // 0x10
		public float geysersSwitchTime; // 0x14
		public float geyserOffTime; // 0x18
		public QuestGeyserCollection[] timedGeysers; // 0x20
		private int _collectionIndex; // 0x28
		private float _geysersOnTime; // 0x2C
		private float _geysersSwitchTime; // 0x30
		private float _geyserOffTime; // 0x34

		// Constructors
		public QuestGeyserTimedSequence(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void InitSequence(); // 0x0000000181006640-0x0000000181006790
		internal void UpdateSequence(float inDeltaTime); // 0x0000000181006790-0x0000000181006C60
	}

	// Constructors
	public QuestGeyserManager(); // 0x0000000181006610-0x0000000181006640

	// Methods
	private void Awake(); // 0x0000000181005D40-0x0000000181005D80
	private void Start(); // 0x0000000181005DC0-0x0000000181006150
	public void Activate(); // 0x0000000181005C70-0x0000000181005D40
	private void Update(); // 0x00000001810062E0-0x0000000181006610
	internal void TrapPlayer(); // 0x0000000181006150-0x00000001810062E0
	public void RespawnFinished(); // 0x0000000181005D80-0x0000000181005DC0
	private void OnDrawGizmosSelected(); // 0x00000001803581E0-0x00000001803581F0
}

