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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class DouseCinder : QuickGamesBase // TypeDefIndex: 14848
	{
		// Fields
		[Header] // 0x0000000180230A40-0x0000000180230A70
		public GameObject obj_cloud; // 0xF0
		public GameObject obj_rain; // 0xF8
		public GameObject obj_cinder; // 0x100
		public ParticleSystem cinderFireFX; // 0x108
		public ParticleSystem cinderSmokeFX; // 0x110
		[Tooltip] // 0x0000000180230C20-0x0000000180230C50
		public float targetMoveDistnceMaxX; // 0x118
		[Tooltip] // 0x0000000180230E50-0x0000000180230E80
		public float cursorMoveDistnceMaxX; // 0x11C
		public float cinderHPS; // 0x120
		public float cinderMoveSpeed; // 0x124
		public float rainXoffset; // 0x128
		public float rainDamage; // 0x12C
		public float minRainStartSpeed; // 0x130
		public float maxRainStartSpeed; // 0x134
		public float timeBetweenRain; // 0x138
		[Header] // 0x00000001801D1640-0x00000001801D1670
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
		private class Cinder : MonoBehaviour // TypeDefIndex: 14849
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private DouseCinder <Game>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <Hps>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <StartHps>k__BackingField; // 0x2C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ParticleSystem <CinderFireFX>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ParticleSystem <CinderSmokeFX>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <StartScaleFireFX>k__BackingField; // 0x40
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <StartScaleSmokeFX>k__BackingField; // 0x4C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Transform <TransformFireFX>k__BackingField; // 0x58
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Transform <TransformSmokeFX>k__BackingField; // 0x60
			public RawImage image; // 0x68
			private Vector3 _fxSmallScale; // 0x70
			private bool _showingSmoke; // 0x7C
			private Color _deadColor; // 0x80
	
			// Properties
			public DouseCinder Game { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
			public float Hps { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			public float StartHps { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50
			public ParticleSystem CinderFireFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
			public ParticleSystem CinderSmokeFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
			public Vector3 StartScaleFireFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180AD35C0-0x0000000180AD35E0 0x0000000180AD3600-0x0000000180AD3610
			public Vector3 StartScaleSmokeFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180AD35E0-0x0000000180AD3600 0x0000000180AD3610-0x0000000180AD3620
			public Transform TransformFireFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
			public Transform TransformSmokeFX { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
	
			// Constructors
			public Cinder(); // 0x0000000180AD3550-0x0000000180AD35C0
	
			// Methods
			private void Awake(); // 0x0000000180AD3140-0x0000000180AD3180
			private void OnCollisionEnter2D(Collision2D collision); // 0x0000000180AD3180-0x0000000180AD3550
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__35 : IEnumerator<object> // TypeDefIndex: 14850
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
			private float <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE2050-0x0000000180AE2150
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE2150-0x0000000180AE21A0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MakeRain>d__38 : IEnumerator<object> // TypeDefIndex: 14851
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MakeRain>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADFCB0-0x0000000180AE0120
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE0120-0x0000000180AE0170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RemoveRain>d__42 : IEnumerator<object> // TypeDefIndex: 14852
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DouseCinder <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RemoveRain>d__42(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE07C0-0x0000000180AE0930
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE0930-0x0000000180AE0980
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__43 : IEnumerator<object> // TypeDefIndex: 14853
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__43(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE4900-0x0000000180AE4D40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE4D40-0x0000000180AE4D90
		}
	
		// Constructors
		public DouseCinder(); // 0x0000000180AD7A50-0x0000000180AD7BA0
	
		// Methods
		public override void MStart(); // 0x0000000180AD65E0-0x0000000180AD6C90
		[IteratorStateMachine] // 0x0000000180231590-0x00000001802315E0
		public override IEnumerator ShowIntro(); // 0x0000000180AD7990-0x0000000180AD79F0
		private void MoveCinder(); // 0x0000000180AD6CF0-0x0000000180AD7040
		public override void QuickGameUpdate(); // 0x0000000180AD7340-0x0000000180AD7930
		[IteratorStateMachine] // 0x0000000180231830-0x0000000180231880
		private IEnumerator MakeRain(); // 0x0000000180AD6C90-0x0000000180AD6CF0
		private void OnDrawGizmos(); // 0x00000001803774A0-0x00000001803774B0
		private void MoveCloud(); // 0x0000000180AD7040-0x0000000180AD7340
		public void CinderOut(); // 0x0000000180AD65D0-0x0000000180AD65E0
		[IteratorStateMachine] // 0x0000000180231A50-0x0000000180231AA0
		private IEnumerator RemoveRain(); // 0x0000000180AD7930-0x0000000180AD7990
		[IteratorStateMachine] // 0x0000000180231B60-0x0000000180231BB0
		public override IEnumerator ShowResults(); // 0x0000000180AD79F0-0x0000000180AD7A50
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
