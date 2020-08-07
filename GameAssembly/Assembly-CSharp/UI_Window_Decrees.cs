/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Decrees : UI_Window // TypeDefIndex: 13542
{
	// Fields
	[EnumList] // 0x000000018025E240-0x000000018025E2B0
	[SerializeField] // 0x000000018025E240-0x000000018025E2B0
	private List<UI_DecreeItem> _decreeItemTemplates; // 0x108
	[EnumList] // 0x000000018025E570-0x000000018025E5E0
	[SerializeField] // 0x000000018025E570-0x000000018025E5E0
	private List<Transform> _decreeCategoryParents; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _categoryHeaderText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x120

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13543
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Decrees> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F4D0-0x000000018047F530
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Decrees window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x000000018047E280-0x000000018047E300
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnDecrees>d__10 : IAsyncStateMachine // TypeDefIndex: 13544
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Decrees <>4__this; // 0x28
		private UniTask<ListDecreesResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004AA0-0x0000000180004AB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Decrees(); // 0x0000000180489520-0x00000001804895B0

	// Methods
	public static void OpenWindow(); // 0x00000001804890C0-0x00000001804891C0
	public static void QueueWindow(); // 0x00000001804891C0-0x00000001804892C0
	public static void CloseWindow(); // 0x0000000180488AF0-0x0000000180488B40
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x0000000180488E80-0x0000000180489000
	protected override void OnClose(bool inAnimate); // 0x0000000180488DE0-0x0000000180488E80
	[AsyncStateMachine] // 0x000000018025EA70-0x000000018025EAC0
	private void SpawnDecrees(); // 0x0000000180489470-0x0000000180489520
	private void SpawnDecree(DecreeItem inDecreeItem); // 0x00000001804892C0-0x0000000180489470
	private void DespawnDecrees(); // 0x0000000180488B40-0x0000000180488DE0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnTabSelected(int inTabIndex); // 0x0000000180489000-0x00000001804890C0
}

