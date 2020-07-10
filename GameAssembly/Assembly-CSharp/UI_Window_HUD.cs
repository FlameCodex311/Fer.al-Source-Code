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

public class UI_Window_HUD : UI_Window // TypeDefIndex: 12483
{
	// Fields
	public WWTextMeshProUGUI textEmberCount; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupButton0; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _interactionIcon0; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupButton1; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _interactionIcon1; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _labelLevelName; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _minimapCanvas; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _socialCanvas; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _sanctuaryHUD; // 0x148

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12484
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HUD> <>9__9_0; // 0x08
		public static Action<UI_Window> <>9__10_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF930-0x0000000180ECF990
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__9_0(UI_Window_HUD window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__10_0(UI_Window inWindow); // 0x0000000180ECDA20-0x0000000180ECDAA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_Sanctuary>d__26 : IAsyncStateMachine // TypeDefIndex: 12485
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0FB0-0x00000001801F0FC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_HUD(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180ED3600-0x0000000180ED3700
	public static void QueueWindow(); // 0x0000000180ED3700-0x0000000180ED3800
	public static void CloseWindow(); // 0x0000000180ED28C0-0x0000000180ED2910
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180ED3140-0x0000000180ED3600
	protected override void OnClose(bool inAnimate); // 0x0000000180ED2C30-0x0000000180ED30B0
	public void OpenSettings(); // 0x0000000180ED2760-0x0000000180ED2770
	private void LateUpdate(); // 0x0000000180ED2910-0x0000000180ED2C30
	public void BtnClicked_OpenChat(); // 0x0000000180ED2610-0x0000000180ED2660
	public void BtnClicked_Settings(); // 0x0000000180ED2760-0x0000000180ED2770
	public void SetButtonActive(int inButtonId, bool inActive); // 0x0000000180ED3800-0x0000000180ED3890
	public void SetButtonIcon(int inButtonId, string inImageDefId, bool inInteractButtonEnabled = true /* Metadata: 0x00782F14 */); // 0x0000000180ED3890-0x0000000180ED3C00
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x0000000180ED30B0-0x0000000180ED3140
	public void BtnClicked_Customize(); // 0x0000000180ED23A0-0x0000000180ED2400
	public void BtnClicked_Inventory(); // 0x0000000180ED2560-0x0000000180ED25C0
	public void BtnClicked_ToggleEmoteWheel(); // 0x0000000180ED27C0-0x0000000180ED2810
	public void BtnClicked_ToggleSelfieMode(); // 0x0000000180ED2810-0x0000000180ED2860
	[AsyncStateMachine] // 0x00000001800C3100-0x00000001800C3150
	public void BtnClicked_Sanctuary(); // 0x0000000180ED26C0-0x0000000180ED2750
	public void BtnClicked_SeasonPass(); // 0x0000000180ED2750-0x0000000180ED2760
	public void BtnClicked_AstraShop(); // 0x0000000180ED2390-0x0000000180ED23A0
	public void BtnClicked_Inspirations(); // 0x0000000180ED2500-0x0000000180ED2560
	public void BtnClicked_Party(); // 0x0000000180ED2660-0x0000000180ED26C0
	public void BtnClicked_Quests(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_Notifications(); // 0x0000000180ED25C0-0x0000000180ED2610
	public void BtnClicked_Group(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_ToggleChat(); // 0x0000000180ED2770-0x0000000180ED27C0
	public void BtnClicked_ToggleSocial(); // 0x0000000180ED2860-0x0000000180ED28B0
	public void BtnClicked_HelpOverlay(); // 0x0000000180ED2190-0x0000000180ED2290
	public void BtnClicked_WorldMap(); // 0x0000000180ED28B0-0x0000000180ED28C0
	public void BtnClicked_IAPShop(); // 0x0000000180ED2400-0x0000000180ED2500
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

