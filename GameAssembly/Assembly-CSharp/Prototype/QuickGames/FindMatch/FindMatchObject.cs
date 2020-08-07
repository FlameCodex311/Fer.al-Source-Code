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

namespace Prototype.QuickGames.FindMatch
{
	public class FindMatchObject : ManagedBehaviour // TypeDefIndex: 15045
	{
		// Fields
		internal int matchObjectIndex; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawImage <ImageFront>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawImage <ImageBack>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <RandomRank>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FindMatch <FindMatchGame>k__BackingField; // 0x70
		public GameObject obj_buttonBack; // 0x78
		public GameObject obj_imageFront; // 0x80
		public Button button; // 0x88
		public UnityEngine.UI.Text contentsInfoText; // 0x90
		public float hideTime; // 0x98
		public float hideScaleBump; // 0x9C
	
		// Properties
		public RawImage ImageFront { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public RawImage ImageBack { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public float RandomRank { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804C5F40-0x00000001804C5F50 0x00000001804C6190-0x00000001804C61A0
		public FindMatch FindMatchGame { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowObject>d__24 : IEnumerator<object> // TypeDefIndex: 15046
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatchObject <>4__this; // 0x20
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
			public <ShowObject>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE21A0-0x0000000180AE2640
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE2640-0x0000000180AE2690
		}
	
		// Constructors
		public FindMatchObject(); // 0x0000000180AD9210-0x0000000180AD9280
	
		// Methods
		public override void UAwake(); // 0x0000000180AD90F0-0x0000000180AD9180
		[IteratorStateMachine] // 0x00000001801DBD20-0x00000001801DBD70
		public IEnumerator ShowObject(bool inShowFront); // 0x0000000180AD9080-0x0000000180AD90F0
		public void ButtonClicked(); // 0x0000000180AD8FB0-0x0000000180AD9080
		public void Zonk(); // 0x0000000180AD9180-0x0000000180AD9210
	}
}
