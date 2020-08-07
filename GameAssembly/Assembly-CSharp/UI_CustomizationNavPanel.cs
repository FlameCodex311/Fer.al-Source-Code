/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CustomizationNavPanel : MonoBehaviour // TypeDefIndex: 13530
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageNavigationController _navigationController; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationBreadcrumb _breadcrumbPrefab; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _breadcrumbDividerPrefab; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _breadcrumbLayout; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _backButton; // 0x40
	private List<GameObject> _breadCrumbItems; // 0x48
	private bool? _allowBack; // 0x50

	// Constructors
	public UI_CustomizationNavPanel(); // 0x000000018054E380-0x000000018054E3E0

	// Methods
	public void BtnClicked_Back(); // 0x000000018054DA20-0x000000018054DAA0
	public void Refresh(UI_CustomizationPageInfo inCurrentPage); // 0x000000018054DAB0-0x000000018054E2B0
	private void Start(); // 0x000000018054E2B0-0x000000018054E380
	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo); // 0x000000018054DAA0-0x000000018054DAB0
}

