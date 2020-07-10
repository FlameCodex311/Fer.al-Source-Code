/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F4A00-0x00000001800F4A30
public class FeralAudioBehaviour : ManagedBehaviour // TypeDefIndex: 10067
{
	// Fields
	private Rigidbody _cachedRigidbody; // 0x50
	private List<string> _cachedSustained; // 0x58
	private List<Info> _cachedSustainedInfos; // 0x60
	private List<string> _cachedOneShots; // 0x68

	// Nested types
	[Serializable]
	public class Info // TypeDefIndex: 10068
	{
		// Fields
		public EventInstance instance; // 0x10
		public EventDescription description; // 0x18

		// Constructors
		public Info(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForFeralAudioManager>d__5 : IEnumerator<object> // TypeDefIndex: 10069
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForFeralAudioManager>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811156E0-0x0000000181115780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181115780-0x00000001811157D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 10070
	{
		// Fields
		public FeralAudioInfo inAudioInfo; // 0x10
		public FeralAudioBehaviour <>4__this; // 0x18
		public string inParameter; // 0x20
		public float? inValue; // 0x28
		public Action<bool> <>9__2; // 0x30

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Play>b__0(QRoutine c); // 0x0000000181115470-0x0000000181115550
		internal void <Play>b__2(bool cb); // 0x0000000181115550-0x0000000181115590
		internal void <Play>b__1(bool cb); // 0x0000000181115550-0x0000000181115590
	}

	// Constructors
	public FeralAudioBehaviour(); // 0x00000001814A8F90-0x00000001814A9050

	// Methods
	[IteratorStateMachine] // 0x0000000180142E80-0x0000000180142ED0
	private IEnumerator WaitForFeralAudioManager(); // 0x00000001814A8F40-0x00000001814A8F90
	public void Play(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x00000001814A86E0-0x00000001814A89E0
	private void UpdateSustained(Info inInfo, FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x00000001814A8EB0-0x00000001814A8F40
	private void SetParameter(EventInstance inInstance, string inParameter = null, float? inValue = default); // 0x00000001814A8B00-0x00000001814A8B80
	private void Set3D(EventInstance inInstance, FeralAudioInfo inAudioInfo); // 0x00000001814A89E0-0x00000001814A8B00
	private void PlayOneShot(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x00000001814A84C0-0x00000001814A86E0
	private void CreateInstance(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x00000001814A7D50-0x00000001814A7E40
	private void CreateSustained(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x00000001814A7E40-0x00000001814A7FF0
	public void Stop(FeralAudioInfo inAudioInfo = null); // 0x00000001814A8B80-0x00000001814A8EB0
	public void Kill(FeralAudioInfo inAudioInfo = null); // 0x00000001814A80D0-0x00000001814A8440
	private Info GetInfo(string inEventRef); // 0x00000001814A7FF0-0x00000001814A80A0
	private Info GetInfo(FeralAudioInfo inAudioInfo); // 0x00000001814A80A0-0x00000001814A80D0
	public override void MOnDisable(); // 0x000000018036B6C0-0x000000018036B6D0
	public override void MOnDestroy(); // 0x00000001814A8440-0x00000001814A84C0
}

