/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CustomizationPageInfo : MonoBehaviour // TypeDefIndex: 13533
{
	// Fields
	[RootSelector] // 0x000000018025C7C0-0x000000018025C840
	[SerializeField] // 0x000000018025C7C0-0x000000018025C840
	private string _pageTitleDefId; // 0x20
	private LocalizationDef _localizationDef; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CustomizationPageInfo> _navLinks; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CustomizationControl> _controls; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _fullPageControl; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _designerModeOnly; // 0x48

	// Properties
	public string PageTitle { get; } // 0x000000018054F860-0x000000018054F960 
	public List<UI_CustomizationPageInfo> NavLinks { get; } // 0x00000001803745C0-0x00000001803745D0 
	public List<UI_CustomizationControl> Controls { get; } // 0x00000001803743D0-0x00000001803743E0 
	public Transform FullPageControl { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public bool DesignerModeOnly { get; } // 0x00000001803C9D60-0x00000001803C9D70 

	// Constructors
	public UI_CustomizationPageInfo(); // 0x000000018054F7D0-0x000000018054F860

	// Methods
	public bool CheckIsValid(); // 0x000000018054F590-0x000000018054F7C0
	public void SetTitle(string inLocalizationDefId); // 0x000000018054F7C0-0x000000018054F7D0
	[DeMethodButton] // 0x000000018025CD10-0x000000018025CD70
	public void AssignNavLinksFromChildren(); // 0x000000018054F200-0x000000018054F590
}

