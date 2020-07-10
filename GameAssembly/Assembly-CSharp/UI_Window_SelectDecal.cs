/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SelectDecal : UI_Window // TypeDefIndex: 12597
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_DecalItem _decalItemPrefab; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothLayout _smoothLayout; // 0x110
	public Action<BaseDef> OnDecalSelected; // 0x118

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12598
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelectDecal> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9F510-0x0000000180E9F570
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelectDecal window); // 0x0000000180E9D0A0-0x0000000180E9D0D0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D2D0-0x0000000180E9D390
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12599
	{
		// Fields
		public UI_DecalItem decalItem; // 0x10
		public UI_Window_SelectDecal <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000180E9EFB0-0x0000000180E9F030
	}

	// Constructors
	public UI_Window_SelectDecal(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EAA680-0x0000000180EAA780
	public static void QueueWindow(); // 0x0000000180EAA780-0x0000000180EAA880
	public static void CloseWindow(); // 0x0000000180EAA5C0-0x0000000180EAA610
	public void Setup(Action<BaseDef> inOnDecalSelected); // 0x0000000180EAA880-0x0000000180EAABC0
	private void OnDecalItemClicked(UI_DecalItem inItem); // 0x0000000180EAA610-0x0000000180EAA680
}

