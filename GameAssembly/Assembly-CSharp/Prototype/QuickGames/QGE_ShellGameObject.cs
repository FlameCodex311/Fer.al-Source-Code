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
	public class QGE_ShellGameObject : ManagedBehaviour // TypeDefIndex: 16252
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasBall>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <NewPos>k__BackingField; // 0x54
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <OldPos>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <MidPos>k__BackingField; // 0x6C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private QGE_ShellGame <Game>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage <Image2fade>k__BackingField; // 0x80
		public GameObject obj_show; // 0x88
		public GameObject obj_hide; // 0x90
		public Button button; // 0x98
		public float hideTime; // 0xA0
		public float hideScaleBump; // 0xA4
	
		// Properties
		public bool HasBall { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
		public Vector3 NewPos { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181531E20-0x0000000181531E40 0x0000000181531E50-0x0000000181531E60
		public Vector3 OldPos { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810B8B90-0x00000001810B8BB0 0x0000000181531E60-0x0000000181531E70
		public Vector3 MidPos { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181531E00-0x0000000181531E20 0x0000000181531E40-0x0000000181531E50
		public QGE_ShellGame Game { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public RawImage Image2fade { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowObject>d__30 : IEnumerator<object> // TypeDefIndex: 16253
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowObject>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153E630-0x000000018153EA30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153EA30-0x000000018153EA80
		}
	
		// Constructors
		public QGE_ShellGameObject(); // 0x0000000181531D90-0x0000000181531E00
	
		// Methods
		public override void UAwake(); // 0x0000000181531D30-0x0000000181531D90
		[IteratorStateMachine] // 0x00000001801677A0-0x00000001801677F0
		public IEnumerator ShowObject(bool inShowFront); // 0x0000000181531CC0-0x0000000181531D30
		public void Shell_ButtonClick(); // 0x0000000181531C50-0x0000000181531CC0
	}
}
