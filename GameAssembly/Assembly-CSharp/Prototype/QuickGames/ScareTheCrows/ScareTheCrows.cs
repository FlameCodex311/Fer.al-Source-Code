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

namespace Prototype.QuickGames.ScareTheCrows
{
	public class ScareTheCrows : QuickGamesBase // TypeDefIndex: 15015
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x0000000180292330-0x0000000180292360
		public int totalCrows; // 0xF4
		[Header] // 0x0000000180292430-0x0000000180292460
		public float swatRange; // 0xF8
		[Header] // 0x00000001802924E0-0x0000000180292510
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
		[Header] // 0x00000001802925F0-0x0000000180292620
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__36 : IEnumerator<object> // TypeDefIndex: 15016
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScareTheCrows <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A41B50-0x0000000180A41C20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A41C20-0x0000000180A41C70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__39 : IEnumerator<object> // TypeDefIndex: 15017
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScareTheCrows <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A42790-0x0000000180A42AD0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A42AD0-0x0000000180A42B20
		}
	
		// Constructors
		public ScareTheCrows(); // 0x0000000180A5B7B0-0x0000000180A5B900
	
		// Methods
		public override void UAwake(); // 0x0000000180A5A9D0-0x0000000180A5B1C0
		internal Transform GetNewCrop(); // 0x0000000180A5A230-0x0000000180A5A350
		public override void MStart(); // 0x0000000180A550D0-0x0000000180A55120
		[IteratorStateMachine] // 0x00000001802926F0-0x0000000180292740
		public override IEnumerator ShowIntro(); // 0x0000000180A5A8F0-0x0000000180A5A960
		private void UpdateCrows(); // 0x0000000180A5B1C0-0x0000000180A5B7B0
		public override void QuickGameUpdate(); // 0x0000000180A5A350-0x0000000180A5A8F0
		[IteratorStateMachine] // 0x0000000180292860-0x00000001802928B0
		public override IEnumerator ShowResults(); // 0x0000000180A5A960-0x0000000180A5A9D0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
