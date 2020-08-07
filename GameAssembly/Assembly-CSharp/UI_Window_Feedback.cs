/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Feedback : UI_Window // TypeDefIndex: 14062
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _feedbackInput; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _submitButton; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Panel_Dropdown _categoryDropdown; // 0x118
	private FeedbackCategory _feedbackCategory; // 0x120

	// Properties
	public FeedbackCategory FeedbackCategory { get; set; } // 0x0000000180491490-0x00000001804914A0 0x0000000180491190-0x00000001804911A0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14063
	{
		// Fields
		public FeedbackCategory inCategory; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Feedback window); // 0x00000001803E1800-0x00000001803E1830
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14064
	{
		// Fields
		public FeedbackCategory inCategory; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E2070-0x00000001803E2140
	}

	// Constructors
	public UI_Window_Feedback(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x007BA5F6 */); // 0x00000001804912F0-0x00000001804913A0
	public static void QueueWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x007BA5FA */); // 0x00000001804913A0-0x0000000180491460
	public static void CloseWindow(); // 0x0000000180491060-0x00000001804910B0
	private void Setup(FeedbackCategory inCategory = FeedbackCategory.Clothing /* Metadata: 0x007BA5FE */); // 0x0000000180491460-0x0000000180491490
	protected override void OnOpen(); // 0x0000000180491210-0x00000001804912F0
	protected override void OnClose(bool inAnimate); // 0x00000001804910B0-0x0000000180491190
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_GiveFeedback(); // 0x0000000180490EB0-0x0000000180491060
	public void OnDropDownItemSelected_Category(int inCategory); // 0x0000000180491190-0x00000001804911A0
	public void OnFeedbackTextUpdated(string inFeedbackText); // 0x00000001804911A0-0x0000000180491210
}

