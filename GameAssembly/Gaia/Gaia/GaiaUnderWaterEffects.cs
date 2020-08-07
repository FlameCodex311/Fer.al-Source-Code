/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[RequireComponent] // 0x0000000180221A60-0x0000000180221AB0
	public class GaiaUnderWaterEffects : UnityEngine.MonoBehaviour // TypeDefIndex: 9162
	{
		// Fields
		[Header] // 0x0000000180221C20-0x0000000180221C50
		public GaiaConstants.EnvironmentRenderer m_currentRenderer; // 0x18
		[Header] // 0x0000000180221DB0-0x0000000180221E10
		[Tooltip] // 0x0000000180221DB0-0x0000000180221E10
		public bool m_followPlayer; // 0x1C
		[Tooltip] // 0x0000000180222100-0x0000000180222130
		public bool m_useHorizonFix; // 0x1D
		[Tooltip] // 0x00000001802222C0-0x00000001802222F0
		public bool m_useUnderwaterparticles; // 0x1E
		[Range] // 0x00000001802225A0-0x0000000180222600
		[Tooltip] // 0x00000001802225A0-0x0000000180222600
		public int m_causticsSize; // 0x20
		[Tooltip] // 0x00000001802227E0-0x0000000180222810
		public Texture[] m_cookies; // 0x28
		[Tooltip] // 0x0000000180222950-0x0000000180222980
		public float m_framesPerSecond; // 0x30
		[Tooltip] // 0x0000000180222B60-0x0000000180222B90
		public float m_sealevel; // 0x34
		[Header] // 0x0000000180222CF0-0x0000000180222D70
		[Range] // 0x0000000180222CF0-0x0000000180222D70
		[Tooltip] // 0x0000000180222CF0-0x0000000180222D70
		public float m_underwaterSoundFXVolume; // 0x38
		[Range] // 0x00000001802230D0-0x0000000180223120
		[Tooltip] // 0x00000001802230D0-0x0000000180223120
		public float m_waterSubmergeSounfFXVolume; // 0x3C
		[Tooltip] // 0x0000000180223310-0x0000000180223340
		public AudioClip m_submergeSoundFXDown; // 0x40
		[Tooltip] // 0x0000000180223410-0x0000000180223440
		public AudioClip m_submergeSoundFXUp; // 0x48
		[Tooltip] // 0x0000000180223640-0x0000000180223670
		public Color32 m_underWaterFogColor; // 0x50
		[Tooltip] // 0x0000000180223770-0x00000001802237A0
		public float m_underWaterFogDistance; // 0x54
		private Light mainlight; // 0x58
		private Transform causticsObject; // 0x60
		public Transform player; // 0x68
		private int indexNumber; // 0x70
		private bool coroutineStatus; // 0x74
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Color32 storedFogColor; // 0x78
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float storedFogDistance; // 0x7C
		private GameObject ambientAudio; // 0x80
		private GameObject underwaterAudio; // 0x88
		private GameObject horizonObject; // 0x90
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject horizonObjectStored; // 0x98
		private AudioSource objectAudioSource; // 0xA0
		private GameObject underwaterParticles; // 0xA8
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject underwaterParticlesStored; // 0xB0
		private Transform partentObject; // 0xB8
		private GaiaSettings m_gaiaSettings; // 0xC0
		private GaiaSceneInfo m_gaiaSceneInfo; // 0xC8
		public PostProcessVolume transitionPostFX; // 0xD0
		public PostProcessVolume underwaterPostFX; // 0xD8
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CausticsAnimation>d__39 : IEnumerator<object> // TypeDefIndex: 9163
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GaiaUnderWaterEffects <>4__this; // 0x20
			public bool systemOn; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CausticsAnimation>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819A4510-0x00000001819A4680
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819A4680-0x00000001819A46D0
		}
	
		// Constructors
		public GaiaUnderWaterEffects(); // 0x000000018198D420-0x000000018198D4D0
	
		// Methods
		private void Start(); // 0x000000018198BFD0-0x000000018198C9D0
		private void OnEnable(); // 0x000000018198BF20-0x000000018198BFD0
		public Transform GetThePlayer(); // 0x000000018037DDC0-0x000000018037DDD0
		private static GameObject GetOrCreateEnvironmentParent(); // 0x000000018198BE40-0x000000018198BED0
		private void OnDisable(); // 0x000000018198BED0-0x000000018198BF20
		private void Update(); // 0x000000018198C9D0-0x000000018198D420
		[IteratorStateMachine] // 0x0000000180223D90-0x0000000180223DE0
		private IEnumerator CausticsAnimation(bool systemOn); // 0x000000018198BDD0-0x000000018198BE40
		public void LoadCaustics(); // 0x00000001803774A0-0x00000001803774B0
	}
}
