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

public class UI_Window_ChangeDisplayName : UI_Window // TypeDefIndex: 14013
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _submitBtn; // 0x108
	[Header] // 0x0000000180252300-0x0000000180252350
	[SerializeField] // 0x0000000180252300-0x0000000180252350
	private UI_FieldStatusIndicator _usernameStatusIndicator; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _usernameInput; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _usernameErrorText; // 0x120
	private string _renameRequiredKey; // 0x128
	private bool _renaming; // 0x130
	private Action _renameSuccessCallback; // 0x138

	// Properties
	private string Username { get; set; } // 0x0000000180480F50-0x0000000180480F70 0x0000000180480F70-0x0000000180481000

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14014
	{
		// Fields
		public string inRenameRequiredKey; // 0x10
		public Action inRenameSuccessCallback; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ChangeDisplayName window); // 0x000000018047E7F0-0x000000018047E820
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14015
	{
		// Fields
		public string inRenameRequiredKey; // 0x10
		public Action inRenameSuccessCallback; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047E9F0-0x000000018047EAC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoRename>d__21 : IAsyncStateMachine // TypeDefIndex: 14016
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_ChangeDisplayName <>4__this; // 0x28
		private TaskAwaiter<WWWResponse<RenameDisplayNameResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004A30-0x0000000180004A40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_ChangeDisplayName(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inRenameRequiredKey, Action inRenameSuccessCallback); // 0x0000000180480C40-0x0000000180480D10
	public static void QueueWindow(string inRenameRequiredKey, Action inRenameSuccessCallback); // 0x0000000180480D10-0x0000000180480DE0
	public static void CloseWindow(); // 0x00000001804809F0-0x0000000180480A40
	private void Setup(string inRenameRequiredKey, Action inRenameSuccessCallback); // 0x0000000180480E30-0x0000000180480F50
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void OnInputFieldChanged_Username(string inValue); // 0x0000000180480A40-0x0000000180480B70
	private void OnInputFieldSubmit_Username(string inValue); // 0x0000000180480B70-0x0000000180480C40
	public void BtnClicked_Submit(); // 0x0000000180480940-0x00000001804809F0
	private void Refresh(); // 0x0000000180480DE0-0x0000000180480E30
	[AsyncStateMachine] // 0x000000018025E0D0-0x000000018025E120
	private void DoRename(); // 0x0000000180480940-0x00000001804809F0
}

