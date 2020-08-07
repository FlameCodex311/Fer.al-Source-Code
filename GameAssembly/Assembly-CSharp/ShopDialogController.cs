/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ShopDialogController : MonoBehaviour // TypeDefIndex: 13760
{
	// Fields
	[RootSelector] // 0x00000001801F14C0-0x00000001801F1530
	[SerializeField] // 0x00000001801F14C0-0x00000001801F1530
	private string _nameDefId; // 0x20
	[RootSelector] // 0x00000001801F17D0-0x00000001801F1840
	[SerializeField] // 0x00000001801F17D0-0x00000001801F1840
	private string _iconDefId; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DialogueTreeController _introController; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DialogueTreeController _craftedController; // 0x38

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 13761
	{
		// Fields
		public ShopDialogController <>4__this; // 0x10
		public Transform cTransform; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnEnable>b__0(UI_Window_Dialog inWindow); // 0x0000000180777A70-0x0000000180777AC0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13762
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__5_0; // 0x08
		public static Func<bool> <>9__6_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180777B20-0x0000000180777B80
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ShowIntroDialog>b__5_0(); // 0x0000000180777180-0x0000000180777200
		internal bool <ShowCraftedDialog>b__6_0(); // 0x0000000180777100-0x0000000180777180
	}

	// Constructors
	public ShopDialogController(); // 0x000000018076B4E0-0x000000018076B530

	// Methods
	private void OnEnable(); // 0x000000018076B110-0x000000018076B280
	public void ShowIntroDialog(); // 0x000000018076B390-0x000000018076B4A0
	public void ShowCraftedDialog(); // 0x000000018076B280-0x000000018076B390
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowIntroDialog>b__5_1(); // 0x000000018076B4C0-0x000000018076B4E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowCraftedDialog>b__6_1(); // 0x000000018076B4A0-0x000000018076B4C0
}

