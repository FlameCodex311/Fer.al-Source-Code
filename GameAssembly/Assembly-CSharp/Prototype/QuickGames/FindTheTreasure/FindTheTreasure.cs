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

namespace Prototype.QuickGames.FindTheTreasure
{
	public class FindTheTreasure : QuickGamesBase // TypeDefIndex: 15034
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001801D48A0-0x00000001801D48D0
		public FindTheTreasure_dragTarget dragTarget; // 0xF8
		public int minNonRareObjects; // 0x100
		public int maxNonRareOnjects; // 0x104
		public Transform aObject; // 0x108
		public Transform spawnLocations_rare; // 0x110
		public Transform spawnLocations_nonRare; // 0x118
		public float spotAngle; // 0x120
		public float discoverDistanceMin; // 0x124
		public float discoverDistanceMax; // 0x128
		public float revealTime; // 0x12C
		private List<Transform> _allObjects; // 0x130
		private List<RawImage> _allRawImages; // 0x138
		private bool _rareFound; // 0x140
		private int _nonRaresFound; // 0x144
		private float _colorVal; // 0x148
		private float _dist2obj; // 0x14C
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__20 : IEnumerator<object> // TypeDefIndex: 15035
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindTheTreasure <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180994460-0x0000000180994560
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994560-0x00000001809945B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FoundObject>d__22 : IEnumerator<object> // TypeDefIndex: 15036
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Transform inTrans; // 0x20
			public RawImage inRawImage; // 0x28
			public FindTheTreasure <>4__this; // 0x30
			private Light <aLight>5__2; // 0x38
			private Color <startObjectColor>5__3; // 0x40
			private float <f>5__4; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FoundObject>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADF220-0x0000000180ADF4D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADF4D0-0x0000000180ADF520
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__23 : IEnumerator<object> // TypeDefIndex: 15037
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindTheTreasure <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180994F90-0x0000000180995310
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180995310-0x0000000180995360
		}
	
		// Constructors
		public FindTheTreasure(); // 0x0000000180ADAD10-0x0000000180ADADE0
	
		// Methods
		public override void UAwake(); // 0x0000000180ADACC0-0x0000000180ADAD10
		public override void MStart(); // 0x0000000180ADA280-0x0000000180ADA810
		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient); // 0x0000000180ADA1A0-0x0000000180ADA280
		[IteratorStateMachine] // 0x00000001801D4A80-0x00000001801D4AD0
		public override IEnumerator ShowIntro(); // 0x0000000180ADABE0-0x0000000180ADAC50
		public override void QuickGameUpdate(); // 0x0000000180ADA810-0x0000000180ADABE0
		[IteratorStateMachine] // 0x00000001801D4DE0-0x00000001801D4E30
		private IEnumerator FoundObject(Transform inTrans, RawImage inRawImage); // 0x0000000180ADA120-0x0000000180ADA1A0
		[IteratorStateMachine] // 0x00000001801D5100-0x00000001801D5150
		public override IEnumerator ShowResults(); // 0x0000000180ADAC50-0x0000000180ADACC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
