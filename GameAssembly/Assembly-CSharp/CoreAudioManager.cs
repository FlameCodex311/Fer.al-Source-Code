/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x0000000180155590-0x00000001801555C0
public class CoreAudioManager : CoreManagerBase<CoreAudioManager> // TypeDefIndex: 13431
{
	// Fields
	public float sceneTransitionTime; // 0x60
	public AnimationCurve sceneTransitionCurve; // 0x68
	private AudioListener _listener; // 0x70
	private float _musicVolume; // 0x78
	private float _soundVolume; // 0x7C
	private float _sceneTransitionCur; // 0x80

	// Properties
	public float MusicVolume { get; set; } // 0x0000000181411C20-0x0000000181411C30 0x0000000181474940-0x0000000181474A30
	public float SoundVolume { get; set; } // 0x0000000181411C30-0x0000000181411C40 0x0000000181474A30-0x0000000181474B20

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__19 : IEnumerator<object> // TypeDefIndex: 13432
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814817D0-0x00000001814819B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814819B0-0x0000000181481A00
	}

	// Constructors
	public CoreAudioManager(); // 0x00000001814748D0-0x0000000181474940

	// Methods
	private void OnApplicationFocus(bool inFocus); // 0x0000000181474490-0x00000001814744D0
	public static void PauseMusic(); // 0x00000001803581E0-0x00000001803581F0
	public static void ResumeMusic(); // 0x00000001803581E0-0x00000001803581F0
	public static void StopMusic(); // 0x00000001803581E0-0x00000001803581F0
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	public virtual void SoundVolumeChanged(float inVolume); // 0x00000001803581E0-0x00000001803581F0
	public virtual void MusicVolumeChanged(float inVolume); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x0000000180156AF0-0x0000000180156B40
	public override IEnumerator InitCoroutine(); // 0x0000000181473FF0-0x0000000181474050
	public override void MOnDestroy(); // 0x0000000181474050-0x00000001814741B0
	public override void MUpdate(); // 0x00000001814741B0-0x0000000181474490
	private void OnLevelLoaded(Message inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLoadingStarted(Message inMessage); // 0x00000001814747D0-0x0000000181474800
	private void OnLoadingFinished(Message inMessage); // 0x00000001814744D0-0x00000001814747D0
	protected float VolumeInDb(float inValue); // 0x0000000180DD1F20-0x0000000180DD1F30
	private void UpdateSceneTransition(); // 0x0000000181474800-0x00000001814748D0
}

