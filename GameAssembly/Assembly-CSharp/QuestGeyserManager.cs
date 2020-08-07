/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestGeyserManager : MonoBehaviour // TypeDefIndex: 13188
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
	public class QuestGeyserCollection // TypeDefIndex: 13189
	{
		// Fields
		public GameObject geysersParent; // 0x10
		internal QuestGeyser[] geysers; // 0x18

		// Constructors
		public QuestGeyserCollection(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void Init(); // 0x0000000180649830-0x00000001806498E0
	}

	[Serializable]
	public class QuestGeyserTimedSequence // TypeDefIndex: 13190
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
		public QuestGeyserTimedSequence(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void InitSequence(); // 0x000000018064A230-0x000000018064A370
		internal void UpdateSequence(float inDeltaTime); // 0x000000018064A370-0x000000018064A800
	}

	// Constructors
	public QuestGeyserManager(); // 0x000000018064A200-0x000000018064A230

	// Methods
	private void Awake(); // 0x0000000180649990-0x00000001806499D0
	private void Start(); // 0x0000000180649A10-0x0000000180649D70
	public void Activate(); // 0x00000001806498E0-0x0000000180649990
	private void Update(); // 0x0000000180649EE0-0x000000018064A200
	internal void TrapPlayer(); // 0x0000000180649D70-0x0000000180649EE0
	public void RespawnFinished(); // 0x00000001806499D0-0x0000000180649A10
	private void OnDrawGizmosSelected(); // 0x00000001803774A0-0x00000001803774B0
}

