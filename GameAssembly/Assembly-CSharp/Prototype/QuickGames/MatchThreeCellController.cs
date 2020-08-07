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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class MatchThreeCellController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 14909
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Type>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Generation>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsRare>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsMatched>k__BackingField; // 0x79
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsSpecial>k__BackingField; // 0x7A
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsKey>k__BackingField; // 0x7B
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsUnlocked>k__BackingField; // 0x7C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <KeyType>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <X>k__BackingField; // 0x84
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public int Type { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804B4700-0x00000001804B4710 0x00000001804B47E0-0x00000001804B47F0
		public int Generation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804428A0-0x00000001804428B0 0x00000001805CF180-0x00000001805CF190
		public bool IsRare { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000180453D10-0x0000000180453D20
		public bool IsMatched { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180968EF0-0x0000000180968F00 0x000000018098AFD0-0x000000018098AFE0
		public bool IsSpecial { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018098AFB0-0x000000018098AFC0 0x000000018098AFE0-0x000000018098AFF0
		public bool IsKey { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018098AFA0-0x000000018098AFB0 0x000000018098AFC0-0x000000018098AFD0
		public bool IsUnlocked { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806F4AB0-0x00000001806F4AC0 0x000000018098AFF0-0x000000018098B000
		public int KeyType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018082F980-0x000000018082F990 0x000000018082F210-0x000000018082F220
		public int X { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180779F60-0x0000000180779F70 0x0000000180779F70-0x0000000180779F80
		public int Y { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0
		public EKeyState KeyState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018078AA10-0x000000018078AA20 0x000000018078AC60-0x000000018078AC70
	
		// Nested types
		public enum EKeyState // TypeDefIndex: 14910
		{
			LOCKED = 0,
			LOCKED_NEXT_TARGET = 1,
			OPENED = 2,
			COLLECTING = 3,
			COLLECTED = 4
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Glimmer>d__85 : IEnumerator<object> // TypeDefIndex: 14911
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Glimmer>d__85(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180992850-0x0000000180992A00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180992A00-0x0000000180992A50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateGlimmer>d__86 : IEnumerator<object> // TypeDefIndex: 14912
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateGlimmer>d__86(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809904C0-0x0000000180990640
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180990640-0x0000000180990690
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateHint>d__95 : IEnumerator<object> // TypeDefIndex: 14913
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateHint>d__95(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990690-0x0000000180990720
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180990720-0x0000000180990770
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MoveKey>d__104 : IEnumerator<object> // TypeDefIndex: 14914
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MoveKey>d__104(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180992D70-0x0000000180992F50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180992F50-0x0000000180992FA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateKeyMovement>d__105 : IEnumerator<object> // TypeDefIndex: 14915
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThreeCellController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateKeyMovement>d__105(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990770-0x00000001809908F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809908F0-0x0000000180990940
		}
	
		// Constructors
		public MatchThreeCellController(); // 0x000000018098AF70-0x000000018098AFA0
	
		// Methods
		private void Awake(); // 0x0000000180989E50-0x000000018098A1C0
		public void SetUp(int type, int x, int y, MatchThree parent); // 0x000000018098AB60-0x000000018098ABB0
		private void SetController(MatchThree matchThree); // 0x00000001803B50D0-0x00000001803B50E0
		private void SetType(int value); // 0x000000018098A760-0x000000018098AB60
		public void OnPointerDown(PointerEventData pointerEventData); // 0x000000018098A690-0x000000018098A6F0
		public void OnPointerUp(PointerEventData pointerEventData); // 0x000000018098A6F0-0x000000018098A720
		public bool Matches(MatchThreeCellController other); // 0x000000018098A610-0x000000018098A630
		public void MatchPreCheck(); // 0x000000018098A600-0x000000018098A610
		public void SetMatch(bool status, int generation); // 0x000000018098A720-0x000000018098A760
		public void GlimmerIfChanged(); // 0x000000018098A3A0-0x000000018098A420
		[IteratorStateMachine] // 0x00000001802586B0-0x0000000180258700
		private IEnumerator Glimmer(); // 0x000000018098A420-0x000000018098A480
		[IteratorStateMachine] // 0x0000000180258A00-0x0000000180258A50
		private IEnumerator AnimateGlimmer(); // 0x0000000180989D30-0x0000000180989D90
		private void MakeSpecial(); // 0x000000018098A540-0x000000018098A600
		public void MakeKey(); // 0x000000018098A510-0x000000018098A540
		public void MakeKeyDependent(); // 0x000000018098A480-0x000000018098A510
		public void UpdateKeyState(bool previousKeyState, bool state); // 0x000000018098ABE0-0x000000018098AF70
		public void UpdateDependentKeyState(EKeyState rootState); // 0x00000001803774A0-0x00000001803774B0
		private void GiveHint(); // 0x000000018098A2E0-0x000000018098A3A0
		private void StopHint(); // 0x000000018098ABB0-0x000000018098ABE0
		[IteratorStateMachine] // 0x0000000180258CD0-0x0000000180258D20
		private IEnumerator AnimateHint(); // 0x0000000180989D90-0x0000000180989DF0
		public void CollectKey(GameObject keySlot); // 0x000000018098A1C0-0x000000018098A2E0
		[IteratorStateMachine] // 0x0000000180258F50-0x0000000180258FA0
		private IEnumerator MoveKey(); // 0x000000018098A630-0x000000018098A690
		[IteratorStateMachine] // 0x00000001802591D0-0x0000000180259220
		private IEnumerator AnimateKeyMovement(); // 0x0000000180989DF0-0x0000000180989E50
	}
}
