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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.Dice_Versus
{
	public class DiceVersus : ParlorGame // TypeDefIndex: 14733
	{
		// Fields
		[Header] // 0x00000001801E1220-0x00000001801E1250
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RollDice>d__25 : IEnumerator<object> // TypeDefIndex: 14734
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RollDice>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E81650-0x0000000180E81900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E81900-0x0000000180E81950
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PartitionChange>d__26 : IEnumerator<object> // TypeDefIndex: 14735
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
			public bool inHide; // 0x28
			private float <td>5__2; // 0x2C
			private float <t>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PartitionChange>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7D6F0-0x0000000180E7D910
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7D910-0x0000000180E7D960
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DiceToSlot>d__27 : IEnumerator<object> // TypeDefIndex: 14736
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DiceToSlot>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7B1D0-0x0000000180E7B510
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7B510-0x0000000180E7B560
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DiceToLoseSpot>d__29 : IEnumerator<object> // TypeDefIndex: 14737
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DiceToLoseSpot>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7AF30-0x0000000180E7B180
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7B180-0x0000000180E7B1D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <TallyScore>d__30 : IEnumerator<object> // TypeDefIndex: 14738
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <TallyScore>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E83430-0x0000000180E83870
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E83870-0x0000000180E838C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 14739
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E81F20-0x0000000180E82040
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E82040-0x0000000180E82090
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CleanupAndReset>d__33 : IEnumerator<object> // TypeDefIndex: 14740
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceVersus <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CleanupAndReset>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E79D70-0x0000000180E79ED0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E79ED0-0x0000000180E79F20
		}
	
		// Constructors
		public DiceVersus(); // 0x0000000180E70BB0-0x0000000180E70C50
	
		// Methods
		public override void MStart(); // 0x0000000180E6F890-0x0000000180E6FB10
		internal override void Intro(); // 0x0000000180E6F820-0x0000000180E6F890
		[IteratorStateMachine] // 0x00000001801E2680-0x00000001801E26D0
		private IEnumerator RollDice(); // 0x0000000180E70A30-0x0000000180E70A90
		[IteratorStateMachine] // 0x00000001801E28D0-0x00000001801E2920
		private IEnumerator PartitionChange(bool inHide); // 0x0000000180E70950-0x0000000180E709C0
		[IteratorStateMachine] // 0x00000001801E2AC0-0x00000001801E2B10
		private IEnumerator DiceToSlot(Dice inDie, Transform inSlot); // 0x0000000180E6F7A0-0x0000000180E6F820
		public override void MUpdate(); // 0x0000000180E6FB10-0x0000000180E70950
		[IteratorStateMachine] // 0x00000001801E2DF0-0x00000001801E2E40
		private IEnumerator DiceToLoseSpot(Transform inDieTrans, Vector3 inEndPos); // 0x0000000180E6F710-0x0000000180E6F7A0
		[IteratorStateMachine] // 0x00000001801E3000-0x00000001801E3050
		private IEnumerator TallyScore(); // 0x0000000180E70AF0-0x0000000180E70B50
		[IteratorStateMachine] // 0x00000001801E3240-0x00000001801E3290
		public override IEnumerator ShowResults(); // 0x0000000180E70A90-0x0000000180E70AF0
		internal override void ResultsDone(); // 0x0000000180E709C0-0x0000000180E70A30
		[IteratorStateMachine] // 0x00000001801E3600-0x00000001801E3650
		private IEnumerator CleanupAndReset(); // 0x0000000180E6F6B0-0x0000000180E6F710
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180E70B50-0x0000000180E70BB0
	}
}
