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

public class UI_Window_Feedback : UI_Window // TypeDefIndex: 12463
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _feedbackInput; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _submitButton; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Panel_Dropdown _categoryDropdown; // 0x118
	private FeedbackCategory _feedbackCategory; // 0x120

	// Properties
	public FeedbackCategory FeedbackCategory { get; set; } // 0x0000000180641E60-0x0000000180641E70 0x0000000180F13130-0x0000000180F13140

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12464
	{
		// Fields
		public FeedbackCategory inCategory; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Feedback window); // 0x0000000180ECE210-0x0000000180ECE240
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12465
	{
		// Fields
		public FeedbackCategory inCategory; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECECA0-0x0000000180ECED70
	}

	// Constructors
	public UI_Window_Feedback(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x00782EDE */); // 0x0000000180F13290-0x0000000180F13350
	public static void QueueWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x00782EE2 */); // 0x0000000180F13350-0x0000000180F13410
	public static void CloseWindow(); // 0x0000000180F12FF0-0x0000000180F13040
	private void Setup(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x00782EE6 */); // 0x0000000180F13410-0x0000000180F13440
	protected override void OnOpen(); // 0x0000000180F131B0-0x0000000180F13290
	protected override void OnClose(bool inAnimate); // 0x0000000180F13040-0x0000000180F13130
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_GiveFeedback(); // 0x0000000180F12E40-0x0000000180F12FF0
	public void OnDropDownItemSelected_Category(int inCategory); // 0x0000000180F13130-0x0000000180F13140
	public void OnFeedbackTextUpdated(string inFeedbackText); // 0x0000000180F13140-0x0000000180F131B0
}

