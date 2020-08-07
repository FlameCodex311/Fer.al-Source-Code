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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItems : QuickGamesBase // TypeDefIndex: 15028
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001801D1870-0x00000001801D18A0
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
		private float currentFollowTime { get; set; } // 0x0000000180982BD0-0x0000000180982BE0 0x0000000180982BE0-0x0000000180982C80
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__33 : IEnumerator<object> // TypeDefIndex: 15029
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GatherDroppedItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809949D0-0x0000000180994AD0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994AD0-0x0000000180994B20
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__36 : IEnumerator<object> // TypeDefIndex: 15030
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GatherDroppedItems <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180995640-0x0000000180995B40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180995B40-0x0000000180995B90
		}
	
		// Constructors
		public GatherDroppedItems(); // 0x0000000180982AF0-0x0000000180982BD0
	
		// Methods
		public override void MStart(); // 0x0000000180981B60-0x0000000180981D10
		[IteratorStateMachine] // 0x00000001801D1A80-0x00000001801D1AD0
		public override IEnumerator ShowIntro(); // 0x0000000180982A10-0x0000000180982A70
		public override void QuickGameUpdate(); // 0x0000000180981EC0-0x0000000180982A10
		private void Gather(int i); // 0x0000000180981A90-0x0000000180981B60
		[IteratorStateMachine] // 0x00000001801D1E20-0x00000001801D1E70
		public override IEnumerator ShowResults(); // 0x0000000180982A70-0x0000000180982AD0
		internal void NewItem(Vector3 inLocalPosition, GatherDroppedItemsItem.EItemType inItemType = GatherDroppedItemsItem.EItemType.ITEM /* Metadata: 0x007BB0F5 */); // 0x0000000180981D10-0x0000000180981EC0
		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient); // 0x00000001803774A0-0x00000001803774B0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
