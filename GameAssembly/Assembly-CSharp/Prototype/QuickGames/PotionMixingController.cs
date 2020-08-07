/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PotionMixingController : QuickGamesBase // TypeDefIndex: 14952
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
		private class Track // TypeDefIndex: 14953
		{
			// Fields
			public string layerName; // 0x10
			public Color color; // 0x18
			public List<int> tubeIndices; // 0x28
			public PotionMixingBottleController topBottleController; // 0x30
			public PotionMixingBottleController bottomBottleController; // 0x38
	
			// Constructors
			public Track(string layerName, Color color, List<int> tubeIndices, GameObject topBottle, GameObject bottomBottle); // 0x0000000180A5B9A0-0x0000000180A5BA50
	
			// Methods
			public void FinishSetUp(PotionMixingController potionMixingController); // 0x0000000180A5B920-0x0000000180A5B9A0
			public void Run(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__20 : IEnumerator<object> // TypeDefIndex: 14954
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PotionMixingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A60F90-0x0000000180A61030
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61030-0x0000000180A61080
		}
	
		// Constructors
		public PotionMixingController(); // 0x0000000180A46040-0x0000000180A46050
	
		// Methods
		public override void MStart(); // 0x0000000180A52BF0-0x0000000180A52C50
		private void Initialize(); // 0x0000000180A52910-0x0000000180A52BF0
		private void SetUpTracks(); // 0x0000000180A52C50-0x0000000180A530F0
		private GameObject GetPrefab(int sI, int eI); // 0x0000000180A52770-0x0000000180A52850
		private GameObject GetTubeParent(GameObject tile, int idx); // 0x0000000180A52850-0x0000000180A52910
		public override void QuickGameUpdate(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x000000018026E3D0-0x000000018026E420
		public override IEnumerator ShowResults(); // 0x0000000180A530F0-0x0000000180A53150
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
