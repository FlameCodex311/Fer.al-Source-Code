/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAnimationEvent : ManagedBehaviour // TypeDefIndex: 10059
{
	// Fields
	private static string _feralAnimationEventInitializedVar; // 0x00
	private Animator _animator; // 0x50

	// Properties
	public static string feralAnimationEventInitializedVar { get; } // 0x00000001814A7890-0x00000001814A7950 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10060
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__10_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001814AB390-0x00000001814AB3F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <PlayFx>b__10_0(GameObject gSpawned); // 0x00000001803581E0-0x00000001803581F0
	}

	// Constructors
	public FeralAnimationEvent(); // 0x00000001814A7830-0x00000001814A7890
	static FeralAnimationEvent(); // 0x00000001814A77F0-0x00000001814A7830

	// Methods
	public override void MOnEnable(); // 0x00000001814A6B60-0x00000001814A6DE0
	private bool HasParameter(string inParameterName); // 0x00000001814A6A10-0x00000001814A6B60
	public void FeralAnimationEvent_StringParameter(string inStringParameter); // 0x00000001814A68A0-0x00000001814A6A10
	private void ResetSpawnState(FeralAnimationEvents.EventInfo inEventInfo); // 0x00000001814A7550-0x00000001814A77F0
	public void PlayAudio(UnityEngine.Object inObject); // 0x00000001814A6DE0-0x00000001814A6F60
	private void PlayAudio(FeralAnimationEvents.EventInfo inEventInfo); // 0x00000001814A6F60-0x00000001814A6FD0
	private void PlayFx(FeralAnimationEvents.EventInfo inEventInfo); // 0x00000001814A6FD0-0x00000001814A7550
}

