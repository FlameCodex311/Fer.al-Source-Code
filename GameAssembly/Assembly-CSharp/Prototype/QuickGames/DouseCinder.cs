/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class DouseCinder : QuickGamesBase // TypeDefIndex: 16106
	{
		// Fields
		[Header] // 0x000000018010D980-0x000000018010D9B0
		public GameObject obj_cloud; // 0xF0
		public GameObject obj_rain; // 0xF8
		public GameObject obj_cinder; // 0x100
		public ParticleSystem cinderFireFX; // 0x108
		public ParticleSystem cinderSmokeFX; // 0x110
		[Tooltip] // 0x000000018010DCB0-0x000000018010DCE0
		public float targetMoveDistnceMaxX; // 0x118
		[Tooltip] // 0x000000018010DF10-0x000000018010DF40
		public float cursorMoveDistnceMaxX; // 0x11C
		public float cinderHPS; // 0x120
		public float cinderMoveSpeed; // 0x124
		public float rainXoffset; // 0x128
		public float rainDamage; // 0x12C
		public float minRainStartSpeed; // 0x130
		public float maxRainStartSpeed; // 0x134
		public float timeBetweenRain; // 0x138
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x13C
		private bool _draggingCloud; // 0x140
		private float _playAreaBorderMaxX; // 0x144
		private float _playAreaBorderMinX; // 0x148
		private int cloudSiblingIndex; // 0x14C
		private Vector2 _originaCursorPosition; // 0x150
		private Vector2 _cinderPosition; // 0x158
		private Vector2 _cinderScale; // 0x160
		private Vector2 _cinderMoveDir; // 0x168
		private Vector3 _cursorPosition; // 0x170
		private Vector3 _lastMousePosition; // 0x17C
		private Vector3 _currentMousePosition; // 0x188
		private Vector3 _localZreset; // 0x194
		private Transform _cinderTransform; // 0x1A0
		private CircleCollider2D _cloudCollider; // 0x1A8
		private RawImage _cloudImage; // 0x1B0
		private Color _cloudStartColor; // 0x1B8
		private List<GameObject> _rainDrops; // 0x1C8
		private Cinder _cinder; // 0x1D0
	
		// Nested types
		private class Cinder : MonoBehaviour // TypeDefIndex: 16107
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private DouseCinder <Game>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <Hps>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <StartHps>k__BackingField; // 0x2C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private ParticleSystem <CinderFireFX>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private ParticleSystem <CinderSmokeFX>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <StartScaleFireFX>k__BackingField; // 0x40
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <StartScaleSmokeFX>k__BackingField; // 0x4C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Transform <TransformFireFX>k__BackingField; // 0x58
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Transform <TransformSmokeFX>k__BackingField; // 0x60
			public RawImage image; // 0x68
			private Vector3 _fxSmallScale; // 0x70
			private bool _showingSmoke; // 0x7C
			private Color _deadColor; // 0x80
	
			// Properties
			public DouseCinder Game { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
			public float Hps { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			public float StartHps { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0
			public ParticleSystem CinderFireFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
			public ParticleSystem CinderSmokeFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
			public Vector3 StartScaleFireFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139C380-0x000000018139C3A0 0x000000018139C3D0-0x000000018139C3E0
			public Vector3 StartScaleSmokeFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018139C3A0-0x000000018139C3C0 0x000000018139C3E0-0x000000018139C3F0
			public Transform TransformFireFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
			public Transform TransformSmokeFX { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	
			// Constructors
			public Cinder(); // 0x000000018139C310-0x000000018139C380
	
			// Methods
			private void Awake(); // 0x000000018139BEF0-0x000000018139BF30
			private void OnCollisionEnter2D(Collision2D collision); // 0x000000018139BF30-0x000000018139C310
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__35 : IEnumerator<object> // TypeDefIndex: 16108
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
			private float <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ADCA0-0x00000001813ADDA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ADDA0-0x00000001813ADDF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MakeRain>d__38 : IEnumerator<object> // TypeDefIndex: 16109
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MakeRain>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A9630-0x00000001813A9AB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A9AB0-0x00000001813A9B00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RemoveRain>d__42 : IEnumerator<object> // TypeDefIndex: 16110
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RemoveRain>d__42(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AC460-0x00000001813AC5D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AC5D0-0x00000001813AC620
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__43 : IEnumerator<object> // TypeDefIndex: 16111
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
			private Color <cinderStartColor>5__2; // 0x28
			private Color <cloudStartColor>5__3; // 0x38
			private Color <resultColor>5__4; // 0x48
			private Color <transparentWhite>5__5; // 0x58
			private float <fadeTime>5__6; // 0x68
			private float <x>5__7; // 0x6C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__43(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AF9B0-0x00000001813AFE00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AFE00-0x00000001813AFE50
		}
	
		// Constructors
		public DouseCinder(); // 0x00000001813A1620-0x00000001813A1770
	
		// Methods
		public override void MStart(); // 0x00000001813A0170-0x00000001813A0840
		[IteratorStateMachine] // 0x000000018010E1A0-0x000000018010E1F0
		public override IEnumerator ShowIntro(); // 0x00000001813A1560-0x00000001813A15C0
		private void MoveCinder(); // 0x00000001813A08A0-0x00000001813A0BF0
		public override void QuickGameUpdate(); // 0x00000001813A0F00-0x00000001813A1500
		[IteratorStateMachine] // 0x000000018010E540-0x000000018010E590
		private IEnumerator MakeRain(); // 0x00000001813A0840-0x00000001813A08A0
		private void OnDrawGizmos(); // 0x00000001803581E0-0x00000001803581F0
		private void MoveCloud(); // 0x00000001813A0BF0-0x00000001813A0F00
		public void CinderOut(); // 0x00000001813A0160-0x00000001813A0170
		[IteratorStateMachine] // 0x000000018010E8C0-0x000000018010E910
		private IEnumerator RemoveRain(); // 0x00000001813A1500-0x00000001813A1560
		[IteratorStateMachine] // 0x000000018010EA70-0x000000018010EAC0
		public override IEnumerator ShowResults(); // 0x00000001813A15C0-0x00000001813A1620
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
