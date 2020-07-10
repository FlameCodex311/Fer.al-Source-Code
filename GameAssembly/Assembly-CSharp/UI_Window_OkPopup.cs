/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteAlways] // 0x00000001800B36B0-0x00000001800B36C0
public class UI_Window_OkPopup : UI_Window // TypeDefIndex: 13653
{
	// Fields
	[Header] // 0x00000001800E9F80-0x00000001800E9FD0
	[SerializeField] // 0x00000001800E9F80-0x00000001800E9FD0
	protected RectTransform _rootLayout; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _body; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WWTextMeshProUGUI _titleText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WWTextMeshProUGUI _messageText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WWTextMeshProUGUI _okBtnText; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<SizeBucket> _sizeBuckets; // 0x130
	private Action _okCallback; // 0x138

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 13654
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkPopup window); // 0x0000000180ECE2A0-0x0000000180ECE2E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 13655
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECF310-0x0000000180ECF3F0
	}

	// Constructors
	public UI_Window_OkPopup(); // 0x0000000180EDD320-0x0000000180EDD390

	// Methods
	public static void OpenWindow(string inTitle = "" /* Metadata: 0x00783F4D */, string inMessage = "" /* Metadata: 0x00783F51 */, string inOkBtnText = "" /* Metadata: 0x00783F55 */, Action inOkCallback = null); // 0x0000000180EDDAE0-0x0000000180EDDBD0
	public static void QueueWindow(string inTitle = "" /* Metadata: 0x00783F59 */, string inMessage = "" /* Metadata: 0x00783F5D */, string inOkBtnText = "" /* Metadata: 0x00783F61 */, Action inOkCallback = null); // 0x0000000180EDDBD0-0x0000000180EDDCC0
	public static void CloseWindow(); // 0x0000000180EDDA90-0x0000000180EDDAE0
	public void Setup(string inTitle = "" /* Metadata: 0x00783F65 */, string inMessage = "" /* Metadata: 0x00783F69 */, string inOkBtnText = "" /* Metadata: 0x00783F6D */, Action inOkCallback = null); // 0x0000000180EDDF20-0x0000000180EDE160
	public void BtnClicked_Ok(); // 0x0000000180EDDA60-0x0000000180EDDA90
	protected override void OnOpen(); // 0x0000000180EDD0C0-0x0000000180EDD140
	protected override void OnClose(bool inAnimate); // 0x0000000180EDD030-0x0000000180EDD0C0
	private void RefreshBodySize(); // 0x0000000180EDDCC0-0x0000000180EDDF20
	private void Update(); // 0x00000001803581E0-0x00000001803581F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Setup>b__10_0(); // 0x0000000180EDE160-0x0000000180EDE190
}

