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

public class UI_Window_HUD : UI_Window // TypeDefIndex: 14078
{
	// Fields
	public WWTextMeshProUGUI textEmberCount; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupButton0; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _interactionIcon0; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupButton1; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _interactionIcon1; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _labelLevelName; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _minimapCanvas; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _socialCanvas; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _sanctuaryHUD; // 0x148

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14079
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HUD> <>9__9_0; // 0x08
		public static Action<UI_Window> <>9__10_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2C70-0x00000001803E2CD0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__9_0(UI_Window_HUD window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__10_0(UI_Window inWindow); // 0x00000001803E0F70-0x00000001803E0FF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_Sanctuary>d__26 : IAsyncStateMachine // TypeDefIndex: 14080
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter<bool> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002650-0x0000000180002660
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_HUD(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803E68B0-0x00000001803E69B0
	public static void QueueWindow(); // 0x00000001803E69B0-0x00000001803E6AB0
	public static void CloseWindow(); // 0x00000001803E5BB0-0x00000001803E5C00
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803E6400-0x00000001803E68B0
	protected override void OnClose(bool inAnimate); // 0x00000001803E5F10-0x00000001803E6370
	public void OpenSettings(); // 0x00000001803E5A50-0x00000001803E5A60
	private void LateUpdate(); // 0x00000001803E5C00-0x00000001803E5F10
	public void BtnClicked_OpenChat(); // 0x00000001803E5900-0x00000001803E5950
	public void BtnClicked_Settings(); // 0x00000001803E5A50-0x00000001803E5A60
	public void SetButtonActive(int inButtonId, bool inActive); // 0x00000001803E6AB0-0x00000001803E6B40
	public void SetButtonIcon(int inButtonId, string inImageDefId, bool inInteractButtonEnabled = true /* Metadata: 0x007BA62C */); // 0x00000001803E6B40-0x00000001803E6EB0
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x00000001803E6370-0x00000001803E6400
	public void BtnClicked_Customize(); // 0x00000001803E5690-0x00000001803E56F0
	public void BtnClicked_Inventory(); // 0x00000001803E5850-0x00000001803E58B0
	public void BtnClicked_ToggleEmoteWheel(); // 0x00000001803E5AB0-0x00000001803E5B00
	public void BtnClicked_ToggleSelfieMode(); // 0x00000001803E5B00-0x00000001803E5B50
	[AsyncStateMachine] // 0x000000018027C210-0x000000018027C260
	public void BtnClicked_Sanctuary(); // 0x00000001803E59B0-0x00000001803E5A40
	public void BtnClicked_SeasonPass(); // 0x00000001803E5A40-0x00000001803E5A50
	public void BtnClicked_AstraShop(); // 0x00000001803E5680-0x00000001803E5690
	public void BtnClicked_Inspirations(); // 0x00000001803E57F0-0x00000001803E5850
	public void BtnClicked_Party(); // 0x00000001803E5950-0x00000001803E59B0
	public void BtnClicked_Quests(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_Notifications(); // 0x00000001803E58B0-0x00000001803E5900
	public void BtnClicked_Group(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_ToggleChat(); // 0x00000001803E5A60-0x00000001803E5AB0
	public void BtnClicked_ToggleSocial(); // 0x00000001803E5B50-0x00000001803E5BA0
	public void BtnClicked_HelpOverlay(); // 0x00000001803E5480-0x00000001803E5580
	public void BtnClicked_WorldMap(); // 0x00000001803E5BA0-0x00000001803E5BB0
	public void BtnClicked_IAPShop(); // 0x00000001803E56F0-0x00000001803E57F0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

