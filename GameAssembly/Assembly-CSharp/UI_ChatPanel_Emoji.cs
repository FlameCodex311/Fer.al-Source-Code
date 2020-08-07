/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteAlways] // 0x00000001801CDAD0-0x00000001801CDAE0
public class UI_ChatPanel_Emoji : MonoBehaviour // TypeDefIndex: 13481
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EmojiGridLayoutGroup _gridLayout; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _windowedCanvas; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _expandedCanvas; // 0x38
	private bool? _gridExceedsBounds; // 0x40

	// Constructors
	public UI_ChatPanel_Emoji(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void ToggleBtnClicked_Emoji(bool inIsOn); // 0x0000000180541190-0x00000001805412A0
	private void Start(); // 0x00000001805410A0-0x0000000180541190
	private void RefreshCanvasChoice(); // 0x0000000180540ED0-0x00000001805410A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ToggleBtnClicked_Emoji>b__5_0(); // 0x00000001805412A0-0x00000001805412D0
}

