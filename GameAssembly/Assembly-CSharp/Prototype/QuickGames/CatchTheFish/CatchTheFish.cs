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

namespace Prototype.QuickGames.CatchTheFish
{
	public class CatchTheFish : QuickGamesBase // TypeDefIndex: 15057
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001801E0AE0-0x00000001801E0B10
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
		public class LocatorInfo // TypeDefIndex: 15058
		{
			// Fields
			public Transform spawnLaunch; // 0x10
			public Transform spawnLand; // 0x18
			public Transform catchLand; // 0x20
	
			// Constructors
			public LocatorInfo(); // 0x0000000180373240-0x0000000180373250
		}
	
		private class Fish : UnityEngine.MonoBehaviour // TypeDefIndex: 15059
		{
			// Fields
			internal bool isRare; // 0x18
			internal bool canCatch; // 0x19
			internal bool done; // 0x1A
			internal LocatorInfo MyLocatorInfo; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
			internal CatchTheFish Game { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <LaunchFish>d__18 : IEnumerator<object> // TypeDefIndex: 15060
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public Fish <>4__this; // 0x20
				private float <t>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <LaunchFish>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180ADFA00-0x0000000180ADFC60
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180ADFC60-0x0000000180ADFCB0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <LandFish>d__20 : IEnumerator<object> // TypeDefIndex: 15061
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public Fish <>4__this; // 0x20
				private float <t>5__2; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <LandFish>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180ADF7C0-0x0000000180ADF9B0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180ADF9B0-0x0000000180ADFA00
			}
	
			// Constructors
			public Fish(); // 0x0000000180ADB580-0x0000000180ADB5E0
	
			// Methods
			private void Awake(); // 0x0000000180ADADE0-0x0000000180ADAF40
			[IteratorStateMachine] // 0x00000001801E2F00-0x00000001801E2F50
			internal IEnumerator LaunchFish(); // 0x0000000180ADB060-0x0000000180ADB0C0
			internal void MoveFish(); // 0x0000000180ADB0C0-0x0000000180ADB580
			[IteratorStateMachine] // 0x00000001801E31A0-0x00000001801E31F0
			private IEnumerator LandFish(); // 0x0000000180ADB000-0x0000000180ADB060
			internal void Caught(); // 0x0000000180ADAF40-0x0000000180ADB000
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__25 : IEnumerator<object> // TypeDefIndex: 15062
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchTheFish <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE1AC0-0x0000000180AE1BC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE1BC0-0x0000000180AE1C10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__27 : IEnumerator<object> // TypeDefIndex: 15063
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchTheFish <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE35D0-0x0000000180AE3AC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE3AC0-0x0000000180AE3B10
		}
	
		// Constructors
		public CatchTheFish(); // 0x0000000180AD0440-0x0000000180AD0500
	
		// Methods
		public override void UAwake(); // 0x0000000180AD0040-0x0000000180AD0440
		public override void MStart(); // 0x0000000180ACF930-0x0000000180ACF9E0
		[IteratorStateMachine] // 0x00000001801E0DB0-0x00000001801E0E00
		public override IEnumerator ShowIntro(); // 0x0000000180ACFF80-0x0000000180ACFFE0
		public override void QuickGameUpdate(); // 0x0000000180ACF9E0-0x0000000180ACFF80
		[IteratorStateMachine] // 0x00000001801E1050-0x00000001801E10A0
		public override IEnumerator ShowResults(); // 0x0000000180ACFFE0-0x0000000180AD0040
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
