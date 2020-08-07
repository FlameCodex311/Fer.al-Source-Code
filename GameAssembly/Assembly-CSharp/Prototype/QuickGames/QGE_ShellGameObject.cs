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
	public class QGE_ShellGameObject : ManagedBehaviour // TypeDefIndex: 14994
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasBall>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <NewPos>k__BackingField; // 0x54
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <OldPos>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <MidPos>k__BackingField; // 0x6C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private QGE_ShellGame <Game>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawImage <Image2fade>k__BackingField; // 0x80
		public GameObject obj_show; // 0x88
		public GameObject obj_hide; // 0x90
		public Button button; // 0x98
		public float hideTime; // 0xA0
		public float hideScaleBump; // 0xA4
	
		// Properties
		public bool HasBall { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
		public Vector3 NewPos { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A542B0-0x0000000180A542D0 0x0000000180A54300-0x0000000180A54310
		public Vector3 OldPos { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A542D0-0x0000000180A542F0 0x0000000180A54310-0x0000000180A54320
		public Vector3 MidPos { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A54290-0x0000000180A542B0 0x0000000180A542F0-0x0000000180A54300
		public QGE_ShellGame Game { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public RawImage Image2fade { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowObject>d__30 : IEnumerator<object> // TypeDefIndex: 14995
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_ShellGameObject <>4__this; // 0x20
			public bool inShowFront; // 0x28
			private Vector3 <startScale>5__2; // 0x2C
			private Vector3 <endScale>5__3; // 0x38
			private float <midTime>5__4; // 0x44
			private float <i>5__5; // 0x48
			private Transform <t>5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowObject>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5FB60-0x0000000180A5FF60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5FF60-0x0000000180A5FFB0
		}
	
		// Constructors
		public QGE_ShellGameObject(); // 0x0000000180A54220-0x0000000180A54290
	
		// Methods
		public override void UAwake(); // 0x0000000180A541C0-0x0000000180A54220
		[IteratorStateMachine] // 0x00000001802863B0-0x0000000180286400
		public IEnumerator ShowObject(bool inShowFront); // 0x0000000180A54150-0x0000000180A541C0
		public void Shell_ButtonClick(); // 0x0000000180A540F0-0x0000000180A54150
	}
}
