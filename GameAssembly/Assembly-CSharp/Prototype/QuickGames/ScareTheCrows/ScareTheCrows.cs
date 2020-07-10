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

namespace Prototype.QuickGames.ScareTheCrows
{
	public class ScareTheCrows : QuickGamesBase // TypeDefIndex: 16273
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800B5970-0x00000001800B59A0
		public int totalCrows; // 0xF4
		[Header] // 0x00000001800B5AC0-0x00000001800B5AF0
		public float swatRange; // 0xF8
		[Header] // 0x00000001800B5C20-0x00000001800B5C50
		public Transform crow; // 0x100
		public Texture crowImage_Down; // 0x108
		public Texture crowImage_Fly; // 0x110
		public int minStartCrows; // 0x118
		public int maxStartCrows; // 0x11C
		public float minCrowSpawnTime; // 0x120
		public float maxCrowSpawnTime; // 0x124
		public int minPecks; // 0x128
		public int maxPecks; // 0x12C
		public float peckTimeDown; // 0x130
		public float peckTimeUp; // 0x134
		public float crowSpeed; // 0x138
		public float flapTime; // 0x13C
		public Vector2 crowCropOffset; // 0x140
		public Transform[] spawnLocations; // 0x148
		public GameObject particleSystemPrefab; // 0x150
		public ParticleSystem particles; // 0x158
		[Header] // 0x00000001800B5D80-0x00000001800B5DB0
		public Transform crop; // 0x160
		public float cropShrinkTime; // 0x168
		public Transform[] cropLocations; // 0x170
		internal Texture crowImage_Up; // 0x178
		internal List<Transform> allCrops; // 0x180
		internal List<Transform> pickableCrops; // 0x188
		internal List<Crow> allCrows; // 0x190
		private float _crowSpawnTime; // 0x198
		private int _totalCrows; // 0x19C
		private int _crowsSwatted; // 0x1A0
		private RectTransform _hudRect; // 0x1A8
		private Vector2 _mousePos; // 0x1B0
		private Camera _cam; // 0x1B8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__36 : IEnumerator<object> // TypeDefIndex: 16274
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScareTheCrows <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153DF60-0x000000018153E040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153E040-0x000000018153E090
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__39 : IEnumerator<object> // TypeDefIndex: 16275
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScareTheCrows <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__39(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815401C0-0x0000000181540520
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181540520-0x0000000181540570
		}
	
		// Constructors
		public ScareTheCrows(); // 0x00000001815394E0-0x0000000181539630
	
		// Methods
		public override void UAwake(); // 0x00000001815386C0-0x0000000181538ED0
		internal Transform GetNewCrop(); // 0x0000000181537F10-0x0000000181538040
		public override void MStart(); // 0x0000000181532C80-0x0000000181532CD0
		[IteratorStateMachine] // 0x00000001800B5FF0-0x00000001800B6040
		public override IEnumerator ShowIntro(); // 0x0000000181538600-0x0000000181538660
		private void UpdateCrows(); // 0x0000000181538ED0-0x00000001815394E0
		public override void QuickGameUpdate(); // 0x0000000181538040-0x0000000181538600
		[IteratorStateMachine] // 0x00000001800B6260-0x00000001800B62B0
		public override IEnumerator ShowResults(); // 0x0000000181538660-0x00000001815386C0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
