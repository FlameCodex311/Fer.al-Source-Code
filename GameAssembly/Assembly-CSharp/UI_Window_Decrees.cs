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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Decrees : UI_Window // TypeDefIndex: 11996
{
	// Fields
	[EnumList] // 0x00000001800BB160-0x00000001800BB1D0
	[SerializeField] // 0x00000001800BB160-0x00000001800BB1D0
	private List<UI_DecreeItem> _decreeItemTemplates; // 0x108
	[EnumList] // 0x00000001800BB5E0-0x00000001800BB650
	[SerializeField] // 0x00000001800BB5E0-0x00000001800BB650
	private List<Transform> _decreeCategoryParents; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _categoryHeaderText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x120

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11997
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Decrees> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFDA0-0x0000000180EFFE00
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Decrees window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFE890-0x0000000180EFE910
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnDecrees>d__10 : IAsyncStateMachine // TypeDefIndex: 11998
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Decrees <>4__this; // 0x28
		private UniTask<ListDecreesResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1340-0x00000001801F1350
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Decrees(); // 0x0000000180F0B340-0x0000000180F0B3D0

	// Methods
	public static void OpenWindow(); // 0x0000000180F0AEE0-0x0000000180F0AFE0
	public static void QueueWindow(); // 0x0000000180F0AFE0-0x0000000180F0B0E0
	public static void CloseWindow(); // 0x0000000180F0A910-0x0000000180F0A960
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F0ACA0-0x0000000180F0AE20
	protected override void OnClose(bool inAnimate); // 0x0000000180F0AC00-0x0000000180F0ACA0
	[AsyncStateMachine] // 0x00000001800BCC10-0x00000001800BCC60
	private void SpawnDecrees(); // 0x0000000180F0B290-0x0000000180F0B340
	private void SpawnDecree(DecreeItem inDecreeItem); // 0x0000000180F0B0E0-0x0000000180F0B290
	private void DespawnDecrees(); // 0x0000000180F0A960-0x0000000180F0AC00
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnTabSelected(int inTabIndex); // 0x0000000180F0AE20-0x0000000180F0AEE0
}

