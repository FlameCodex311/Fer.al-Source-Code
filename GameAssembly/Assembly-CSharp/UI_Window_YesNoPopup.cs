/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_YesNoPopup : UI_Window // TypeDefIndex: 13657
{
	// Fields
	[Header] // 0x00000001800EB8D0-0x00000001800EB920
	[SerializeField] // 0x00000001800EB8D0-0x00000001800EB920
	private GameObject _headerGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _yesBtnText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _noBtnText; // 0x128
	private Action<bool> _responseCallback; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13658
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_YesNoPopup window); // 0x0000000180EFEEA0-0x0000000180EFEEF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 13659
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7B280-0x0000000180F7B370
	}

	// Constructors
	public UI_Window_YesNoPopup(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(string inTitle = "" /* Metadata: 0x00783F71 */, string inMessage = "" /* Metadata: 0x00783F75 */, string inYesBtnText = "" /* Metadata: 0x00783F79 */, string inNoBtnText = "" /* Metadata: 0x00783F7D */, Action<bool> inResponseCallback = null); // 0x0000000180F863E0-0x0000000180F864E0
	public static void QueueWindow(string inTitle = "" /* Metadata: 0x00783F81 */, string inMessage = "" /* Metadata: 0x00783F85 */, string inYesBtnText = "" /* Metadata: 0x00783F89 */, string inNoBtnText = "" /* Metadata: 0x00783F8D */, Action<bool> inResponseCallback = null); // 0x0000000180F864E0-0x0000000180F865E0
	public static void CloseWindow(); // 0x0000000180F86390-0x0000000180F863E0
	public void Setup(string inTitle = "" /* Metadata: 0x00783F91 */, string inMessage = "" /* Metadata: 0x00783F95 */, string inYesBtnText = "" /* Metadata: 0x00783F99 */, string inNoBtnText = "" /* Metadata: 0x00783F9D */, Action<bool> inResponseCallback = null); // 0x0000000180F865E0-0x0000000180F86840
	public void BtnClicked_Response(bool inResponse); // 0x0000000180F86330-0x0000000180F86390
}

