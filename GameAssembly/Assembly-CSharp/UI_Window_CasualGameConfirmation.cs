/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_CasualGameConfirmation : UI_Window // TypeDefIndex: 12415
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _bannerImage; // 0x118
	private BaseDef _casualGameDef; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12416
	{
		// Fields
		public BaseDef inCasualGameDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_CasualGameConfirmation window); // 0x0000000180EFF030-0x0000000180EFF060
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12417
	{
		// Fields
		public BaseDef inCasualGameDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF630-0x0000000180EFF700
	}

	// Constructors
	public UI_Window_CasualGameConfirmation(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(BaseDef inCasualGameDef); // 0x0000000180F02560-0x0000000180F02620
	public static void QueueWindow(BaseDef inCasualGameDef); // 0x0000000180F02620-0x0000000180F026E0
	public static void CloseWindow(); // 0x0000000180F02400-0x0000000180F02450
	private void Setup(BaseDef inCasualGameDef); // 0x0000000180F026E0-0x0000000180F028A0
	protected override void OnOpen(); // 0x0000000180F024E0-0x0000000180F02560
	protected override void OnClose(bool inAnimate); // 0x0000000180F02450-0x0000000180F024E0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Play(); // 0x0000000180F02360-0x0000000180F02400
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__7_0(Sprite inResult); // 0x0000000180F028A0-0x0000000180F028D0
}

