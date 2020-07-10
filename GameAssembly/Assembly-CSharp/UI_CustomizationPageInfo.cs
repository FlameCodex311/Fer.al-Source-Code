/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CustomizationPageInfo : MonoBehaviour // TypeDefIndex: 11987
{
	// Fields
	[RootSelector] // 0x00000001800B7A60-0x00000001800B7AE0
	[SerializeField] // 0x00000001800B7A60-0x00000001800B7AE0
	private string _pageTitleDefId; // 0x20
	private LocalizationDef _localizationDef; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CustomizationPageInfo> _navLinks; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CustomizationControl> _controls; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _fullPageControl; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _designerModeOnly; // 0x48

	// Properties
	public string PageTitle { get; } // 0x0000000180F321A0-0x0000000180F322A0 
	public List<UI_CustomizationPageInfo> NavLinks { get; } // 0x0000000180397720-0x0000000180397730 
	public List<UI_CustomizationControl> Controls { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public Transform FullPageControl { get; } // 0x0000000180369B30-0x0000000180369B40 
	public bool DesignerModeOnly { get; } // 0x00000001805E3A60-0x00000001805E3A70 

	// Constructors
	public UI_CustomizationPageInfo(); // 0x0000000180F32110-0x0000000180F321A0

	// Methods
	public bool CheckIsValid(); // 0x0000000180F31EC0-0x0000000180F32100
	public void SetTitle(string inLocalizationDefId); // 0x0000000180F32100-0x0000000180F32110
	[DeMethodButton] // 0x00000001800B8550-0x00000001800B85B0
	public void AssignNavLinksFromChildren(); // 0x0000000180F31B30-0x0000000180F31EC0
}

