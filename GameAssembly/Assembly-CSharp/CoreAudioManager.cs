/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001802378A0-0x00000001802378D0
public class CoreAudioManager : CoreManagerBase<CoreAudioManager> // TypeDefIndex: 11102
{
	// Fields
	public float sceneTransitionTime; // 0x60
	public AnimationCurve sceneTransitionCurve; // 0x68
	private AudioListener _listener; // 0x70
	private float _musicVolume; // 0x78
	private float _soundVolume; // 0x7C
	private float _sceneTransitionCur; // 0x80

	// Properties
	public float MusicVolume { get; set; } // 0x0000000180780010-0x0000000180780020 0x0000000180780030-0x0000000180780120
	public float SoundVolume { get; set; } // 0x0000000180780020-0x0000000180780030 0x0000000180780120-0x0000000180780210

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__19 : IEnumerator<object> // TypeDefIndex: 11103
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180786150-0x0000000180786330
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180786330-0x0000000180786380
	}

	// Constructors
	public CoreAudioManager(); // 0x000000018077FFA0-0x0000000180780010

	// Methods
	private void OnApplicationFocus(bool inFocus); // 0x000000018077FB60-0x000000018077FBA0
	public static void PauseMusic(); // 0x00000001803774A0-0x00000001803774B0
	public static void ResumeMusic(); // 0x00000001803774A0-0x00000001803774B0
	public static void StopMusic(); // 0x00000001803774A0-0x00000001803774B0
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	public virtual void SoundVolumeChanged(float inVolume); // 0x00000001803774A0-0x00000001803774B0
	public virtual void MusicVolumeChanged(float inVolume); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x0000000180237AD0-0x0000000180237B20
	public override IEnumerator InitCoroutine(); // 0x000000018077F6C0-0x000000018077F720
	public override void MOnDestroy(); // 0x000000018077F720-0x000000018077F880
	public override void MUpdate(); // 0x000000018077F880-0x000000018077FB60
	private void OnLevelLoaded(Message inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLoadingStarted(Message inMessage); // 0x000000018077FEA0-0x000000018077FED0
	private void OnLoadingFinished(Message inMessage); // 0x000000018077FBA0-0x000000018077FEA0
	protected float VolumeInDb(float inValue); // 0x000000018058C7E0-0x000000018058C7F0
	private void UpdateSceneTransition(); // 0x000000018077FED0-0x000000018077FFA0
}

