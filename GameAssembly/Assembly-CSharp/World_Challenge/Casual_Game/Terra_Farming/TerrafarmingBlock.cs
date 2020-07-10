/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingBlock : ManagedBehaviour // TypeDefIndex: 15638
	{
		// Fields
		[Header] // 0x000000018014B4A0-0x000000018014B4D0
		public Renderer faceRenderer; // 0x50
		public Renderer[] sideRenderers; // 0x58
		public CanvasGroup uiCanvasGroup; // 0x60
		public UnityEngine.UI.Text faceText; // 0x68
		public RawImage faceImage; // 0x70
		public float particleToScoreTime; // 0x78
		public float particleUpDist; // 0x7C
		internal bool isOccupied; // 0x80
		internal int blockColorIndex; // 0x84
		internal int rowIndex; // 0x88
		internal int columnIndex; // 0x8C
		internal int blockValue; // 0x90
		internal int gridBlockGroupIndex; // 0x94
		internal bool isCollector; // 0x98
		internal int pulseIndex; // 0x9C
		internal TerrafarmingBlock hoverBlock; // 0xA0
		internal TerrafarmingBlock gridBlock; // 0xA8
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		internal TerraFarming game; // 0xB0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PulseForScoring>d__20 : IEnumerator<object> // TypeDefIndex: 15639
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlock <>4__this; // 0x20
			public bool inPlayScoreBurst; // 0x28
			private float <td>5__2; // 0x2C
			private Vector3 <startScale>5__3; // 0x30
			private Vector3 <endScale>5__4; // 0x3C
			private Vector3 <particleUpStart>5__5; // 0x48
			private Vector3 <particleUpEnd>5__6; // 0x54
			private float <halfTime>5__7; // 0x60
			private ParticleSystem <fx_blockToScore>5__8; // 0x68
			private float <t>5__9; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PulseForScoring>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171BF80-0x000000018171C910
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171C910-0x000000018171C960
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PulseForCollecting>d__21 : IEnumerator<object> // TypeDefIndex: 15640
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlock <>4__this; // 0x20
			public TerrafarmingBlock inColloectorBlock; // 0x28
			private TerrafarmingBlock <blockCopy>5__2; // 0x30
			private float <halfTime>5__3; // 0x38
			private float <td>5__4; // 0x3C
			private Vector3 <startScale>5__5; // 0x40
			private Vector3 <endScale>5__6; // 0x4C
			private Vector3 <startPos>5__7; // 0x58
			private Vector3 <upPos>5__8; // 0x64
			private Vector3 <endPos>5__9; // 0x70
			private float <t>5__10; // 0x7C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PulseForCollecting>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171B1F0-0x000000018171BF30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171BF30-0x000000018171BF80
		}
	
		// Constructors
		public TerrafarmingBlock(); // 0x0000000181712FE0-0x00000001817130F0
	
		// Methods
		public override void MStart(); // 0x0000000181712D20-0x0000000181712D70
		internal void ReSetColor(Color inFaceColor, Color inSideColor, bool inClearFace); // 0x0000000181712E50-0x0000000181712FE0
		[IteratorStateMachine] // 0x000000018014B970-0x000000018014B9C0
		internal IEnumerator PulseForScoring(bool inPlayScoreBurst); // 0x0000000181712DE0-0x0000000181712E50
		[IteratorStateMachine] // 0x000000018014BD60-0x000000018014BDB0
		internal IEnumerator PulseForCollecting(TerrafarmingBlock inColloectorBlock); // 0x0000000181712D70-0x0000000181712DE0
	}
}
