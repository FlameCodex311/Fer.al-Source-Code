/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ControllerChangedPrompt : UI_Window // TypeDefIndex: 14027
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _keepKeyboardBtn; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x118
	private bool _controllerConnected; // 0x120
	private int _controllerId; // 0x124

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 14028
	{
		// Fields
		public ControllerConnectedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnControllerConnected>b__0(UI_Window_ControllerChangedPrompt inWindow); // 0x000000018047F330-0x000000018047F370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 14029
	{
		// Fields
		public ControllerPreDisconnectedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnControllerPreDisconnected>b__0(UI_Window_ControllerChangedPrompt inWindow); // 0x000000018047F370-0x000000018047F3B0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14030
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ControllerChangedPrompt> <>9__8_0; // 0x08
		public static Action<UI_Window> <>9__9_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F5F0-0x000000018047F650
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__8_0(UI_Window_ControllerChangedPrompt window); // 0x000000018047E1A0-0x000000018047E1D0
		internal void <QueueWindow>b__9_0(UI_Window inWindow); // 0x000000018047E630-0x000000018047E6F0
	}

	// Constructors
	public UI_Window_ControllerChangedPrompt(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void StaticInit(); // 0x00000001803774A0-0x00000001803774B0
	public static void OnControllerConnected(ControllerConnectedMessage inMessage); // 0x0000000180485740-0x00000001804858F0
	public static void OnControllerPreDisconnected(ControllerPreDisconnectedMessage inMessage); // 0x00000001804858F0-0x0000000180485AD0
	public static void OpenWindow(); // 0x0000000180485BB0-0x0000000180485CB0
	public static void QueueWindow(); // 0x0000000180485CB0-0x0000000180485DB0
	public static void CloseWindow(); // 0x0000000180485550-0x00000001804855A0
	private void Setup(bool inConnected, int inControllerId); // 0x0000000180485DB0-0x0000000180485F20
	private void ControllerConnectedWhileOpen(); // 0x00000001804855A0-0x0000000180485600
	private void ControllerDisconnectedWhileOpen(); // 0x0000000180485600-0x0000000180485660
	protected override void OnOpen(); // 0x0000000180485AD0-0x0000000180485BB0
	protected override void OnClose(bool inAnimate); // 0x0000000180485660-0x0000000180485740
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_UseKeyboard(); // 0x0000000180485460-0x0000000180485550
	public void BtnClicked_Restart(); // 0x0000000180485350-0x0000000180485460
}

