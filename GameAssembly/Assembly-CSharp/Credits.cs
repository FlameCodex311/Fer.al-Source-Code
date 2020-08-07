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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Credits : MonoBehaviour // TypeDefIndex: 11853
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CreditInfo[] _creditInfos; // 0x20

	// Nested types
	[Serializable]
	public class CreditInfo // TypeDefIndex: 11854
	{
		// Fields
		public RawImage background; // 0x10
		public Image logo; // 0x18
		public TextMeshProUGUI creditLine; // 0x20
		public float fadeInTimer; // 0x28
		public float holdTimer; // 0x2C
		public float fadeOutTimer; // 0x30

		// Constructors
		public CreditInfo(); // 0x0000000180550790-0x00000001805507B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11855
	{
		// Fields
		public int ii; // 0x10
		public Credits <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal Color <TransToSplash>b__0(); // 0x0000000180568330-0x00000001805683C0
		internal void <TransToSplash>b__1(Color x); // 0x00000001805683C0-0x0000000180568440
		internal Color <TransToSplash>b__2(); // 0x0000000180568440-0x00000001805684D0
		internal void <TransToSplash>b__3(Color x); // 0x00000001805684D0-0x0000000180568550
		internal Color <TransToSplash>b__4(); // 0x0000000180568330-0x00000001805683C0
		internal void <TransToSplash>b__5(Color x); // 0x00000001805683C0-0x0000000180568440
		internal Color <TransToSplash>b__6(); // 0x0000000180568440-0x00000001805684D0
		internal void <TransToSplash>b__7(Color x); // 0x00000001805684D0-0x0000000180568550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TransToSplash>d__3 : IEnumerator<object> // TypeDefIndex: 11856
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Credits <>4__this; // 0x20
		private <>c__DisplayClass3_0 <>8__1; // 0x28
		private Color <cColorLogo>5__2; // 0x30
		private Color <cColorCreditLine>5__3; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TransToSplash>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805673D0-0x0000000180567CD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180567CD0-0x0000000180567D20
	}

	// Constructors
	public Credits(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001805507B0-0x0000000180550B30
	[IteratorStateMachine] // 0x000000018028AA30-0x000000018028AA80
	private IEnumerator TransToSplash(); // 0x0000000180550B30-0x0000000180550B90
}

