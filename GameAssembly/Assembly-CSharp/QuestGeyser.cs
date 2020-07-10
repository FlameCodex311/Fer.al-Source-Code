/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestGeyser : MonoBehaviour // TypeDefIndex: 11661
{
	// Fields
	public ParticleSystem mainParticleFX; // 0x20
	private QuestGeyserManager _manager; // 0x28
	public Collider triggerCollider; // 0x30
	private float _randomTimeOn; // 0x38
	private float _randomTimeOff; // 0x3C

	// Constructors
	public QuestGeyser(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnDrawGizmosSelected(); // 0x0000000181006DE0-0x0000000181006EB0
	internal void UpdateGeyserTime(float inDeltaTime); // 0x0000000181006ED0-0x0000000181006FE0
	internal void InitGeyser(); // 0x0000000181006CF0-0x0000000181006DE0
	private void OnTriggerEnter(Collider other); // 0x0000000181006EB0-0x0000000181006ED0
	internal void Activate(); // 0x0000000181006C60-0x0000000181006CA0
	internal void Deactivate(); // 0x0000000181006CA0-0x0000000181006CF0
}

