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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.World_Puzzle
{
	public class RingStatuePuzzle : WorldPuzzle // TypeDefIndex: 14677
	{
		// Fields
		[Tooltip] // 0x0000000180289B90-0x0000000180289BC0
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
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		private enum ERingState // TypeDefIndex: 14678
		{
			WRONG = 0,
			RIGHT = 1,
			STARTING = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__44 : IEnumerator<object> // TypeDefIndex: 14679
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RingStatuePuzzle <>4__this; // 0x20
			public bool inWin; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181986780-0x0000000181986A10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181986A10-0x0000000181986A60
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GlowEyes>d__45 : IEnumerator<object> // TypeDefIndex: 14680
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GlowEyes>d__45(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819828E0-0x0000000181982CA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181982CA0-0x0000000181982CF0
		}
	
		// Constructors
		public RingStatuePuzzle(); // 0x000000018197DE30-0x000000018197DF10
	
		// Methods
		public override void MStart(); // 0x000000018197CB70-0x000000018197CEE0
		private void NetworkInteract(string inUUID); // 0x000000018197D1D0-0x000000018197D1E0
		internal override void InitializePuzzle(); // 0x000000018197C930-0x000000018197CB60
		private void WinChq(); // 0x000000018197DCD0-0x000000018197DE30
		private int getActiveRingWinState(); // 0x000000018197DF10-0x000000018197DF90
		internal void RotateRing(); // 0x000000018197D940-0x000000018197D9F0
		internal void PlayPuzzleSolved(); // 0x000000018197D300-0x000000018197D4D0
		internal void ResetPuzzleSolved(); // 0x000000018197D840-0x000000018197D940
		internal void PlayRingFX(int inIndex); // 0x000000018197D4D0-0x000000018197D7D0
		private void PlaySolvedFX(bool inActive); // 0x000000018197D7D0-0x000000018197D840
		internal override void StartPuzzle(bool inEndPan = false /* Metadata: 0x007BAE67 */); // 0x000000018197DB60-0x000000018197DB90
		private void PlayAudio(string inChildName); // 0x000000018197D1E0-0x000000018197D300
		[IteratorStateMachine] // 0x0000000180289F50-0x0000000180289FA0
		private IEnumerator ShowResults(bool inWin); // 0x000000018197DA60-0x000000018197DAD0
		[IteratorStateMachine] // 0x000000018028A1E0-0x000000018028A230
		private IEnumerator GlowEyes(bool inActive); // 0x000000018197C8C0-0x000000018197C930
		public void LeftControlClicked(); // 0x000000018197CB60-0x000000018197CB70
		public void RightControlClicked(); // 0x000000018197CB60-0x000000018197CB70
		public void ExitClicked(); // 0x000000018197C830-0x000000018197C8C0
		public void SolveIt(); // 0x000000018197DAD0-0x000000018197DB60
		public override void MUpdate(); // 0x000000018197CEE0-0x000000018197D1D0
		private void UpdateColor(int inIndex, ERingState inRingState); // 0x000000018197DB90-0x000000018197DCD0
		private void SetRing(int inIndex, bool inOff); // 0x000000018197D9F0-0x000000018197DA60
		private void ChangeRingIndex(int inOnIndex); // 0x000000018197C700-0x000000018197C830
	}
}
