/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItems : QuickGamesBase // TypeDefIndex: 15047
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001801DDC60-0x00000001801DDC90
		public Transform forground; // 0xF8
		public CatchThrownItemsThrower thrower1_arm; // 0x100
		public CatchThrownItemsThrower thrower2_arm; // 0x108
		public Transform landLocations; // 0x110
		public Transform basket; // 0x118
		public CatchThrownItemsItem thrownItem; // 0x120
		public Transform shadow; // 0x128
		public CatchThrownItemsDragTarget dragTarget; // 0x130
		public float throwArmRotateRange; // 0x138
		public float throwTimeBack; // 0x13C
		public float throwTimeSpawnItem; // 0x140
		public float throwTimeThrow; // 0x144
		public float throwTimeFollowThrough; // 0x148
		public float throwWaitTimeMin; // 0x14C
		public float throwWaitTimeMax; // 0x150
		public int itemArchSegments; // 0x154
		public float itemInAirTime; // 0x158
		public float itemCatchTime; // 0x15C
		public float itemArchHeightMin; // 0x160
		public float itemArchHeightMax; // 0x164
		public float itemArchDistMin; // 0x168
		public float itemArchDistMax; // 0x16C
		public int numItemsBeforeRareMin; // 0x170
		public int numItemsBeforeRareMax; // 0x174
		internal List<CatchThrownItemsItem> allItems; // 0x178
		internal int itemsCaught; // 0x180
		internal bool rareCaught; // 0x184
		private int _numItemsThrown; // 0x188
		private int _throwRare; // 0x18C
		internal List<Transform> itemLandLocations; // 0x190
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__31 : IEnumerator<object> // TypeDefIndex: 15048
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE1D90-0x0000000180AE1E90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE1E90-0x0000000180AE1EE0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__35 : IEnumerator<object> // TypeDefIndex: 15049
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE4000-0x0000000180AE4450
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE4450-0x0000000180AE44A0
		}
	
		// Constructors
		public CatchThrownItems(); // 0x0000000180AD3030-0x0000000180AD3140
	
		// Methods
		public override void MStart(); // 0x0000000180AD29F0-0x0000000180AD2BD0
		[IteratorStateMachine] // 0x00000001801DDED0-0x00000001801DDF20
		public override IEnumerator ShowIntro(); // 0x0000000180AD2D80-0x0000000180AD2DE0
		public override void QuickGameUpdate(); // 0x0000000180AD2BD0-0x0000000180AD2D80
		internal CatchThrownItemsItem SpawnIten(Transform inTrans); // 0x0000000180AD2E40-0x0000000180AD3030
		[IteratorStateMachine] // 0x00000001801DE280-0x00000001801DE2D0
		public override IEnumerator ShowResults(); // 0x0000000180AD2DE0-0x0000000180AD2E40
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
