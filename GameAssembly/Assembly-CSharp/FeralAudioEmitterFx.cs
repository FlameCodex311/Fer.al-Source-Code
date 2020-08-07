/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801CE8E0-0x00000001801CE910
public class FeralAudioEmitterFx : FeralAudioEmitter // TypeDefIndex: 11371
{
	// Fields
	private ParticleSystem _particleSystem; // 0x70
	private bool? _emitting; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _playOnPlayer; // 0x7A

	// Constructors
	public FeralAudioEmitterFx(); // 0x0000000180E388A0-0x0000000180E38900

	// Methods
	public override void MStart(); // 0x0000000180E384C0-0x0000000180E38530
	public void ParticleSystemStopped(); // 0x0000000180E38650-0x0000000180E386C0
	public void ParticleSystemStarted(); // 0x0000000180E385E0-0x0000000180E38650
	public void OnParticleCollision(GameObject other); // 0x0000000180E38560-0x0000000180E385E0
	public override void MUpdate(); // 0x0000000180E38530-0x0000000180E38560
	public override void MOnDisable(); // 0x0000000180E38480-0x0000000180E384C0
	public override void MOnDestroy(); // 0x0000000180E38440-0x0000000180E38480
	private void UpdateParticleSystem(bool inDisable = false /* Metadata: 0x0077CA82 */); // 0x0000000180E386C0-0x0000000180E388A0
}

