/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Blackout : UI_Window // TypeDefIndex: 14004
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14005
	{
		// Fields
		public float inFadeDuration; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Blackout window); // 0x000000018047E880-0x000000018047E8F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14006
	{
		// Fields
		public float inFadeDuration; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047F070-0x000000018047F180
	}

	// Constructors
	public UI_Window_Blackout(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(float inFadeDuration = 1f /* Metadata: 0x007BA5E1 */); // 0x000000018047F980-0x000000018047FA40
	public static void QueueWindow(float inFadeDuration = 1f /* Metadata: 0x007BA5E5 */); // 0x000000018047FA40-0x000000018047FB00
	public static void CloseWindow(float inFadeDuration = 1f /* Metadata: 0x007BA5E9 */); // 0x000000018047F7D0-0x000000018047F8D0
	private void Setup(float inFadeDuration = 1f /* Metadata: 0x007BA5ED */); // 0x000000018047FB00-0x000000018047FB70
	public void Close(float inFadeDuration = 1f /* Metadata: 0x007BA5F1 */); // 0x000000018047F8D0-0x000000018047F980
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Close>b__5_0(); // 0x00000001803B58D0-0x00000001803B58E0
}

