/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ControllerChangedPrompt : UI_Window // TypeDefIndex: 12426
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _keepKeyboardBtn; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x118
	private bool _controllerConnected; // 0x120
	private int _controllerId; // 0x124

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12427
	{
		// Fields
		public ControllerConnectedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnControllerConnected>b__0(UI_Window_ControllerChangedPrompt inWindow); // 0x0000000180EFFBA0-0x0000000180EFFBE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12428
	{
		// Fields
		public ControllerPreDisconnectedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnControllerPreDisconnected>b__0(UI_Window_ControllerChangedPrompt inWindow); // 0x0000000180EFFBE0-0x0000000180EFFC20
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12429
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ControllerChangedPrompt> <>9__8_0; // 0x08
		public static Action<UI_Window> <>9__9_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFEC0-0x0000000180EFFF20
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__8_0(UI_Window_ControllerChangedPrompt window); // 0x0000000180EFE7B0-0x0000000180EFE7E0
		internal void <QueueWindow>b__9_0(UI_Window inWindow); // 0x0000000180EFECF0-0x0000000180EFEDB0
	}

	// Constructors
	public UI_Window_ControllerChangedPrompt(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void StaticInit(); // 0x00000001803581E0-0x00000001803581F0
	public static void OnControllerConnected(ControllerConnectedMessage inMessage); // 0x0000000180F07460-0x0000000180F07610
	public static void OnControllerPreDisconnected(ControllerPreDisconnectedMessage inMessage); // 0x0000000180F07610-0x0000000180F077F0
	public static void OpenWindow(); // 0x0000000180F078D0-0x0000000180F079D0
	public static void QueueWindow(); // 0x0000000180F079D0-0x0000000180F07AD0
	public static void CloseWindow(); // 0x0000000180F07270-0x0000000180F072C0
	private void Setup(bool inConnected, int inControllerId); // 0x0000000180F07AD0-0x0000000180F07C50
	private void ControllerConnectedWhileOpen(); // 0x0000000180F072C0-0x0000000180F07320
	private void ControllerDisconnectedWhileOpen(); // 0x0000000180F07320-0x0000000180F07380
	protected override void OnOpen(); // 0x0000000180F077F0-0x0000000180F078D0
	protected override void OnClose(bool inAnimate); // 0x0000000180F07380-0x0000000180F07460
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_UseKeyboard(); // 0x0000000180F07180-0x0000000180F07270
	public void BtnClicked_Restart(); // 0x0000000180F07070-0x0000000180F07180
}

