/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioParameterTrigger : ManagedBehaviour // TypeDefIndex: 13703
{
	// Fields
	[Header] // 0x00000001800F5C40-0x00000001800F5C70
	public FeralEmitterGameEvent triggerEvent; // 0x50
	public string collisionTag; // 0x58
	[Header] // 0x00000001800F5F00-0x00000001800F5F30
	public FeralAudioEmitter emitter; // 0x60
	public ParamRef[] Parameters; // 0x68
	[Header] // 0x00000001800F6110-0x00000001800F6190
	[RootSelector] // 0x00000001800F6110-0x00000001800F6190
	public string questId; // 0x70
	public FeralAudioEmitter questCompletionEmitter; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ParamRef[] questCompletionParameters; // 0x80

	// Constructors
	public FeralAudioParameterTrigger(); // 0x00000001810FF270-0x00000001810FF2D0

	// Methods
	public override void MOnEnable(); // 0x00000001810FEEB0-0x00000001810FEEC0
	public override void MOnDisable(); // 0x00000001810FEEA0-0x00000001810FEEB0
	private void OnTriggerEnter(Collider other); // 0x00000001810FEF60-0x00000001810FEFC0
	private void OnTriggerExit(Collider other); // 0x00000001810FF020-0x00000001810FF080
	private void OnTriggerEnter2D(Collider2D other); // 0x00000001810FEF00-0x00000001810FEF60
	private void OnTriggerExit2D(Collider2D other); // 0x00000001810FEFC0-0x00000001810FF020
	private void OnCollisionEnter(); // 0x00000001810FEED0-0x00000001810FEEE0
	private void OnCollisionExit(); // 0x00000001810FEEF0-0x00000001810FEF00
	private void OnCollisionEnter2D(); // 0x00000001810FEEC0-0x00000001810FEED0
	private void OnCollisionExit2D(); // 0x00000001810FEEE0-0x00000001810FEEF0
	private void HandleGameEvent(FeralEmitterGameEvent gameEvent); // 0x00000001810FEE90-0x00000001810FEEA0
	private void TriggerParameter(); // 0x00000001810FF080-0x00000001810FF270
}

