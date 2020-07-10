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

namespace Prototype.QuickGames.FindTheTreasure
{
	public class FindTheTreasure : QuickGamesBase // TypeDefIndex: 16292
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800C1D40-0x00000001800C1D70
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__20 : IEnumerator<object> // TypeDefIndex: 16293
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindTheTreasure <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FD500-0x00000001813FD600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FD600-0x00000001813FD650
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FoundObject>d__22 : IEnumerator<object> // TypeDefIndex: 16294
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FoundObject>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FB590-0x00000001813FB850
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FB850-0x00000001813FB8A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__23 : IEnumerator<object> // TypeDefIndex: 16295
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindTheTreasure <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FECE0-0x00000001813FF080
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FF080-0x00000001813FF0D0
		}
	
		// Constructors
		public FindTheTreasure(); // 0x00000001813E70D0-0x00000001813E71A0
	
		// Methods
		public override void UAwake(); // 0x00000001813E7080-0x00000001813E70D0
		public override void MStart(); // 0x00000001813E6630-0x00000001813E6BE0
		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient); // 0x00000001813E6550-0x00000001813E6630
		[IteratorStateMachine] // 0x00000001800C1E90-0x00000001800C1EE0
		public override IEnumerator ShowIntro(); // 0x00000001813E6FC0-0x00000001813E7020
		public override void QuickGameUpdate(); // 0x00000001813E6BE0-0x00000001813E6FC0
		[IteratorStateMachine] // 0x00000001800C2040-0x00000001800C2090
		private IEnumerator FoundObject(Transform inTrans, RawImage inRawImage); // 0x00000001813E64D0-0x00000001813E6550
		[IteratorStateMachine] // 0x00000001800C21B0-0x00000001800C2200
		public override IEnumerator ShowResults(); // 0x00000001813E7020-0x00000001813E7080
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
