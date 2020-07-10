/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ApplyCreatureChanges : UI_Window // TypeDefIndex: 12392
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _avatarIcon; // 0x108
	private CreatureCustomizationTarget _currentCustomizationTarget; // 0x110
	private ActorInfo _oldActorInfo; // 0x118
	private Action<bool> _onProceedResult; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12393
	{
		// Fields
		public CreatureCustomizationTarget inCurrentCustomizationTarget; // 0x10
		public ActorInfo inOldActorInfo; // 0x18
		public Action<bool> inOnProceedResult; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ApplyCreatureChanges window); // 0x0000000180F8EB20-0x0000000180F8EB60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12394
	{
		// Fields
		public CreatureCustomizationTarget inCurrentCustomizationTarget; // 0x10
		public ActorInfo inOldActorInfo; // 0x18
		public Action<bool> inOnProceedResult; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F8EB60-0x0000000180F8EC40
	}

	// Constructors
	public UI_Window_ApplyCreatureChanges(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x0000000180F9F340-0x0000000180F9F420
	public static void QueueWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x0000000180F9F420-0x0000000180F9F500
	public static void CloseWindow(); // 0x0000000180F9F2F0-0x0000000180F9F340
	public void Setup(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x0000000180F9F500-0x0000000180F9F600
	public void BtnClicked_Apply(); // 0x0000000180F9F0D0-0x0000000180F9F190
	public void BtnClicked_Discard(); // 0x0000000180F9F210-0x0000000180F9F2F0
	public void BtnClicked_Cancel(); // 0x0000000180F9F190-0x0000000180F9F210
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

