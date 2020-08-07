/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TooltipController : SingletonManagedBehaviour<UI_TooltipController> // TypeDefIndex: 13963
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _tooltipBounds; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _baseOffset; // 0x58
	private UI_TooltipBody _tooltipBody; // 0x60
	private List<UI_Tooltip> _targetCandidates; // 0x68
	private UI_Tooltip _currentTarget; // 0x70
	private Vector3[] _targetWorldCorners; // 0x78
	private Vector3[] _bodyWorldCorners; // 0x80
	private Vector3[] _boundsWorldCorners; // 0x88

	// Nested types
	public enum Side // TypeDefIndex: 13964
	{
		Top = 0,
		Bottom = 5,
		Left = 10,
		Right = 15
	}

	// Constructors
	public UI_TooltipController(); // 0x000000018063B550-0x000000018063B5E0

	// Methods
	public override void MStart(); // 0x000000018063A050-0x000000018063A170
	private void Init(); // 0x0000000180639F90-0x000000018063A050
	public void AddTooltipTarget(UI_Tooltip inTarget); // 0x00000001806395F0-0x0000000180639690
	public void RemoveTooltipTarget(UI_Tooltip inTarget); // 0x000000018063B2A0-0x000000018063B360
	public void NotifyTooltipTextChanged(UI_Tooltip inTarget); // 0x000000018063ADC0-0x000000018063AEB0
	public override void MUpdate(); // 0x000000018063A170-0x000000018063ADC0
	private void ClampPosition(); // 0x0000000180639690-0x0000000180639F90
	private void RefreshCurrentTarget(); // 0x000000018063AEB0-0x000000018063B2A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Init>b__10_0(GameObject loadedBody); // 0x000000018063B360-0x000000018063B500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshCurrentTarget>b__16_0(); // 0x000000018063B500-0x000000018063B550
}

