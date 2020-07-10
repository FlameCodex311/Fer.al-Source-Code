/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using World_Challenge;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.World_Puzzle
{
	public class RingStatuePuzzle : WorldPuzzle // TypeDefIndex: 15646
	{
		// Fields
		[Tooltip] // 0x0000000180151030-0x0000000180151060
		public int winState; // 0x70
		public CinemachineVirtualCamera virtualEndCam; // 0x78
		public float endFxTime; // 0x80
		public float endCamPanTime; // 0x84
		public float endCamReturnTime; // 0x88
		public float solvedFXInterval; // 0x8C
		public float eyeGlowTime; // 0x90
		public Color rightColor; // 0x94
		public Color wrongColor; // 0xA4
		private Color _startingColor; // 0xB4
		public float impulseIntensity; // 0xC4
		public CinemachineImpulseSource impulseSource; // 0xC8
		public NetworkedObjectInfo ringsNetworkedQuit; // 0xD0
		public NetworkedObjectInfo ringsNetworkedSolve; // 0xD8
		public NetworkedObjectInfo[] networkedRotateDirectionSelect; // 0xE0
		public NetworkedObjectInfo[] networkedRingSelect; // 0xE8
		public NetworkedObjectInfo[] networkedRings; // 0xF0
		public GameObject eyes; // 0xF8
		public Transform[] rings; // 0x100
		public Transform[] rotateControls; // 0x108
		public GameObject solvedFX; // 0x110
		public GameObject[] rotateFX; // 0x118
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject _ringAudioPrefab; // 0x120
		private ParticleSystem[] _rotateFX; // 0x128
		private bool _endPan; // 0x130
		private int _defaultLayerMask; // 0x134
		private readonly ERingState _ringState; // 0x138
		private int _activeRingIndex; // 0x13C
		private bool _dirLeft; // 0x140
		private Vector3 _rotateVal; // 0x144
		private Camera _camera; // 0x150
	
		// Nested types
		private enum ERingState // TypeDefIndex: 15647
		{
			WRONG = 0,
			RIGHT = 1,
			STARTING = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__44 : IEnumerator<object> // TypeDefIndex: 15648
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RingStatuePuzzle <>4__this; // 0x20
			public bool inWin; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__44(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F393A0-0x0000000181F39630
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39630-0x0000000181F39680
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GlowEyes>d__45 : IEnumerator<object> // TypeDefIndex: 15649
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public bool inActive; // 0x20
			public RingStatuePuzzle <>4__this; // 0x28
			private Color <startColor>5__2; // 0x30
			private Color <endColor>5__3; // 0x40
			private Renderer <cRenderer>5__4; // 0x50
			private float <t>5__5; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GlowEyes>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F35C70-0x0000000181F36040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F36040-0x0000000181F36090
		}
	
		// Constructors
		public RingStatuePuzzle(); // 0x0000000181F31F20-0x0000000181F32000
	
		// Methods
		public override void MStart(); // 0x0000000181F30BE0-0x0000000181F30F60
		private void NetworkInteract(string inUUID); // 0x0000000181F31260-0x0000000181F31270
		internal override void InitializePuzzle(); // 0x0000000181F30990-0x0000000181F30BD0
		private void WinChq(); // 0x0000000181F31DB0-0x0000000181F31F20
		private int getActiveRingWinState(); // 0x0000000181F32000-0x0000000181F32090
		internal void RotateRing(); // 0x0000000181F31A00-0x0000000181F31AC0
		internal void PlayPuzzleSolved(); // 0x0000000181F31390-0x0000000181F31570
		internal void ResetPuzzleSolved(); // 0x0000000181F31900-0x0000000181F31A00
		internal void PlayRingFX(int inIndex); // 0x0000000181F31570-0x0000000181F31890
		private void PlaySolvedFX(bool inActive); // 0x0000000181F31890-0x0000000181F31900
		internal override void StartPuzzle(bool inEndPan = false /* Metadata: 0x00784DE0 */); // 0x0000000181F31C40-0x0000000181F31C70
		private void PlayAudio(string inChildName); // 0x0000000181F31270-0x0000000181F31390
		[IteratorStateMachine] // 0x00000001801514E0-0x0000000180151530
		private IEnumerator ShowResults(bool inWin); // 0x0000000181F31B40-0x0000000181F31BB0
		[IteratorStateMachine] // 0x00000001801518D0-0x0000000180151920
		private IEnumerator GlowEyes(bool inActive); // 0x0000000181F30920-0x0000000181F30990
		public void LeftControlClicked(); // 0x0000000181F30BD0-0x0000000181F30BE0
		public void RightControlClicked(); // 0x0000000181F30BD0-0x0000000181F30BE0
		public void ExitClicked(); // 0x0000000181F30890-0x0000000181F30920
		public void SolveIt(); // 0x0000000181F31BB0-0x0000000181F31C40
		public override void MUpdate(); // 0x0000000181F30F60-0x0000000181F31260
		private void UpdateColor(int inIndex, ERingState inRingState); // 0x0000000181F31C70-0x0000000181F31DB0
		private void SetRing(int inIndex, bool inOff); // 0x0000000181F31AC0-0x0000000181F31B40
		private void ChangeRingIndex(int inOnIndex); // 0x0000000181F30750-0x0000000181F30890
	}
}
