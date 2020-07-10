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

namespace Prototype.QuickGames.CatchTheFish
{
	public class CatchTheFish : QuickGamesBase // TypeDefIndex: 16315
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800D0700-0x00000001800D0730
		public GameObject rareFish; // 0xF8
		public GameObject fish; // 0x100
		public float minTimeBetweenFish; // 0x108
		public float maxTimeBetweenFish; // 0x10C
		public int minFishBeforeRare; // 0x110
		public int maxFishBeforeRare; // 0x114
		public float launchLandTime; // 0x118
		public float fishInAirTime; // 0x11C
		public float caughtTime; // 0x120
		public LocatorInfo[] locatorInfos; // 0x128
		private float _nextFishTime; // 0x130
		private int[] _rndPattern; // 0x138
		private int _patternIndex; // 0x140
		private int _fishBeforeRare; // 0x144
		private int _fishIndex; // 0x148
		private List<Fish> _allFish; // 0x150
		private RectTransform _hudRect; // 0x158
		private Camera _cam; // 0x160
		private bool _rareFishHit; // 0x168
		private int _fishCaught; // 0x16C
		private Vector3 _cursorPosition; // 0x170
	
		// Nested types
		[Serializable]
		public class LocatorInfo // TypeDefIndex: 16316
		{
			// Fields
			public Transform spawnLaunch; // 0x10
			public Transform spawnLand; // 0x18
			public Transform catchLand; // 0x20
	
			// Constructors
			public LocatorInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		private class Fish : UnityEngine.MonoBehaviour // TypeDefIndex: 16317
		{
			// Fields
			internal bool isRare; // 0x18
			internal bool canCatch; // 0x19
			internal bool done; // 0x1A
			internal LocatorInfo MyLocatorInfo; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private CatchTheFish <Game>k__BackingField; // 0x28
			private bool _caught; // 0x30
			private bool _landing; // 0x31
			private float _inAirTime; // 0x34
			private float _caughtTime; // 0x38
			private Vector3 _caughtPosition; // 0x3C
			private Quaternion _startRotation; // 0x48
			private Quaternion _endRotation; // 0x58
			private RawImage _image; // 0x68
			private Transform _trans; // 0x70
	
			// Properties
			internal CatchTheFish Game { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <LaunchFish>d__18 : IEnumerator<object> // TypeDefIndex: 16318
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public Fish <>4__this; // 0x20
				private float <t>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <LaunchFish>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x00000001813A9360-0x00000001813A95E0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001813A95E0-0x00000001813A9630
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <LandFish>d__20 : IEnumerator<object> // TypeDefIndex: 16319
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public Fish <>4__this; // 0x20
				private float <t>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <LandFish>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x00000001813A9110-0x00000001813A9310
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001813A9310-0x00000001813A9360
			}
	
			// Constructors
			public Fish(); // 0x00000001813A42A0-0x00000001813A4300
	
			// Methods
			private void Awake(); // 0x00000001813A3AD0-0x00000001813A3C30
			[IteratorStateMachine] // 0x00000001800D1BC0-0x00000001800D1C10
			internal IEnumerator LaunchFish(); // 0x00000001813A3D60-0x00000001813A3DC0
			internal void MoveFish(); // 0x00000001813A3DC0-0x00000001813A42A0
			[IteratorStateMachine] // 0x00000001800D1E60-0x00000001800D1EB0
			private IEnumerator LandFish(); // 0x00000001813A3D00-0x00000001813A3D60
			internal void Caught(); // 0x00000001813A3C30-0x00000001813A3D00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__25 : IEnumerator<object> // TypeDefIndex: 16320
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchTheFish <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AD710-0x00000001813AD810
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AD810-0x00000001813AD860
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__27 : IEnumerator<object> // TypeDefIndex: 16321
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchTheFish <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AE5F0-0x00000001813AEB00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AEB00-0x00000001813AEB50
		}
	
		// Constructors
		public CatchTheFish(); // 0x0000000181399130-0x00000001813991F0
	
		// Methods
		public override void UAwake(); // 0x0000000181398D10-0x0000000181399130
		public override void MStart(); // 0x00000001813985E0-0x0000000181398690
		[IteratorStateMachine] // 0x00000001800D08F0-0x00000001800D0940
		public override IEnumerator ShowIntro(); // 0x0000000181398C50-0x0000000181398CB0
		public override void QuickGameUpdate(); // 0x0000000181398690-0x0000000181398C50
		[IteratorStateMachine] // 0x00000001800D0D40-0x00000001800D0D90
		public override IEnumerator ShowResults(); // 0x0000000181398CB0-0x0000000181398D10
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
