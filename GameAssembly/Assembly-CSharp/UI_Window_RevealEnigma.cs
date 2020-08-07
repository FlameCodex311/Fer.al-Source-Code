/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_RevealEnigma : UI_Window // TypeDefIndex: 14168
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _animationDuration; // 0x108
	[EnumList] // 0x00000001801D3A50-0x00000001801D3AC0
	[SerializeField] // 0x00000001801D3A50-0x00000001801D3AC0
	private List<GameObject> _enigmaFX; // 0x110
	public Action OnEnigmaRevealComplete; // 0x118

	// Nested types
	public enum EnigmaType // TypeDefIndex: 14169
	{
		Stag = 0,
		Beetle = 1,
		Twiggle = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14170
	{
		// Fields
		public EnigmaType inEnigmaType; // 0x10
		public Action inOnCompleteAction; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_RevealEnigma window); // 0x00000001803B3090-0x00000001803B30C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 14171
	{
		// Fields
		public EnigmaType inEnigmaType; // 0x10
		public Action inOnCompleteAction; // 0x18

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3CD0-0x00000001803B3DA0
	}

	// Constructors
	public UI_Window_RevealEnigma(); // 0x00000001803B84D0-0x00000001803B8540

	// Methods
	public static void OpenWindow(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x00000001803B8260-0x00000001803B8320
	public static void QueueWindow(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x00000001803B8320-0x00000001803B83F0
	public static void CloseWindow(); // 0x00000001803B8180-0x00000001803B81D0
	private void Setup(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x00000001803B83F0-0x00000001803B8490
	protected override void OnOpen(); // 0x00000001803B81D0-0x00000001803B8260
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__8_0(); // 0x00000001803B8490-0x00000001803B84D0
}

