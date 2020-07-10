/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ApplyItemChanges : UI_Window // TypeDefIndex: 12395
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _rawImage; // 0x108
	private Action<bool> _responseCallback; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12396
	{
		// Fields
		public Item inItem; // 0x10
		public Action<bool> inResponseCallback; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ApplyItemChanges window); // 0x0000000180EFEDF0-0x0000000180EFEE20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12397
	{
		// Fields
		public Item inItem; // 0x10
		public Action<bool> inResponseCallback; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF900-0x0000000180EFF9D0
	}

	// Constructors
	public UI_Window_ApplyItemChanges(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Item inItem, Action<bool> inResponseCallback = null); // 0x0000000180F9F6C0-0x0000000180F9F790
	public static void QueueWindow(Item inItem, Action<bool> inResponseCallback = null); // 0x0000000180F9F790-0x0000000180F9F860
	public static void CloseWindow(); // 0x0000000180F9F670-0x0000000180F9F6C0
	public void Setup(Item inItem, Action<bool> inResponseCallback = null); // 0x0000000180F9F860-0x0000000180F9F900
	public void BtnClicked_Response(bool inResponse); // 0x0000000180F9F600-0x0000000180F9F670
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

