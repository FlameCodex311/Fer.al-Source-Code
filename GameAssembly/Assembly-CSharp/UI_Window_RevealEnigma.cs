/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_RevealEnigma : UI_Window // TypeDefIndex: 12566
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _animationDuration; // 0x108
	[EnumList] // 0x00000001800E4030-0x00000001800E40A0
	[SerializeField] // 0x00000001800E4030-0x00000001800E40A0
	private List<GameObject> _enigmaFX; // 0x110
	public Action OnEnigmaRevealComplete; // 0x118

	// Nested types
	public enum EnigmaType // TypeDefIndex: 12567
	{
		Stag = 0,
		Beetle = 1,
		Twiggle = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12568
	{
		// Fields
		public EnigmaType inEnigmaType; // 0x10
		public Action inOnCompleteAction; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_RevealEnigma window); // 0x0000000180E9E000-0x0000000180E9E030
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12569
	{
		// Fields
		public EnigmaType inEnigmaType; // 0x10
		public Action inOnCompleteAction; // 0x18

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9EC40-0x0000000180E9ED10
	}

	// Constructors
	public UI_Window_RevealEnigma(); // 0x0000000180EA2C30-0x0000000180EA2CA0

	// Methods
	public static void OpenWindow(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x0000000180EA29B0-0x0000000180EA2A80
	public static void QueueWindow(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x0000000180EA2A80-0x0000000180EA2B50
	public static void CloseWindow(); // 0x0000000180EA28D0-0x0000000180EA2920
	private void Setup(EnigmaType inEnigmaType, Action inOnCompleteAction); // 0x0000000180EA2B50-0x0000000180EA2BF0
	protected override void OnOpen(); // 0x0000000180EA2920-0x0000000180EA29B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__8_0(); // 0x0000000180EA2BF0-0x0000000180EA2C30
}

