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

namespace Prototype.QuickGames
{
	public class LeadMoth : QuickGamesBase // TypeDefIndex: 14874
	{
		// Fields
		[Header] // 0x0000000180240C30-0x0000000180240C60
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
		[Header] // 0x00000001801D1640-0x00000001801D1670
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FlapWings>d__36 : IEnumerator<object> // TypeDefIndex: 14875
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FlapWings>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180992400-0x0000000180992800
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180992800-0x0000000180992850
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__38 : IEnumerator<object> // TypeDefIndex: 14876
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private float <delay>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180994B20-0x0000000180994F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994F40-0x0000000180994F90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ScaleEmber>d__39 : IEnumerator<object> // TypeDefIndex: 14877
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			public Transform inTrans; // 0x28
			public bool inUp; // 0x30
			private float <t>5__2; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ScaleEmber>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180993CF0-0x0000000180994000
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994000-0x0000000180994050
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ResetSpotlight>d__41 : IEnumerator<object> // TypeDefIndex: 14878
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ResetSpotlight>d__41(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180993350-0x00000001809934D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809934D0-0x0000000180993520
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__42 : IEnumerator<object> // TypeDefIndex: 14879
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LeadMoth <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__42(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180995D50-0x0000000180995F10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180995F10-0x0000000180995F60
		}
	
		// Constructors
		public LeadMoth(); // 0x0000000180985D20-0x0000000180985E50
	
		// Methods
		public override void MStart(); // 0x0000000180984ED0-0x0000000180984FD0
		[IteratorStateMachine] // 0x00000001802410E0-0x0000000180241130
		private IEnumerator FlapWings(); // 0x0000000180984B50-0x0000000180984BB0
		public override void QuickGameUpdate(); // 0x0000000180984FD0-0x0000000180985B80
		[IteratorStateMachine] // 0x00000001802413A0-0x00000001802413F0
		public override IEnumerator ShowIntro(); // 0x0000000180985C60-0x0000000180985CC0
		[IteratorStateMachine] // 0x0000000180241560-0x00000001802415B0
		private IEnumerator ScaleEmber(Transform inTrans, bool inUp); // 0x0000000180985BE0-0x0000000180985C60
		private Vector3 GetPlacmentPos(int inTries); // 0x0000000180984BB0-0x0000000180984ED0
		[IteratorStateMachine] // 0x00000001802418E0-0x0000000180241930
		private IEnumerator ResetSpotlight(); // 0x0000000180985B80-0x0000000180985BE0
		[IteratorStateMachine] // 0x0000000180241BF0-0x0000000180241C40
		public override IEnumerator ShowResults(); // 0x0000000180985CC0-0x0000000180985D20
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
