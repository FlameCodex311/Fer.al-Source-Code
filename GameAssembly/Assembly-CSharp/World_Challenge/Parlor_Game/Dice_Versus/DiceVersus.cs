/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Parlor_Game;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game.Dice_Versus
{
	public class DiceVersus : ParlorGame // TypeDefIndex: 15578
	{
		// Fields
		[Header] // 0x0000000180127830-0x0000000180127860
		public DiceManager diceManager; // 0x80
		public Renderer partitionRenderer; // 0x88
		public Transform[] slotsPlayer; // 0x90
		public Transform[] slotsOpponent; // 0x98
		public MeshRenderer[] slotIndicatorMeshes; // 0xA0
		public float diceMoveMaxX; // 0xA8
		public float diceMoveMaxZ; // 0xAC
		public float partitionChangeTime; // 0xB0
		public float diceToLoseSpotTime; // 0xB4
		public float diceToSlotTime; // 0xB8
		private Dice[] _slotsDicePlayer; // 0xC0
		private Dice[] _slotsDiceOpponent; // 0xC8
		private Vector3 _selectedDicePos; // 0xD0
		private Vector3 _pointAlongPlane; // 0xDC
		private Ray _mouseScreenPointToRay; // 0xE8
		private Plane _touchPlane; // 0x100
		private float _distanceToTouchPlane; // 0x110
		private Dice _selectedDice; // 0x118
		private List<Dice> _opponentsDice; // 0x120
		private Color _partitionTransparent; // 0x128
		private Color _partitionOpaque; // 0x138
		private int closestSlot; // 0x148
		private int _playerSlotsWon; // 0x14C
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RollDice>d__25 : IEnumerator<object> // TypeDefIndex: 15579
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RollDice>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171E2F0-0x000000018171E5C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171E5C0-0x000000018171E610
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PartitionChange>d__26 : IEnumerator<object> // TypeDefIndex: 15580
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
			public bool inHide; // 0x28
			private float <td>5__2; // 0x2C
			private float <t>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PartitionChange>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171A070-0x000000018171A2A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171A2A0-0x000000018171A2F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DiceToSlot>d__27 : IEnumerator<object> // TypeDefIndex: 15581
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice inDie; // 0x20
			public Transform inSlot; // 0x28
			public DiceVersus <>4__this; // 0x30
			private Vector3 <startPos>5__2; // 0x38
			private float <td>5__3; // 0x44
			private float <timeBasedOnDistance>5__4; // 0x48
			private float <t>5__5; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DiceToSlot>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181717610-0x0000000181717950
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181717950-0x00000001817179A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DiceToLoseSpot>d__29 : IEnumerator<object> // TypeDefIndex: 15582
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Transform inDieTrans; // 0x20
			public DiceVersus <>4__this; // 0x28
			public Vector3 inEndPos; // 0x30
			private float <td>5__2; // 0x3C
			private Vector3 <startPos>5__3; // 0x40
			private float <t>5__4; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DiceToLoseSpot>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181717370-0x00000001817175C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817175C0-0x0000000181717610
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <TallyScore>d__30 : IEnumerator<object> // TypeDefIndex: 15583
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <TallyScore>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181720830-0x0000000181720C90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181720C90-0x0000000181720CE0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 15584
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171F2B0-0x000000018171F3D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171F3D0-0x000000018171F420
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CleanupAndReset>d__33 : IEnumerator<object> // TypeDefIndex: 15585
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CleanupAndReset>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181716280-0x00000001817163E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817163E0-0x0000000181716430
		}
	
		// Constructors
		public DiceVersus(); // 0x000000018170BF20-0x000000018170BFC0
	
		// Methods
		public override void MStart(); // 0x000000018170AB80-0x000000018170AE10
		internal override void Intro(); // 0x000000018170AB10-0x000000018170AB80
		[IteratorStateMachine] // 0x00000001801279F0-0x0000000180127A40
		private IEnumerator RollDice(); // 0x000000018170BDA0-0x000000018170BE00
		[IteratorStateMachine] // 0x0000000180127CD0-0x0000000180127D20
		private IEnumerator PartitionChange(bool inHide); // 0x000000018170BCC0-0x000000018170BD30
		[IteratorStateMachine] // 0x0000000180127F20-0x0000000180127F70
		private IEnumerator DiceToSlot(Dice inDie, Transform inSlot); // 0x000000018170AA90-0x000000018170AB10
		public override void MUpdate(); // 0x000000018170AE10-0x000000018170BCC0
		[IteratorStateMachine] // 0x00000001801280D0-0x0000000180128120
		private IEnumerator DiceToLoseSpot(Transform inDieTrans, Vector3 inEndPos); // 0x000000018170AA00-0x000000018170AA90
		[IteratorStateMachine] // 0x00000001801281F0-0x0000000180128240
		private IEnumerator TallyScore(); // 0x000000018170BE60-0x000000018170BEC0
		[IteratorStateMachine] // 0x00000001801283C0-0x0000000180128410
		public override IEnumerator ShowResults(); // 0x000000018170BE00-0x000000018170BE60
		internal override void ResultsDone(); // 0x000000018170BD30-0x000000018170BDA0
		[IteratorStateMachine] // 0x0000000180128550-0x00000001801285A0
		private IEnumerator CleanupAndReset(); // 0x000000018170A9A0-0x000000018170AA00
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018170BEC0-0x000000018170BF20
	}
}
