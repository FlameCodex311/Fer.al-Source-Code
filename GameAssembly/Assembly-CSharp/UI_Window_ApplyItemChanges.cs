/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ApplyItemChanges : UI_Window // TypeDefIndex: 13983
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _rawImage; // 0x108
	private Action<bool> _responseCallback; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13984
	{
		// Fields
		public Item inItem; // 0x10
		public Action<bool> inResponseCallback; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ApplyItemChanges window); // 0x0000000180634C70-0x0000000180634CA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13985
	{
		// Fields
		public Item inItem; // 0x10
		public Action<bool> inResponseCallback; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180635060-0x0000000180635130
	}

	// Constructors
	public UI_Window_ApplyItemChanges(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Item inItem, Action<bool> inResponseCallback = null); // 0x0000000180640430-0x0000000180640500
	public static void QueueWindow(Item inItem, Action<bool> inResponseCallback = null); // 0x0000000180640500-0x00000001806405D0
	public static void CloseWindow(); // 0x00000001806403E0-0x0000000180640430
	public void Setup(Item inItem, Action<bool> inResponseCallback = null); // 0x00000001806405D0-0x0000000180640670
	public void BtnClicked_Response(bool inResponse); // 0x0000000180640370-0x00000001806403E0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

