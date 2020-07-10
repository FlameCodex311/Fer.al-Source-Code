/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ShopDialogController : MonoBehaviour // TypeDefIndex: 12210
{
	// Fields
	[RootSelector] // 0x000000018010E4D0-0x000000018010E540
	[SerializeField] // 0x000000018010E4D0-0x000000018010E540
	private string _nameDefId; // 0x20
	[RootSelector] // 0x000000018010E850-0x000000018010E8C0
	[SerializeField] // 0x000000018010E850-0x000000018010E8C0
	private string _iconDefId; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private DialogueTreeController _introController; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private DialogueTreeController _craftedController; // 0x38

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 12211
	{
		// Fields
		public ShopDialogController <>4__this; // 0x10
		public Transform cTransform; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnEnable>b__0(UI_Window_Dialog inWindow); // 0x0000000180EC9020-0x0000000180EC9070
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12212
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__5_0; // 0x08
		public static Func<bool> <>9__6_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EC9070-0x0000000180EC90D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ShowIntroDialog>b__5_0(); // 0x0000000180EC8A20-0x0000000180EC8AA0
		internal bool <ShowCraftedDialog>b__6_0(); // 0x0000000180EC89A0-0x0000000180EC8A20
	}

	// Constructors
	public ShopDialogController(); // 0x0000000180EC1A30-0x0000000180EC1A80

	// Methods
	private void OnEnable(); // 0x0000000180EC1670-0x0000000180EC17D0
	public void ShowIntroDialog(); // 0x0000000180EC18E0-0x0000000180EC19F0
	public void ShowCraftedDialog(); // 0x0000000180EC17D0-0x0000000180EC18E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowIntroDialog>b__5_1(); // 0x0000000180EC1A10-0x0000000180EC1A30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowCraftedDialog>b__6_1(); // 0x0000000180EC19F0-0x0000000180EC1A10
}

