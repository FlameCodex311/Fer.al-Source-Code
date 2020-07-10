/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Group : UI_Window // TypeDefIndex: 12477
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12478
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Group> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF4B0-0x0000000180ECF510
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Group window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDDD0-0x0000000180ECDE50
	}

	// Constructors
	public UI_Window_Group(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(bool inAnimate = true /* Metadata: 0x00782F13 */); // 0x0000000180ED1CB0-0x0000000180ED1DC0
	public static void QueueWindow(); // 0x0000000180ED1DC0-0x0000000180ED1EC0
	public static void CloseWindow(); // 0x0000000180ED1AA0-0x0000000180ED1AF0
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(bool inAnimate); // 0x0000000180ED1BB0-0x0000000180ED1CB0
	protected override void OnClose(bool inAnimate); // 0x0000000180ED1AF0-0x0000000180ED1BB0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Quests(); // 0x0000000180ED1A00-0x0000000180ED1AA0
	public void BtnClicked_Notifications(); // 0x0000000180ED1890-0x0000000180ED1A00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Quests>b__8_0(); // 0x0000000180EA06A0-0x0000000180EA06B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Notifications>b__9_0(); // 0x0000000180EA06A0-0x0000000180EA06B0
}

