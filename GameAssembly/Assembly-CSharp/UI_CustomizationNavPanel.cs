/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CustomizationNavPanel : MonoBehaviour // TypeDefIndex: 11984
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageNavigationController _navigationController; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationBreadcrumb _breadcrumbPrefab; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _breadcrumbDividerPrefab; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _breadcrumbLayout; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _backButton; // 0x40
	private List<GameObject> _breadCrumbItems; // 0x48
	private bool? _allowBack; // 0x50

	// Constructors
	public UI_CustomizationNavPanel(); // 0x0000000180F30C60-0x0000000180F30CC0

	// Methods
	public void BtnClicked_Back(); // 0x0000000180F302C0-0x0000000180F30340
	public void Refresh(UI_CustomizationPageInfo inCurrentPage); // 0x0000000180F30350-0x0000000180F30B90
	private void Start(); // 0x0000000180F30B90-0x0000000180F30C60
	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo); // 0x0000000180F30340-0x0000000180F30350
}

