/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SelectDecal : UI_Window // TypeDefIndex: 14199
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_DecalItem _decalItemPrefab; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWSmoothLayout _smoothLayout; // 0x110
	public Action<BaseDef> OnDecalSelected; // 0x118

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14200
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelectDecal> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B43A0-0x00000001803B4440
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelectDecal window); // 0x00000001803B24C0-0x00000001803B24F0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B26F0-0x00000001803B27B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 14201
	{
		// Fields
		public UI_DecalItem decalItem; // 0x10
		public UI_Window_SelectDecal <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x00000001803B3EA0-0x00000001803B3F20
	}

	// Constructors
	public UI_Window_SelectDecal(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803C0A80-0x00000001803C0B80
	public static void QueueWindow(); // 0x00000001803C0B80-0x00000001803C0C80
	public static void CloseWindow(); // 0x00000001803C09C0-0x00000001803C0A10
	public void Setup(Action<BaseDef> inOnDecalSelected); // 0x00000001803C0C80-0x00000001803C0FB0
	private void OnDecalItemClicked(UI_DecalItem inItem); // 0x00000001803C0A10-0x00000001803C0A80
}

