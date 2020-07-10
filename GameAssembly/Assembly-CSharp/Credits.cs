/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Credits : MonoBehaviour // TypeDefIndex: 10363
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CreditInfo[] _creditInfos; // 0x20

	// Nested types
	[Serializable]
	public class CreditInfo // TypeDefIndex: 10364
	{
		// Fields
		public RawImage background; // 0x10
		public Image logo; // 0x18
		public TextMeshProUGUI creditLine; // 0x20
		public float fadeInTimer; // 0x28
		public float holdTimer; // 0x2C
		public float fadeOutTimer; // 0x30

		// Constructors
		public CreditInfo(); // 0x0000000180F3E120-0x0000000180F3E140
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 10365
	{
		// Fields
		public int ii; // 0x10
		public Credits <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal Color <TransToSplash>b__0(); // 0x0000000180F53460-0x0000000180F534F0
		internal void <TransToSplash>b__1(Color x); // 0x0000000180F534F0-0x0000000180F53580
		internal Color <TransToSplash>b__2(); // 0x0000000180F53580-0x0000000180F53610
		internal void <TransToSplash>b__3(Color x); // 0x0000000180F53610-0x0000000180F536A0
		internal Color <TransToSplash>b__4(); // 0x0000000180F53460-0x0000000180F534F0
		internal void <TransToSplash>b__5(Color x); // 0x0000000180F534F0-0x0000000180F53580
		internal Color <TransToSplash>b__6(); // 0x0000000180F53580-0x0000000180F53610
		internal void <TransToSplash>b__7(Color x); // 0x0000000180F53610-0x0000000180F536A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TransToSplash>d__3 : IEnumerator<object> // TypeDefIndex: 10366
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Credits <>4__this; // 0x20
		private <>c__DisplayClass3_0 <>8__1; // 0x28
		private Color <cColorLogo>5__2; // 0x30
		private Color <cColorCreditLine>5__3; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TransToSplash>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F52860-0x0000000180F531C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F531C0-0x0000000180F53210
	}

	// Constructors
	public Credits(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180F3E140-0x0000000180F3E4E0
	[IteratorStateMachine] // 0x00000001800F4160-0x00000001800F41B0
	private IEnumerator TransToSplash(); // 0x0000000180F3E4E0-0x0000000180F3E540
}

