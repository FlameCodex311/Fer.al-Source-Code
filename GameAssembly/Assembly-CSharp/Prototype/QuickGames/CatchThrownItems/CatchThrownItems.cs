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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItems : QuickGamesBase // TypeDefIndex: 16305
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800CC180-0x00000001800CC1B0
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__31 : IEnumerator<object> // TypeDefIndex: 16306
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AD9E0-0x00000001813ADAE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ADAE0-0x00000001813ADB30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__35 : IEnumerator<object> // TypeDefIndex: 16307
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AF070-0x00000001813AF4E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AF4E0-0x00000001813AF530
		}
	
		// Constructors
		public CatchThrownItems(); // 0x000000018139BDE0-0x000000018139BEF0
	
		// Methods
		public override void MStart(); // 0x000000018139B780-0x000000018139B970
		[IteratorStateMachine] // 0x00000001800CC460-0x00000001800CC4B0
		public override IEnumerator ShowIntro(); // 0x000000018139BB20-0x000000018139BB80
		public override void QuickGameUpdate(); // 0x000000018139B970-0x000000018139BB20
		internal CatchThrownItemsItem SpawnIten(Transform inTrans); // 0x000000018139BBE0-0x000000018139BDE0
		[IteratorStateMachine] // 0x00000001800CC830-0x00000001800CC880
		public override IEnumerator ShowResults(); // 0x000000018139BB80-0x000000018139BBE0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
