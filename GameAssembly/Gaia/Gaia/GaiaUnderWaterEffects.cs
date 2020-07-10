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

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[RequireComponent] // 0x00000001800C1C40-0x00000001800C1C90
	public class GaiaUnderWaterEffects : UnityEngine.MonoBehaviour // TypeDefIndex: 8996
	{
		// Fields
		[Header] // 0x00000001800C1D70-0x00000001800C1DA0
		public GaiaConstants.EnvironmentRenderer m_currentRenderer; // 0x18
		[Header] // 0x00000001800C1F90-0x00000001800C1FF0
		[Tooltip] // 0x00000001800C1F90-0x00000001800C1FF0
		public bool m_followPlayer; // 0x1C
		[Tooltip] // 0x00000001800C2180-0x00000001800C21B0
		public bool m_useHorizonFix; // 0x1D
		[Tooltip] // 0x00000001800C2280-0x00000001800C22B0
		public bool m_useUnderwaterparticles; // 0x1E
		[Range] // 0x00000001800C23E0-0x00000001800C2440
		[Tooltip] // 0x00000001800C23E0-0x00000001800C2440
		public int m_causticsSize; // 0x20
		[Tooltip] // 0x00000001800C2490-0x00000001800C24C0
		public Texture[] m_cookies; // 0x28
		[Tooltip] // 0x00000001800C2570-0x00000001800C25A0
		public float m_framesPerSecond; // 0x30
		[Tooltip] // 0x00000001800C25D0-0x00000001800C2600
		public float m_sealevel; // 0x34
		[Header] // 0x00000001800C2800-0x00000001800C2880
		[Range] // 0x00000001800C2800-0x00000001800C2880
		[Tooltip] // 0x00000001800C2800-0x00000001800C2880
		public float m_underwaterSoundFXVolume; // 0x38
		[Range] // 0x00000001800C2B70-0x00000001800C2BC0
		[Tooltip] // 0x00000001800C2B70-0x00000001800C2BC0
		public float m_waterSubmergeSounfFXVolume; // 0x3C
		[Tooltip] // 0x00000001800C2DA0-0x00000001800C2DD0
		public AudioClip m_submergeSoundFXDown; // 0x40
		[Tooltip] // 0x00000001800C3020-0x00000001800C3050
		public AudioClip m_submergeSoundFXUp; // 0x48
		[Tooltip] // 0x00000001800C3220-0x00000001800C3250
		public Color32 m_underWaterFogColor; // 0x50
		[Tooltip] // 0x00000001800C3440-0x00000001800C3470
		public float m_underWaterFogDistance; // 0x54
		private Light mainlight; // 0x58
		private Transform causticsObject; // 0x60
		public Transform player; // 0x68
		private int indexNumber; // 0x70
		private bool coroutineStatus; // 0x74
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Color32 storedFogColor; // 0x78
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float storedFogDistance; // 0x7C
		private GameObject ambientAudio; // 0x80
		private GameObject underwaterAudio; // 0x88
		private GameObject horizonObject; // 0x90
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject horizonObjectStored; // 0x98
		private AudioSource objectAudioSource; // 0xA0
		private GameObject underwaterParticles; // 0xA8
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject underwaterParticlesStored; // 0xB0
		private Transform partentObject; // 0xB8
		private GaiaSettings m_gaiaSettings; // 0xC0
		private GaiaSceneInfo m_gaiaSceneInfo; // 0xC8
		public PostProcessVolume transitionPostFX; // 0xD0
		public PostProcessVolume underwaterPostFX; // 0xD8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CausticsAnimation>d__39 : IEnumerator<object> // TypeDefIndex: 8997
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GaiaUnderWaterEffects <>4__this; // 0x20
			public bool systemOn; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CausticsAnimation>d__39(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815A64B0-0x00000001815A6630
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815A6630-0x00000001815A6680
		}
	
		// Constructors
		public GaiaUnderWaterEffects(); // 0x0000000181599470-0x0000000181599520
	
		// Methods
		private void Start(); // 0x0000000181597FC0-0x00000001815989F0
		private void OnEnable(); // 0x0000000181597F10-0x0000000181597FC0
		public Transform GetThePlayer(); // 0x000000018035FCC0-0x000000018035FCD0
		private static GameObject GetOrCreateEnvironmentParent(); // 0x0000000181597E30-0x0000000181597EC0
		private void OnDisable(); // 0x0000000181597EC0-0x0000000181597F10
		private void Update(); // 0x00000001815989F0-0x0000000181599470
		[IteratorStateMachine] // 0x00000001800C3A80-0x00000001800C3AD0
		private IEnumerator CausticsAnimation(bool systemOn); // 0x0000000181597DC0-0x0000000181597E30
		public void LoadCaustics(); // 0x00000001803581E0-0x00000001803581F0
	}
}
