/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestGeyser : MonoBehaviour // TypeDefIndex: 13187
{
	// Fields
	public ParticleSystem mainParticleFX; // 0x20
	private QuestGeyserManager _manager; // 0x28
	public Collider triggerCollider; // 0x30
	private float _randomTimeOn; // 0x38
	private float _randomTimeOff; // 0x3C

	// Constructors
	public QuestGeyser(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnDrawGizmosSelected(); // 0x000000018064A970-0x000000018064AA40
	internal void UpdateGeyserTime(float inDeltaTime); // 0x000000018064AA60-0x000000018064AB70
	internal void InitGeyser(); // 0x000000018064A890-0x000000018064A970
	private void OnTriggerEnter(Collider other); // 0x000000018064AA40-0x000000018064AA60
	internal void Activate(); // 0x000000018064A800-0x000000018064A840
	internal void Deactivate(); // 0x000000018064A840-0x000000018064A890
}

