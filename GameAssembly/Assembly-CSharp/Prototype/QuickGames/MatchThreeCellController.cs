/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class MatchThreeCellController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 16167
	{
		// Fields
		public List<Sprite> standardSprites; // 0x20
		public List<Sprite> specialSprites; // 0x28
		public List<Sprite> selectedStandardSprites; // 0x30
		public List<Sprite> selectedSpecialSprites; // 0x38
		public List<Sprite> keySprites; // 0x40
		public List<Sprite> selectedKeySprites; // 0x48
		public List<Sprite> typeSprites; // 0x50
		private List<Sprite> allSprites; // 0x58
		private List<Sprite> selectedSprites; // 0x60
		private Sprite selectedSprite; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Type>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Generation>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsRare>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsMatched>k__BackingField; // 0x79
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsSpecial>k__BackingField; // 0x7A
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsKey>k__BackingField; // 0x7B
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsUnlocked>k__BackingField; // 0x7C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <KeyType>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <X>k__BackingField; // 0x84
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Y>k__BackingField; // 0x88
		private int rareType; // 0x8C
		private GameObject glow; // 0x90
		private Image glowImage; // 0x98
		private Image contents; // 0xA0
		private Image keyImage; // 0xA8
		private GameObject hint; // 0xB0
		private RectTransform hintRectTransform; // 0xB8
		private Image hintImage; // 0xC0
		private bool showHint; // 0xC8
		private bool glimmerPlaying; // 0xC9
		private GameObject glimmer; // 0xD0
		private RectTransform glimmerRectTransform; // 0xD8
		private Image glimmerImage; // 0xE0
		private Vector2 glimmerOrigin; // 0xE8
		private Vector2 glimmerDestination; // 0xF0
		private float glimmerTime; // 0xF8
		private float elapsedTime; // 0xFC
		private float normalizedTime; // 0x100
		private MatchThree parentController; // 0x108
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EKeyState <KeyState>k__BackingField; // 0x110
		private bool _oldIsMatched; // 0x114
		private Vector3 hintRotation; // 0x118
		private bool collecting; // 0x124
		private Vector2 keyPosA; // 0x128
		private Vector2 keyPosB; // 0x130
		private float collectionTime; // 0x138
		private float elapsedCollectionTime; // 0x13C
		private float normalizedCollectionTime; // 0x140
		private RectTransform keyRectTransform; // 0x148
	
		// Properties
		public int Type { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAD00-0x00000001803DAD10 0x00000001803DAEA0-0x00000001803DAEB0
		public int Generation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAD10-0x00000001803DAD20 0x00000001803DAEB0-0x00000001803DAEC0
		public bool IsRare { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000180933270-0x0000000180933280
		public bool IsMatched { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A24F0-0x00000001804A2500 0x00000001806CFBE0-0x00000001806CFBF0
		public bool IsSpecial { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2550-0x00000001804A2560 0x00000001809337F0-0x0000000180933800
		public bool IsKey { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2530-0x00000001804A2540 0x0000000180933800-0x0000000180933810
		public bool IsUnlocked { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DADB0-0x00000001803DADC0 0x00000001804A25C0-0x00000001804A25D0
		public int KeyType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804241F0-0x0000000180424200 0x0000000180423A40-0x0000000180423A50
		public int X { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180424210-0x0000000180424220 0x00000001804A25A0-0x00000001804A25B0
		public int Y { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018049D3B0-0x000000018049D3C0 0x000000018049D3C0-0x000000018049D3D0
		public EKeyState KeyState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810C9900-0x00000001810C9910 0x00000001813F3BC0-0x00000001813F3BD0
	
		// Nested types
		public enum EKeyState // TypeDefIndex: 16168
		{
			LOCKED = 0,
			LOCKED_NEXT_TARGET = 1,
			OPENED = 2,
			COLLECTING = 3,
			COLLECTED = 4
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Glimmer>d__85 : IEnumerator<object> // TypeDefIndex: 16169
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Glimmer>d__85(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FB8A0-0x00000001813FBA50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FBA50-0x00000001813FBAA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateGlimmer>d__86 : IEnumerator<object> // TypeDefIndex: 16170
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateGlimmer>d__86(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9190-0x00000001813F9310
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F9310-0x00000001813F9360
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateHint>d__95 : IEnumerator<object> // TypeDefIndex: 16171
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateHint>d__95(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9360-0x00000001813F93F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F93F0-0x00000001813F9440
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MoveKey>d__104 : IEnumerator<object> // TypeDefIndex: 16172
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MoveKey>d__104(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FBDD0-0x00000001813FBFB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FBFB0-0x00000001813FC000
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateKeyMovement>d__105 : IEnumerator<object> // TypeDefIndex: 16173
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateKeyMovement>d__105(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9440-0x00000001813F95C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F95C0-0x00000001813F9610
		}
	
		// Constructors
		public MatchThreeCellController(); // 0x00000001813F3B90-0x00000001813F3BC0
	
		// Methods
		private void Awake(); // 0x00000001813F2A30-0x00000001813F2DB0
		public void SetUp(int type, int x, int y, MatchThree parent); // 0x00000001813F3770-0x00000001813F37C0
		private void SetController(MatchThree matchThree); // 0x00000001803BE5E0-0x00000001803BE5F0
		private void SetType(int value); // 0x00000001813F3350-0x00000001813F3770
		public void OnPointerDown(PointerEventData pointerEventData); // 0x00000001813F3280-0x00000001813F32E0
		public void OnPointerUp(PointerEventData pointerEventData); // 0x00000001813F32E0-0x00000001813F3310
		public bool Matches(MatchThreeCellController other); // 0x00000001813F3200-0x00000001813F3220
		public void MatchPreCheck(); // 0x00000001813F31F0-0x00000001813F3200
		public void SetMatch(bool status, int generation); // 0x00000001813F3310-0x00000001813F3350
		public void GlimmerIfChanged(); // 0x00000001813F2F90-0x00000001813F3010
		[IteratorStateMachine] // 0x0000000180139B00-0x0000000180139B50
		private IEnumerator Glimmer(); // 0x00000001813F3010-0x00000001813F3070
		[IteratorStateMachine] // 0x0000000180139CD0-0x0000000180139D20
		private IEnumerator AnimateGlimmer(); // 0x00000001813F2910-0x00000001813F2970
		private void MakeSpecial(); // 0x00000001813F3130-0x00000001813F31F0
		public void MakeKey(); // 0x00000001813F3100-0x00000001813F3130
		public void MakeKeyDependent(); // 0x00000001813F3070-0x00000001813F3100
		public void UpdateKeyState(bool previousKeyState, bool state); // 0x00000001813F37F0-0x00000001813F3B90
		public void UpdateDependentKeyState(EKeyState rootState); // 0x00000001803581E0-0x00000001803581F0
		private void GiveHint(); // 0x00000001813F2ED0-0x00000001813F2F90
		private void StopHint(); // 0x00000001813F37C0-0x00000001813F37F0
		[IteratorStateMachine] // 0x0000000180139F60-0x0000000180139FB0
		private IEnumerator AnimateHint(); // 0x00000001813F2970-0x00000001813F29D0
		public void CollectKey(GameObject keySlot); // 0x00000001813F2DB0-0x00000001813F2ED0
		[IteratorStateMachine] // 0x000000018013A0A0-0x000000018013A0F0
		private IEnumerator MoveKey(); // 0x00000001813F3220-0x00000001813F3280
		[IteratorStateMachine] // 0x000000018013A290-0x000000018013A2E0
		private IEnumerator AnimateKeyMovement(); // 0x00000001813F29D0-0x00000001813F2A30
	}
}
