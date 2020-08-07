/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ScreenSpaceTransformCanvas : ManagedBehaviour // TypeDefIndex: 13935
{
	// Fields
	public static UI_ScreenSpaceTransformCanvas instance; // 0x00
	private List<UI_ScreenSpaceTransform> _registeredTransforms; // 0x50
	private Canvas _canvas; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _namebarCanvas; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _sanctuaryItemCanvas; // 0x68

	// Properties
	public Canvas Canvas { get; } // 0x00000001804C4AD0-0x00000001804C4B50 

	// Nested types
	public enum ScreenSpaceTransformType // TypeDefIndex: 13936
	{
		Namebar = 0,
		SanctuaryItem = 5
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0<T> // TypeDefIndex: 13937
	{
		// Fields
		public Transform inTargetTransform;
		public Action<T> inResult;

		// Constructors
		public <>c__DisplayClass10_0();

		// Methods
		internal void <InstantiateFromBundleAndSetTarget>b__0(GameObject loadedGameObject);
	}

	// Constructors
	public UI_ScreenSpaceTransformCanvas(); // 0x00000001804C4A50-0x00000001804C4AD0

	// Methods
	private void OnHideNamebarsCommand(HideNamebarsCommand inMessage); // 0x00000001804C4780-0x00000001804C47D0
	public void Register(UI_ScreenSpaceTransform inTransform); // 0x00000001804C47D0-0x00000001804C4820
	public void Unregister(UI_ScreenSpaceTransform inTransform); // 0x00000001804C49F0-0x00000001804C4A50
	public QRoutine InstantiateFromBundleAndSetTarget<T>(string inBundleID, Transform inTargetTransform, ScreenSpaceTransformType inScreenSpaceTransformType, Action<T> inResult);
	public void ShowQuickMenu(UI_ActorBubble inBubble); // 0x00000001804C4950-0x00000001804C49C0
	public void ShowQuickMenu(string inUUID); // 0x00000001804C49C0-0x00000001804C49F0
	public override void MStart(); // 0x00000001804C4640-0x00000001804C46E0
	public override void OnDestroy(); // 0x00000001804C46E0-0x00000001804C4780
	public override void MOnEnable(); // 0x00000001804C4600-0x00000001804C4640
	public void SSTUpdate(); // 0x00000001804C4820-0x00000001804C4950
}

