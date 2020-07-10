/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PotionMixingController : QuickGamesBase // TypeDefIndex: 16210
	{
		// Fields
		public GameObject tubePrefab_1L; // 0xF0
		public GameObject tubePrefab_1R; // 0xF8
		public GameObject tubePrefab_2L; // 0x100
		public GameObject tubePrefab_2R; // 0x108
		public GameObject tubePrefab_3L; // 0x110
		public GameObject tubePrefab_3R; // 0x118
		public GameObject testBallPrefab; // 0x120
		public List<Color> bottleColors; // 0x128
		public List<GameObject> topBottles; // 0x130
		public List<GameObject> bottomBottles; // 0x138
		public GameObject tileA; // 0x140
		public GameObject tileB; // 0x148
		public GameObject tileC; // 0x150
		private List<Track> tracks; // 0x158
	
		// Nested types
		private class Track // TypeDefIndex: 16211
		{
			// Fields
			public string layerName; // 0x10
			public Color color; // 0x18
			public List<int> tubeIndices; // 0x28
			public PotionMixingBottleController topBottleController; // 0x30
			public PotionMixingBottleController bottomBottleController; // 0x38
	
			// Constructors
			public Track(string layerName, Color color, List<int> tubeIndices, GameObject topBottle, GameObject bottomBottle); // 0x0000000181539FF0-0x000000018153A0A0
	
			// Methods
			public void FinishSetUp(PotionMixingController potionMixingController); // 0x0000000181539F70-0x0000000181539FF0
			public void Run(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__20 : IEnumerator<object> // TypeDefIndex: 16212
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PotionMixingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153FCB0-0x000000018153FD50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153FD50-0x000000018153FDA0
		}
	
		// Constructors
		public PotionMixingController(); // 0x0000000181395910-0x0000000181395920
	
		// Methods
		public override void MStart(); // 0x0000000181530710-0x0000000181530770
		private void Initialize(); // 0x0000000181530420-0x0000000181530710
		private void SetUpTracks(); // 0x0000000181530770-0x0000000181530C20
		private GameObject GetPrefab(int sI, int eI); // 0x0000000181530280-0x0000000181530360
		private GameObject GetTubeParent(GameObject tile, int idx); // 0x0000000181530360-0x0000000181530420
		public override void QuickGameUpdate(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x0000000180150A00-0x0000000180150A50
		public override IEnumerator ShowResults(); // 0x0000000181530C20-0x0000000181530C80
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
