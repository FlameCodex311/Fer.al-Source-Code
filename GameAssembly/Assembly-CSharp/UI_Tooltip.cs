/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Tooltip : ManagedBehaviour, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 12376
{
	// Fields
	private const float HOVER_TIME = 0.5f; // Metadata: 0x00782E95
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TooltipController.Side _side; // 0x50
	[RootSelector] // 0x0000000180157AC0-0x0000000180157B40
	[SerializeField] // 0x0000000180157AC0-0x0000000180157B40
	private string _localizationDefId; // 0x58
	private string _text; // 0x60
	private string _default; // 0x68
	private string _overrideText; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _target; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _graphic; // 0x80
	private bool _hovered; // 0x88
	private float _hoverTimer; // 0x8C

	// Properties
	public UI_TooltipController.Side Side { get; } // 0x0000000180369BA0-0x0000000180369BB0 
	public string Text { get; } // 0x0000000180F9B5D0-0x0000000180F9B6A0 
	public RectTransform Target { get; } // 0x0000000180F9B530-0x0000000180F9B5D0 
	public Graphic Graphic { get; } // 0x000000018035FCB0-0x000000018035FCC0 

	// Constructors
	public UI_Tooltip(); // 0x0000000180F9B000-0x0000000180F9B080

	// Methods
	protected virtual void Reset(); // 0x0000000180F9B370-0x0000000180F9B3E0
	public void SetOverridingText(string inText); // 0x00000001803C87F0-0x00000001803C8800
	public override void MOnDestroy(); // 0x0000000180F9B080-0x0000000180F9B100
	public override void OnDisable(); // 0x0000000180F9B250-0x0000000180F9B2D0
	public override void MUpdate(); // 0x0000000180F9B100-0x0000000180F9B250
	public virtual void OnPointerEnter(PointerEventData eventData); // 0x0000000180F9B2D0-0x0000000180F9B2F0
	public virtual void OnPointerExit(PointerEventData eventData); // 0x0000000180F9B2F0-0x0000000180F9B370
	public void SetLocalizationDefId(string inDefId); // 0x0000000180F9B3E0-0x0000000180F9B530
}

