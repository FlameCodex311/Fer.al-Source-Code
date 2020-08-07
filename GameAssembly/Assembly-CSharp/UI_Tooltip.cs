/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Tooltip : ManagedBehaviour, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 13961
{
	// Fields
	private const float HOVER_TIME = 0.5f; // Metadata: 0x007BA5AC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TooltipController.Side _side; // 0x50
	[RootSelector] // 0x000000018024D020-0x000000018024D0A0
	[SerializeField] // 0x000000018024D020-0x000000018024D0A0
	private string _localizationDefId; // 0x58
	private string _text; // 0x60
	private string _default; // 0x68
	private string _overrideText; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _target; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _graphic; // 0x80
	private bool _hovered; // 0x88
	private float _hoverTimer; // 0x8C

	// Properties
	public UI_TooltipController.Side Side { get; } // 0x00000001803F8270-0x00000001803F8280 
	public string Text { get; } // 0x000000018063BEF0-0x000000018063BFC0 
	public RectTransform Target { get; } // 0x000000018063BE50-0x000000018063BEF0 
	public Graphic Graphic { get; } // 0x000000018040ED60-0x000000018040ED70 

	// Constructors
	public UI_Tooltip(); // 0x000000018063B920-0x000000018063B9A0

	// Methods
	protected virtual void Reset(); // 0x000000018063BC90-0x000000018063BD00
	public void SetOverridingText(string inText); // 0x00000001804C61A0-0x00000001804C61B0
	public override void MOnDestroy(); // 0x000000018063B9A0-0x000000018063BA20
	public override void OnDisable(); // 0x000000018063BB70-0x000000018063BBF0
	public override void MUpdate(); // 0x000000018063BA20-0x000000018063BB70
	public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018063BBF0-0x000000018063BC10
	public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018063BC10-0x000000018063BC90
	public void SetLocalizationDefId(string inDefId); // 0x000000018063BD00-0x000000018063BE50
}

