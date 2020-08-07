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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801CE8E0-0x00000001801CE910
public class FeralAudioBehaviour : ManagedBehaviour // TypeDefIndex: 11557
{
	// Fields
	private Rigidbody _cachedRigidbody; // 0x50
	private List<string> _cachedSustained; // 0x58
	private List<Info> _cachedSustainedInfos; // 0x60
	private List<string> _cachedOneShots; // 0x68
	private bool _hasTriggered; // 0x70

	// Nested types
	[Serializable]
	public class Info // TypeDefIndex: 11558
	{
		// Fields
		public EventInstance instance; // 0x10
		public EventDescription description; // 0x18

		// Constructors
		public Info(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForFeralAudioManager>d__6 : IEnumerator<object> // TypeDefIndex: 11559
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForFeralAudioManager>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180E3AF20-0x0000000180E3AFC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180E3AFC0-0x0000000180E3B010
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11560
	{
		// Fields
		public FeralAudioInfo inAudioInfo; // 0x10
		public FeralAudioBehaviour <>4__this; // 0x18
		public string inParameter; // 0x20
		public float? inValue; // 0x28
		public Action<bool> <>9__2; // 0x30

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Play>b__0(QRoutine c); // 0x0000000180E3AB90-0x0000000180E3AC70
		internal void <Play>b__2(bool cb); // 0x0000000180E3AC70-0x0000000180E3ACB0
		internal void <Play>b__1(bool cb); // 0x0000000180E3AC70-0x0000000180E3ACB0
	}

	// Constructors
	public FeralAudioBehaviour(); // 0x0000000180E38380-0x0000000180E38440

	// Methods
	[IteratorStateMachine] // 0x000000018021C850-0x000000018021C8A0
	private IEnumerator WaitForFeralAudioManager(); // 0x0000000180E38330-0x0000000180E38380
	public void Play(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x0000000180E37AD0-0x0000000180E37DF0
	private void UpdateSustained(Info inInfo, FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x0000000180E382B0-0x0000000180E38330
	private void SetParameter(EventInstance inInstance, string inParameter = null, float? inValue = default); // 0x0000000180E37F10-0x0000000180E37F90
	private void Set3D(EventInstance inInstance, FeralAudioInfo inAudioInfo); // 0x0000000180E37DF0-0x0000000180E37F10
	private void PlayOneShot(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x0000000180E37860-0x0000000180E37AD0
	private void CreateInstance(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x0000000180E36FB0-0x0000000180E37200
	private void CreateSustained(FeralAudioInfo inAudioInfo, string inParameter = null, float? inValue = default); // 0x0000000180E37200-0x0000000180E373B0
	public void Stop(FeralAudioInfo inAudioInfo = null); // 0x0000000180E37F90-0x0000000180E382B0
	public void Kill(FeralAudioInfo inAudioInfo = null); // 0x0000000180E37480-0x0000000180E377E0
	private Info GetInfo(string inEventRef); // 0x0000000180E373B0-0x0000000180E37460
	private Info GetInfo(FeralAudioInfo inAudioInfo); // 0x0000000180E37460-0x0000000180E37480
	public override void MOnDisable(); // 0x0000000180373240-0x0000000180373250
	public override void MOnDestroy(); // 0x0000000180E377E0-0x0000000180E37860
}

