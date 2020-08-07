/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteAlways] // 0x00000001801CDAD0-0x00000001801CDAE0
public class UI_Window_OkPopup : UI_Window // TypeDefIndex: 11320
{
	// Fields
	[Header] // 0x0000000180287040-0x0000000180287090
	[SerializeField] // 0x0000000180287040-0x0000000180287090
	protected RectTransform _rootLayout; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _body; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WWTextMeshProUGUI _titleText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WWTextMeshProUGUI _messageText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WWTextMeshProUGUI _okBtnText; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<SizeBucket> _sizeBuckets; // 0x130
	private Action _okCallback; // 0x138

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11321
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkPopup window); // 0x00000001803E1860-0x00000001803E18A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 11322
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E25F0-0x00000001803E26D0
	}

	// Constructors
	public UI_Window_OkPopup(); // 0x00000001803F0B00-0x00000001803F0B70

	// Methods
	public static void OpenWindow(string inTitle = "" /* Metadata: 0x0077CA0C */, string inMessage = "" /* Metadata: 0x0077CA10 */, string inOkBtnText = "" /* Metadata: 0x0077CA14 */, Action inOkCallback = null); // 0x00000001803F12B0-0x00000001803F13A0
	public static void QueueWindow(string inTitle = "" /* Metadata: 0x0077CA18 */, string inMessage = "" /* Metadata: 0x0077CA1C */, string inOkBtnText = "" /* Metadata: 0x0077CA20 */, Action inOkCallback = null); // 0x00000001803F13A0-0x00000001803F1490
	public static void CloseWindow(); // 0x00000001803F1260-0x00000001803F12B0
	public void Setup(string inTitle = "" /* Metadata: 0x0077CA24 */, string inMessage = "" /* Metadata: 0x0077CA28 */, string inOkBtnText = "" /* Metadata: 0x0077CA2C */, Action inOkCallback = null); // 0x00000001803F16E0-0x00000001803F1920
	public void BtnClicked_Ok(); // 0x00000001803F1230-0x00000001803F1260
	protected override void OnOpen(); // 0x00000001803F08A0-0x00000001803F0920
	protected override void OnClose(bool inAnimate); // 0x00000001803F0810-0x00000001803F08A0
	private void RefreshBodySize(); // 0x00000001803F1490-0x00000001803F16E0
	private void Update(); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Setup>b__10_0(); // 0x00000001803F1920-0x00000001803F1950
}

