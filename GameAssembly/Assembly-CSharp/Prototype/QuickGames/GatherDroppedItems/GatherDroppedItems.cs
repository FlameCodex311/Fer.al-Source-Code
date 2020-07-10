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
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItems : QuickGamesBase // TypeDefIndex: 16286
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800BFDC0-0x00000001800BFDF0
		public GatherDroppedItemsMaker itemMaker; // 0xF8
		public Transform itemGatherer; // 0x100
		public Transform itemHolder; // 0x108
		public GatherDroppedItemsItem item; // 0x110
		public RawImage bgRawImage; // 0x118
		public float itemGathererMatchRotateTime; // 0x120
		public float itemSpeedScalerTime; // 0x124
		public float itemLifeSpanMin; // 0x128
		public float itemLifeSpanMax; // 0x12C
		public float itemFadeOutTime; // 0x130
		public float itemDamp; // 0x134
		public float bgUvDamp; // 0x138
		public float gatherRange; // 0x13C
		public float followRange; // 0x140
		public float followTime; // 0x144
		public float followScaler; // 0x148
		internal float followRatio; // 0x14C
		internal bool isPressed; // 0x150
		internal float dTime; // 0x154
		internal Vector3 moveDir; // 0x158
		internal List<GatherDroppedItemsItem> allItems; // 0x168
		private float _currentFollowTime; // 0x170
		private int _embersCaught; // 0x174
		private float _itemSpeedScalerTime; // 0x178
		private float _itemGathererMatchRotateTime; // 0x17C
		private Vector3 _startMoveDir; // 0x180
		private Quaternion _startGatherRotation; // 0x18C
		private bool _rareCaught; // 0x19C
	
		// Properties
		private float currentFollowTime { get; set; } // 0x00000001813EB630-0x00000001813EB640 0x00000001813EB640-0x00000001813EB6E0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__33 : IEnumerator<object> // TypeDefIndex: 16287
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GatherDroppedItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FDA80-0x00000001813FDB80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FDB80-0x00000001813FDBD0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__36 : IEnumerator<object> // TypeDefIndex: 16288
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GatherDroppedItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FF3C0-0x00000001813FF8E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FF8E0-0x00000001813FF930
		}
	
		// Constructors
		public GatherDroppedItems(); // 0x00000001813EB550-0x00000001813EB630
	
		// Methods
		public override void MStart(); // 0x00000001813EA5A0-0x00000001813EA760
		[IteratorStateMachine] // 0x00000001800BFF70-0x00000001800BFFC0
		public override IEnumerator ShowIntro(); // 0x00000001813EB490-0x00000001813EB4F0
		public override void QuickGameUpdate(); // 0x00000001813EA920-0x00000001813EB490
		private void Gather(int i); // 0x00000001813EA4C0-0x00000001813EA5A0
		[IteratorStateMachine] // 0x00000001800C01E0-0x00000001800C0230
		public override IEnumerator ShowResults(); // 0x00000001813EB4F0-0x00000001813EB550
		internal void NewItem(Vector3 inLocalPosition, GatherDroppedItemsItem.EItemType inItemType = GatherDroppedItemsItem.EItemType.ITEM /* Metadata: 0x00785503 */); // 0x00000001813EA760-0x00000001813EA920
		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient); // 0x00000001803581E0-0x00000001803581F0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
