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

public class UI_Window_OkImagePopup : UI_Window // TypeDefIndex: 12530
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageTitleText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _okBtnText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x128
	private Action _okCallback; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12531
	{
		// Fields
		public string inHeader; // 0x10
		public string inMessageTitle; // 0x18
		public string inMessage; // 0x20
		public string inOkBtnText; // 0x28
		public string inImageDefId; // 0x30
		public Action inOkCallback; // 0x38

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkImagePopup window); // 0x0000000180ECE150-0x0000000180ECE1B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12532
	{
		// Fields
		public string inHeader; // 0x10
		public string inMessageTitle; // 0x18
		public string inMessage; // 0x20
		public string inOkBtnText; // 0x28
		public string inImageDefId; // 0x30
		public Action inOkCallback; // 0x38

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECEA00-0x0000000180ECEB00
	}

	// Constructors
	public UI_Window_OkImagePopup(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(string inHeader = "" /* Metadata: 0x00782F6F */, string inMessageTitle = "" /* Metadata: 0x00782F73 */, string inMessage = "" /* Metadata: 0x00782F77 */, string inOkBtnText = "" /* Metadata: 0x00782F7B */, string inImageDefId = "-1" /* Metadata: 0x00782F7F */, Action inOkCallback = null); // 0x0000000180EDD540-0x0000000180EDD640
	public static void QueueWindow(string inHeader = "" /* Metadata: 0x00782F85 */, string inMessageTitle = "" /* Metadata: 0x00782F89 */, string inMessage = "" /* Metadata: 0x00782F8D */, string inOkBtnText = "" /* Metadata: 0x00782F91 */, string inImageDefId = "-1" /* Metadata: 0x00782F95 */, Action inOkCallback = null); // 0x0000000180EDD640-0x0000000180EDD750
	public static void CloseWindow(); // 0x0000000180EDD3C0-0x0000000180EDD410
	public void Setup(string inHeader = "" /* Metadata: 0x00782F9B */, string inMessageTitle = "" /* Metadata: 0x00782F9F */, string inMessage = "" /* Metadata: 0x00782FA3 */, string inOkBtnText = "" /* Metadata: 0x00782FA7 */, string inImageDefId = "-1" /* Metadata: 0x00782FAB */, Action inOkCallback = null); // 0x0000000180EDD750-0x0000000180EDDA30
	public void BtnClicked_Ok(); // 0x0000000180EDD390-0x0000000180EDD3C0
	protected override void OnOpen(); // 0x0000000180EDD4B0-0x0000000180EDD540
	protected override void OnClose(bool inAnimate); // 0x0000000180EDD410-0x0000000180EDD4B0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(Sprite inSprite); // 0x0000000180EDDA30-0x0000000180EDDA60
}

