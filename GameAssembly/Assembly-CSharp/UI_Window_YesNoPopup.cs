/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_YesNoPopup : UI_Window // TypeDefIndex: 11324
{
	// Fields
	[Header] // 0x0000000180288E70-0x0000000180288EC0
	[SerializeField] // 0x0000000180288E70-0x0000000180288EC0
	private GameObject _headerGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _yesBtnText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _noBtnText; // 0x128
	private Action<bool> _responseCallback; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11325
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_YesNoPopup window); // 0x00000001804482A0-0x00000001804482F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11326
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001804482F0-0x00000001804483E0
	}

	// Constructors
	public UI_Window_YesNoPopup(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inTitle = "" /* Metadata: 0x0077CA30 */, string inMessage = "" /* Metadata: 0x0077CA34 */, string inYesBtnText = "" /* Metadata: 0x0077CA38 */, string inNoBtnText = "" /* Metadata: 0x0077CA3C */, Action<bool> inResponseCallback = null); // 0x0000000180452270-0x0000000180452370
	public static void QueueWindow(string inTitle = "" /* Metadata: 0x0077CA40 */, string inMessage = "" /* Metadata: 0x0077CA44 */, string inYesBtnText = "" /* Metadata: 0x0077CA48 */, string inNoBtnText = "" /* Metadata: 0x0077CA4C */, Action<bool> inResponseCallback = null); // 0x0000000180452370-0x0000000180452470
	public static void CloseWindow(); // 0x0000000180452220-0x0000000180452270
	public void Setup(string inTitle = "" /* Metadata: 0x0077CA50 */, string inMessage = "" /* Metadata: 0x0077CA54 */, string inYesBtnText = "" /* Metadata: 0x0077CA58 */, string inNoBtnText = "" /* Metadata: 0x0077CA5C */, Action<bool> inResponseCallback = null); // 0x0000000180452470-0x00000001804526C0
	public void BtnClicked_Response(bool inResponse); // 0x00000001804521C0-0x0000000180452220
}

