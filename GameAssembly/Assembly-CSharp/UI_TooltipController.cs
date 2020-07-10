/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TooltipController : SingletonManagedBehaviour<UI_TooltipController> // TypeDefIndex: 12378
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _tooltipBounds; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _baseOffset; // 0x58
	private UI_TooltipBody _tooltipBody; // 0x60
	private List<UI_Tooltip> _targetCandidates; // 0x68
	private UI_Tooltip _currentTarget; // 0x70
	private Vector3[] _targetWorldCorners; // 0x78
	private Vector3[] _bodyWorldCorners; // 0x80
	private Vector3[] _boundsWorldCorners; // 0x88

	// Nested types
	public enum Side // TypeDefIndex: 12379
	{
		Top = 0,
		Bottom = 5,
		Left = 10,
		Right = 15
	}

	// Constructors
	public UI_TooltipController(); // 0x0000000180F9AC20-0x0000000180F9ACB0

	// Methods
	public override void MStart(); // 0x0000000180F996B0-0x0000000180F997D0
	private void Init(); // 0x0000000180F995F0-0x0000000180F996B0
	public void AddTooltipTarget(UI_Tooltip inTarget); // 0x0000000180F98BF0-0x0000000180F98C90
	public void RemoveTooltipTarget(UI_Tooltip inTarget); // 0x0000000180F9A960-0x0000000180F9AA20
	public void NotifyTooltipTextChanged(UI_Tooltip inTarget); // 0x0000000180F9A470-0x0000000180F9A560
	public override void MUpdate(); // 0x0000000180F997D0-0x0000000180F9A470
	private void ClampPosition(); // 0x0000000180F98C90-0x0000000180F995F0
	private void RefreshCurrentTarget(); // 0x0000000180F9A560-0x0000000180F9A960
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Init>b__10_0(GameObject loadedBody); // 0x0000000180F9AA20-0x0000000180F9ABD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshCurrentTarget>b__16_0(); // 0x0000000180F9ABD0-0x0000000180F9AC20
}

