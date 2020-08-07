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

public class UI_Window_OkImagePopup : UI_Window // TypeDefIndex: 14132
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageTitleText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _okBtnText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x128
	private Action _okCallback; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14133
	{
		// Fields
		public string inHeader; // 0x10
		public string inMessageTitle; // 0x18
		public string inMessage; // 0x20
		public string inOkBtnText; // 0x28
		public string inImageDefId; // 0x30
		public Action inOkCallback; // 0x38

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkImagePopup window); // 0x00000001803E1750-0x00000001803E17A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14134
	{
		// Fields
		public string inHeader; // 0x10
		public string inMessageTitle; // 0x18
		public string inMessage; // 0x20
		public string inOkBtnText; // 0x28
		public string inImageDefId; // 0x30
		public Action inOkCallback; // 0x38

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E1EA0-0x00000001803E1FA0
	}

	// Constructors
	public UI_Window_OkImagePopup(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inHeader = "" /* Metadata: 0x007BA687 */, string inMessageTitle = "" /* Metadata: 0x007BA68B */, string inMessage = "" /* Metadata: 0x007BA68F */, string inOkBtnText = "" /* Metadata: 0x007BA693 */, string inImageDefId = "-1" /* Metadata: 0x007BA697 */, Action inOkCallback = null); // 0x00000001803F0D20-0x00000001803F0E20
	public static void QueueWindow(string inHeader = "" /* Metadata: 0x007BA69D */, string inMessageTitle = "" /* Metadata: 0x007BA6A1 */, string inMessage = "" /* Metadata: 0x007BA6A5 */, string inOkBtnText = "" /* Metadata: 0x007BA6A9 */, string inImageDefId = "-1" /* Metadata: 0x007BA6AD */, Action inOkCallback = null); // 0x00000001803F0E20-0x00000001803F0F20
	public static void CloseWindow(); // 0x00000001803F0BA0-0x00000001803F0BF0
	public void Setup(string inHeader = "" /* Metadata: 0x007BA6B3 */, string inMessageTitle = "" /* Metadata: 0x007BA6B7 */, string inMessage = "" /* Metadata: 0x007BA6BB */, string inOkBtnText = "" /* Metadata: 0x007BA6BF */, string inImageDefId = "-1" /* Metadata: 0x007BA6C3 */, Action inOkCallback = null); // 0x00000001803F0F20-0x00000001803F1200
	public void BtnClicked_Ok(); // 0x00000001803F0B70-0x00000001803F0BA0
	protected override void OnOpen(); // 0x00000001803F0C90-0x00000001803F0D20
	protected override void OnClose(bool inAnimate); // 0x00000001803F0BF0-0x00000001803F0C90
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(Sprite inSprite); // 0x00000001803F1200-0x00000001803F1230
}

