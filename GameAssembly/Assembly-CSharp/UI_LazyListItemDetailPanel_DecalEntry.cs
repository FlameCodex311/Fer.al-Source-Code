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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_DecalEntry : UI_LazyListItemDetailPanel<ActorInfoDecalEntry> // TypeDefIndex: 12042
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LayerMask _raycastLayerMask; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _decalNameText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconImage; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconHighlightImage; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIHsvModifier _iconHSVModifier; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _enableDecalButton; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _layerUpButton; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _layerDownButton; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _mirrorDecalButton; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _sizeSlider; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _rotationSlider; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Control_HSVSliders _colorSliders; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_DecalEntry _itemList; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationNavPanel _navPanel; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
	private HSVColor DecalColor { get; set; } // 0x0000000180E69700-0x0000000180E69740 0x0000000180E697F0-0x0000000180E699B0
	private ActorInfo ActorInfo { get; } // 0x0000000180E696B0-0x0000000180E69700 
	private UI_Window_CreatureCustomization Window { get; } // 0x0000000180E69740-0x0000000180E697F0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 12043
	{
		// Fields
		public float pulse; // 0x10
		public UI_LazyListItemDetailPanel_DecalEntry <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal float <Setup>b__1(); // 0x0000000180493360-0x0000000180493370
		internal void <Setup>b__2(float alpha); // 0x0000000180BD7F10-0x0000000180BD7F20
		internal void <Setup>b__3(); // 0x0000000180E5A910-0x0000000180E5A9E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 12044
	{
		// Fields
		public UI_LazyListItemDetailPanel_DecalEntry <>4__this; // 0x10
		public ActorInfoDecalEntry entry; // 0x18

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked_DuplicateDecal>b__0(); // 0x0000000180E5A9E0-0x0000000180E5AA10
	}

	// Constructors
	public UI_LazyListItemDetailPanel_DecalEntry(); // 0x0000000180E695D0-0x0000000180E696B0

	// Methods
	private void SetupBodyPartLookup(); // 0x0000000180E68330-0x0000000180E68580
	public override void Setup(UI_LazyListItem<ActorInfoDecalEntry> inDataSrc); // 0x0000000180E68580-0x0000000180E68650
	private void Setup(ActorInfoDecalEntry inData); // 0x0000000180E68650-0x0000000180E68CC0
	public void BtnClicked_ChangeDecal(); // 0x0000000180E64110-0x0000000180E641A0
	public void BtnClicked_DuplicateDecal(); // 0x0000000180E64250-0x0000000180E64410
	public void BtnClicked_DeleteDecal(); // 0x0000000180E641A0-0x0000000180E64250
	public void BtnClicked_LayerUp(); // 0x0000000180E645D0-0x0000000180E646B0
	public void BtnClicked_LayerDown(); // 0x0000000180E644F0-0x0000000180E645D0
	public void BtnToggled_EnableDecal(bool inValue); // 0x0000000180E646B0-0x0000000180E64740
	public void BtnClicked_FlipDecalX(); // 0x0000000180E64410-0x0000000180E64480
	public void BtnClicked_FlipDecalY(); // 0x0000000180E64480-0x0000000180E644F0
	public void BtnToggled_MirrorDecal(bool inValue); // 0x0000000180E64740-0x0000000180E647D0
	public void PositionDecalAtDefaultPosition(ActorInfoDecalEntry inDecalToPosition = null); // 0x0000000180E64BF0-0x0000000180E651A0
	private void RefreshIcon(); // 0x0000000180E68040-0x0000000180E681C0
	private void RefreshIconColor(); // 0x0000000180E67F60-0x0000000180E68040
	private void RefreshLayerButtons(); // 0x0000000180E681C0-0x0000000180E68330
	private void SliderValueChanged_Size(float inScale); // 0x0000000180E68DA0-0x0000000180E68E80
	private void SliderValueChanged_Rotation(float inRotation); // 0x0000000180E68CC0-0x0000000180E68DA0
	private void Start(); // 0x0000000180E68E80-0x0000000180E68FB0
	private void Update(); // 0x0000000180E69220-0x0000000180E695D0
	private void RaycastAndAdjustDecal(Vector2 inPosition, ActorInfoDecalEntry inDecal); // 0x0000000180E651A0-0x0000000180E651D0
	private ValueTuple<RaycastHit?, RaycastHit?> RaycastMirrored(Vector2 inPosition, ActorInfoDecalEntry inDecal); // 0x0000000180E651D0-0x0000000180E67F60
	private void OnDecalCountChanged(int inDecalCount); // 0x0000000180E647D0-0x0000000180E64860
	protected override void OnEnable(); // 0x0000000180E64A80-0x0000000180E64BF0
	protected override void OnDisable(); // 0x0000000180E64860-0x0000000180E64A80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__31_0(HSVColor color); // 0x0000000180E691E0-0x0000000180E69220
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_ChangeDecal>b__32_0(UI_Window_SelectDecal window); // 0x0000000180E68FB0-0x0000000180E69040
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_ChangeDecal>b__32_1(BaseDef inSelectedDecalDef); // 0x0000000180E69040-0x0000000180E69160
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshIcon>b__42_0(Sprite loadedSprite); // 0x0000000180E69160-0x0000000180E691E0
}

