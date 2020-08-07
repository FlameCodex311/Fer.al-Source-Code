/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioParameterTrigger : ManagedBehaviour // TypeDefIndex: 11376
{
	// Fields
	[Header] // 0x0000000180296660-0x0000000180296690
	public FeralEmitterGameEvent triggerEvent; // 0x50
	public string collisionTag; // 0x58
	[Header] // 0x00000001801CDC60-0x00000001801CDC90
	public FeralAudioEmitter emitter; // 0x60
	public ParamRef[] Parameters; // 0x68
	[Header] // 0x00000001801CDE00-0x00000001801CDE80
	[RootSelector] // 0x00000001801CDE00-0x00000001801CDE80
	public string questId; // 0x70
	public FeralAudioEmitter questCompletionEmitter; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ParamRef[] questCompletionParameters; // 0x80

	// Constructors
	public FeralAudioParameterTrigger(); // 0x0000000180694A20-0x0000000180694A80

	// Methods
	public override void MOnEnable(); // 0x0000000180694660-0x0000000180694670
	public override void MOnDisable(); // 0x0000000180694650-0x0000000180694660
	private void OnTriggerEnter(Collider other); // 0x0000000180694710-0x0000000180694770
	private void OnTriggerExit(Collider other); // 0x00000001806947D0-0x0000000180694830
	private void OnTriggerEnter2D(Collider2D other); // 0x00000001806946B0-0x0000000180694710
	private void OnTriggerExit2D(Collider2D other); // 0x0000000180694770-0x00000001806947D0
	private void OnCollisionEnter(); // 0x0000000180694680-0x0000000180694690
	private void OnCollisionExit(); // 0x00000001806946A0-0x00000001806946B0
	private void OnCollisionEnter2D(); // 0x0000000180694670-0x0000000180694680
	private void OnCollisionExit2D(); // 0x0000000180694690-0x00000001806946A0
	private void HandleGameEvent(FeralEmitterGameEvent gameEvent); // 0x0000000180694640-0x0000000180694650
	private void TriggerParameter(); // 0x0000000180694830-0x0000000180694A20
}

