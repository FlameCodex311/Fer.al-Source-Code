/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Blackout : UI_Window // TypeDefIndex: 12412
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12413
	{
		// Fields
		public float inFadeDuration; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Blackout window); // 0x0000000180EFEFB0-0x0000000180EFF030
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12414
	{
		// Fields
		public float inFadeDuration; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF700-0x0000000180EFF810
	}

	// Constructors
	public UI_Window_Blackout(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(float inFadeDuration = 1f /* Metadata: 0x00782EC9 */); // 0x0000000180F02160-0x0000000180F02220
	public static void QueueWindow(float inFadeDuration = 1f /* Metadata: 0x00782ECD */); // 0x0000000180F02220-0x0000000180F022F0
	public static void CloseWindow(float inFadeDuration = 1f /* Metadata: 0x00782ED1 */); // 0x0000000180F01FB0-0x0000000180F020B0
	private void Setup(float inFadeDuration = 1f /* Metadata: 0x00782ED5 */); // 0x0000000180F022F0-0x0000000180F02360
	public void Close(float inFadeDuration = 1f /* Metadata: 0x00782ED9 */); // 0x0000000180F020B0-0x0000000180F02160
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Close>b__5_0(); // 0x0000000180EA0020-0x0000000180EA0030
}

