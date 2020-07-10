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

namespace Prototype.QuickGames.RememberTheEmbers
{
	public class QGE_RememberTheEmbersObject : ManagedBehaviour // TypeDefIndex: 16283
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EMatchObjectType <MatchObjectType>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage <ImageFront>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage <ImageBack>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <RandomRank>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private QGE_RememberTheEmbers <RememberTheEmbersGame>k__BackingField; // 0x70
		public GameObject obj_buttonBack; // 0x78
		public GameObject obj_imageFront; // 0x80
		public Button button; // 0x88
		public float hideTime; // 0x90
		public float hideScaleBump; // 0x94
	
		// Properties
		public EMatchObjectType MatchObjectType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BA0-0x0000000180369BB0 0x0000000180478850-0x0000000180478860
		public RawImage ImageFront { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public RawImage ImageBack { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public float RandomRank { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000180EF18A0-0x0000000180EF18B0
		public QGE_RememberTheEmbers RememberTheEmbersGame { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
	
		// Nested types
		public enum EMatchObjectType // TypeDefIndex: 16284
		{
			EMBER = 0,
			INGREDIENT = 1,
			MATCH1 = 2,
			MATCH2 = 3,
			MATCH3 = 4
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowObject>d__27 : IEnumerator<object> // TypeDefIndex: 16285
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_RememberTheEmbersObject <>4__this; // 0x20
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
			public <ShowObject>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153E170-0x000000018153E5E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153E5E0-0x000000018153E630
		}
	
		// Constructors
		public QGE_RememberTheEmbersObject(); // 0x0000000181530EC0-0x0000000181530F30
	
		// Methods
		public override void UAwake(); // 0x0000000181530E30-0x0000000181530EC0
		[IteratorStateMachine] // 0x00000001800BDC80-0x00000001800BDCD0
		public IEnumerator ShowObject(bool inShowFront); // 0x0000000181530DC0-0x0000000181530E30
		public void ButtonClicked(); // 0x0000000181530C80-0x0000000181530DC0
	}
}
