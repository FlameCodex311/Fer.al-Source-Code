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

namespace Prototype.QuickGames
{
	public class LeadMoth : QuickGamesBase // TypeDefIndex: 16132
	{
		// Fields
		[Header] // 0x000000018011F7A0-0x000000018011F7D0
		public Transform torch; // 0xF0
		public Transform spotLight; // 0xF8
		public Transform ember; // 0x100
		public Transform moth; // 0x108
		public Transform mothWingLeft; // 0x110
		public Transform mothWingRight; // 0x118
		public float mothNoticeEmberDistance; // 0x120
		public float mothPickupEmberDistance; // 0x124
		public float mothMinCursorDistance; // 0x128
		public float mothMidCursorDistance; // 0x12C
		public float mothMaxCursorDistance; // 0x130
		public float mothMoveSpeed; // 0x134
		public float flapRate; // 0x138
		public float flapRange; // 0x13C
		public float placementBuffer; // 0x140
		public float screenLimitX; // 0x144
		public float screenLimitY; // 0x148
		public float emberScaleTime; // 0x14C
		public int numEmbers; // 0x150
		public float spotlightSmooth; // 0x154
		public float maxSpotliteRotate; // 0x158
		public float maxSpotlightSpeed; // 0x15C
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x160
		private Quaternion _spotlightRotate; // 0x164
		private List<Vector3> _placedPositions; // 0x178
		private List<Transform> _placedEmbers; // 0x180
		private Vector2 _mothPostion; // 0x188
		private int _mothSiblingIndex; // 0x190
		private Vector3 _emberScale; // 0x194
		private bool _mothToEmber; // 0x1A0
		private int _mothEmberIndex; // 0x1A4
		private Vector3 _mothDir; // 0x1A8
		private float _mothMoveScaler; // 0x1B4
		private bool _isClicking; // 0x1B8
		private QuickGamesMoveCursor _cursorMover; // 0x1C0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FlapWings>d__36 : IEnumerator<object> // TypeDefIndex: 16133
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private bool <flipUp>5__2; // 0x28
			private Quaternion <flapRangeLeft>5__3; // 0x2C
			private Quaternion <flapRangeRight>5__4; // 0x3C
			private float <t>5__5; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FlapWings>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FB140-0x00000001813FB540
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FB540-0x00000001813FB590
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__38 : IEnumerator<object> // TypeDefIndex: 16134
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private float <delay>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FDBD0-0x00000001813FE000
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FE000-0x00000001813FE050
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ScaleEmber>d__39 : IEnumerator<object> // TypeDefIndex: 16135
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			public Transform inTrans; // 0x28
			public bool inUp; // 0x30
			private float <t>5__2; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ScaleEmber>d__39(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FCD70-0x00000001813FD090
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FD090-0x00000001813FD0E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ResetSpotlight>d__41 : IEnumerator<object> // TypeDefIndex: 16136
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ResetSpotlight>d__41(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FC3C0-0x00000001813FC540
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FC540-0x00000001813FC590
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__42 : IEnumerator<object> // TypeDefIndex: 16137
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__42(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FFB00-0x00000001813FFCD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FFCD0-0x00000001813FFD20
		}
	
		// Constructors
		public LeadMoth(); // 0x00000001813EE820-0x00000001813EE950
	
		// Methods
		public override void MStart(); // 0x00000001813ED9B0-0x00000001813EDAB0
		[IteratorStateMachine] // 0x000000018011FAF0-0x000000018011FB40
		private IEnumerator FlapWings(); // 0x00000001813ED630-0x00000001813ED690
		public override void QuickGameUpdate(); // 0x00000001813EDAB0-0x00000001813EE680
		[IteratorStateMachine] // 0x000000018011FD20-0x000000018011FD70
		public override IEnumerator ShowIntro(); // 0x00000001813EE760-0x00000001813EE7C0
		[IteratorStateMachine] // 0x000000018011FE70-0x000000018011FEC0
		private IEnumerator ScaleEmber(Transform inTrans, bool inUp); // 0x00000001813EE6E0-0x00000001813EE760
		private Vector3 GetPlacmentPos(int inTries); // 0x00000001813ED690-0x00000001813ED9B0
		[IteratorStateMachine] // 0x00000001801201B0-0x0000000180120200
		private IEnumerator ResetSpotlight(); // 0x00000001813EE680-0x00000001813EE6E0
		[IteratorStateMachine] // 0x00000001801204E0-0x0000000180120530
		public override IEnumerator ShowResults(); // 0x00000001813EE7C0-0x00000001813EE820
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
