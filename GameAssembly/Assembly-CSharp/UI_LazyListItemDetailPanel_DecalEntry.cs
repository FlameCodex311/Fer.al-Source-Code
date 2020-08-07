/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_DecalEntry : UI_LazyListItemDetailPanel<ActorInfoDecalEntry> // TypeDefIndex: 13581
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LayerMask _raycastLayerMask; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _decalNameText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconImage; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconHighlightImage; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIHsvModifier _iconHSVModifier; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _enableDecalButton; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _layerUpButton; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _layerDownButton; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _mirrorDecalButton; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _sizeSlider; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _rotationSlider; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Control_HSVSliders _colorSliders; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_DecalEntry _itemList; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationNavPanel _navPanel; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _duplicateDecalButton; // 0xA8
	private HSVColor _decalColor; // 0xB0
	private ActorInfoBodyPart _bodyPart; // 0xE8
	private Dictionary<Collider, ActorInfoBodyPart> _bodyPartLookup; // 0xF0
	private bool _isDraggingDecal; // 0xF8
	private Tweener _pulseTween; // 0x100
	private ActorInfoDecalEntry _data; // 0x108
	private UI_Window_CreatureCustomization _window; // 0x110
	private float? _lastGoodVerticalAngle; // 0x118
	private float? _lastGoodMirrorVerticalAngle; // 0x120

	// Properties
	private HSVColor DecalColor { get; set; } // 0x000000018039B060-0x000000018039B0A0 0x000000018039B150-0x000000018039B310
	private ActorInfo ActorInfo { get; } // 0x000000018039B010-0x000000018039B060 
	private UI_Window_CreatureCustomization Window { get; } // 0x000000018039B0A0-0x000000018039B150 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 13582
	{
		// Fields
		public float pulse; // 0x10
		public UI_LazyListItemDetailPanel_DecalEntry <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal float <Setup>b__1(); // 0x0000000180373AA0-0x0000000180373AB0
		internal void <Setup>b__2(float alpha); // 0x0000000180373AB0-0x0000000180373AC0
		internal void <Setup>b__3(); // 0x0000000180387D10-0x0000000180387DE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 13583
	{
		// Fields
		public UI_LazyListItemDetailPanel_DecalEntry <>4__this; // 0x10
		public ActorInfoDecalEntry entry; // 0x18

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked_DuplicateDecal>b__0(); // 0x0000000180387DE0-0x0000000180387E10
	}

	// Constructors
	public UI_LazyListItemDetailPanel_DecalEntry(); // 0x000000018039AF30-0x000000018039B010

	// Methods
	private void SetupBodyPartLookup(); // 0x0000000180399CE0-0x0000000180399F20
	public override void Setup(UI_LazyListItem<ActorInfoDecalEntry> inDataSrc); // 0x0000000180399F20-0x0000000180399FF0
	private void Setup(ActorInfoDecalEntry inData); // 0x0000000180399FF0-0x000000018039A640
	public void BtnClicked_ChangeDecal(); // 0x0000000180395BD0-0x0000000180395C60
	public void BtnClicked_DuplicateDecal(); // 0x0000000180395D10-0x0000000180395ED0
	public void BtnClicked_DeleteDecal(); // 0x0000000180395C60-0x0000000180395D10
	public void BtnClicked_LayerUp(); // 0x0000000180396090-0x0000000180396170
	public void BtnClicked_LayerDown(); // 0x0000000180395FB0-0x0000000180396090
	public void BtnToggled_EnableDecal(bool inValue); // 0x0000000180396170-0x0000000180396200
	public void BtnClicked_FlipDecalX(); // 0x0000000180395ED0-0x0000000180395F40
	public void BtnClicked_FlipDecalY(); // 0x0000000180395F40-0x0000000180395FB0
	public void BtnToggled_MirrorDecal(bool inValue); // 0x0000000180396200-0x0000000180396290
	public void PositionDecalAtDefaultPosition(ActorInfoDecalEntry inDecalToPosition = null); // 0x0000000180396690-0x0000000180396C30
	private void RefreshIcon(); // 0x0000000180399A00-0x0000000180399B80
	private void RefreshIconColor(); // 0x0000000180399930-0x0000000180399A00
	private void RefreshLayerButtons(); // 0x0000000180399B80-0x0000000180399CE0
	private void SliderValueChanged_Size(float inScale); // 0x000000018039A720-0x000000018039A800
	private void SliderValueChanged_Rotation(float inRotation); // 0x000000018039A640-0x000000018039A720
	private void Start(); // 0x000000018039A800-0x000000018039A930
	private void Update(); // 0x000000018039AB90-0x000000018039AF30
	private void RaycastAndAdjustDecal(Vector2 inPosition, ActorInfoDecalEntry inDecal); // 0x0000000180396C30-0x0000000180396C60
	private ValueTuple<RaycastHit?, RaycastHit?> RaycastMirrored(Vector2 inPosition, ActorInfoDecalEntry inDecal); // 0x0000000180396C60-0x0000000180399930
	private void OnDecalCountChanged(int inDecalCount); // 0x0000000180396290-0x0000000180396320
	protected override void OnEnable(); // 0x0000000180396530-0x0000000180396690
	protected override void OnDisable(); // 0x0000000180396320-0x0000000180396530
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__31_0(HSVColor color); // 0x000000018039AB50-0x000000018039AB90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_ChangeDecal>b__32_0(UI_Window_SelectDecal window); // 0x000000018039A930-0x000000018039A9B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_ChangeDecal>b__32_1(BaseDef inSelectedDecalDef); // 0x000000018039A9B0-0x000000018039AAD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshIcon>b__42_0(Sprite loadedSprite); // 0x000000018039AAD0-0x000000018039AB50
}

