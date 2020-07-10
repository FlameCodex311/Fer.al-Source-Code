/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F4A00-0x00000001800F4A30
public class FeralAudioEmitterFx : FeralAudioEmitter // TypeDefIndex: 13698
{
	// Fields
	private ParticleSystem _particleSystem; // 0x70
	private bool? _emitting; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _playOnPlayer; // 0x7A

	// Constructors
	public FeralAudioEmitterFx(); // 0x00000001810F96A0-0x00000001810F9700

	// Methods
	public override void MStart(); // 0x00000001810F92C0-0x00000001810F9330
	public void ParticleSystemStopped(); // 0x00000001810F9450-0x00000001810F94C0
	public void ParticleSystemStarted(); // 0x00000001810F93E0-0x00000001810F9450
	public void OnParticleCollision(GameObject other); // 0x00000001810F9360-0x00000001810F93E0
	public override void MUpdate(); // 0x00000001810F9330-0x00000001810F9360
	public override void MOnDisable(); // 0x00000001810F9280-0x00000001810F92C0
	public override void MOnDestroy(); // 0x00000001810F9240-0x00000001810F9280
	private void UpdateParticleSystem(bool inDisable = false /* Metadata: 0x00783FC3 */); // 0x00000001810F94C0-0x00000001810F96A0
}

