/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ChallengeComplete : UI_Window // TypeDefIndex: 12418
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _affiliationIcon; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _aradiaColor; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _delilahColor; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _questIcon; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _questTitleText; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _questLocationText; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _challengeBannerRectangle; // 0x150
	private Action<bool> _resultCallback; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12419
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ChallengeComplete window); // 0x0000000180EFEE20-0x0000000180EFEE50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12420
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF3C0-0x0000000180EFF490
	}

	// Constructors
	public UI_Window_ChallengeComplete(); // 0x0000000180F030F0-0x0000000180F03140

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x0000000180F02F10-0x0000000180F02FD0
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x0000000180F02FD0-0x0000000180F03090
	public static void CloseWindow(); // 0x0000000180F02990-0x0000000180F029E0
	private void Setup(Action<bool> inResultCallback = null); // 0x00000001803BE550-0x00000001803BE560
	protected override void OnOpen(); // 0x0000000180F029E0-0x0000000180F02F10
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Leave(); // 0x0000000180F02930-0x0000000180F02990
	public void BtnClicked_Cancel(); // 0x0000000180F028D0-0x0000000180F02930
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__13_0(Sprite inSprite); // 0x0000000180EDF980-0x0000000180EDF9B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__13_1(Sprite sprite); // 0x0000000180F03090-0x0000000180F030C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__13_2(Sprite inSprite); // 0x0000000180F030C0-0x0000000180F030F0
}

