/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ScreenSpaceTransformCanvas : ManagedBehaviour // TypeDefIndex: 12351
{
	// Fields
	public static UI_ScreenSpaceTransformCanvas instance; // 0x00
	private List<UI_ScreenSpaceTransform> _registeredTransforms; // 0x50
	private Canvas _canvas; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _namebarCanvas; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _sanctuaryItemCanvas; // 0x68

	// Properties
	public Canvas Canvas { get; } // 0x0000000180EF0190-0x0000000180EF0210 

	// Nested types
	public enum ScreenSpaceTransformType // TypeDefIndex: 12352
	{
		Namebar = 0,
		SanctuaryItem = 5
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0<T> // TypeDefIndex: 12353
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
	public UI_ScreenSpaceTransformCanvas(); // 0x0000000180EF0110-0x0000000180EF0190

	// Methods
	private void OnHideNamebarsCommand(HideNamebarsCommand inMessage); // 0x0000000180EEFE30-0x0000000180EEFE80
	public void Register(UI_ScreenSpaceTransform inTransform); // 0x0000000180EEFE80-0x0000000180EEFED0
	public void Unregister(UI_ScreenSpaceTransform inTransform); // 0x0000000180EF00B0-0x0000000180EF0110
	public QRoutine InstantiateFromBundleAndSetTarget<T>(string inBundleID, Transform inTargetTransform, ScreenSpaceTransformType inScreenSpaceTransformType, Action<T> inResult);
	public void ShowQuickMenu(UI_ActorBubble inBubble); // 0x0000000180EF0000-0x0000000180EF0080
	public void ShowQuickMenu(string inUUID); // 0x0000000180EF0080-0x0000000180EF00B0
	public override void MStart(); // 0x0000000180EEFCF0-0x0000000180EEFD90
	public override void OnDestroy(); // 0x0000000180EEFD90-0x0000000180EEFE30
	public override void MOnEnable(); // 0x0000000180EEFCB0-0x0000000180EEFCF0
	public void SSTUpdate(); // 0x0000000180EEFED0-0x0000000180EF0000
}

