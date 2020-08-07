/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAnimationEvent : ManagedBehaviour // TypeDefIndex: 11549
{
	// Fields
	private static string _feralAnimationEventInitializedVar; // 0x00
	private Animator _animator; // 0x50

	// Properties
	public static string feralAnimationEventInitializedVar { get; } // 0x0000000180E36B00-0x0000000180E36BC0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11550
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<GameObject> <>9__10_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3ADD0-0x0000000180E3AE30
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <PlayFx>b__10_0(GameObject gSpawned); // 0x00000001803774A0-0x00000001803774B0
	}

	// Constructors
	public FeralAnimationEvent(); // 0x0000000180E36AA0-0x0000000180E36B00
	static FeralAnimationEvent(); // 0x0000000180E36A60-0x0000000180E36AA0

	// Methods
	public override void MOnEnable(); // 0x0000000180E35E10-0x0000000180E36080
	private bool HasParameter(string inParameterName); // 0x0000000180E35CC0-0x0000000180E35E10
	public void FeralAnimationEvent_StringParameter(string inStringParameter); // 0x0000000180E35B50-0x0000000180E35CC0
	private void ResetSpawnState(FeralAnimationEvents.EventInfo inEventInfo); // 0x0000000180E367E0-0x0000000180E36A60
	public void PlayAudio(UnityEngine.Object inObject); // 0x0000000180E36080-0x0000000180E36200
	private void PlayAudio(FeralAnimationEvents.EventInfo inEventInfo); // 0x0000000180E36200-0x0000000180E36270
	private void PlayFx(FeralAnimationEvents.EventInfo inEventInfo); // 0x0000000180E36270-0x0000000180E367E0
}

