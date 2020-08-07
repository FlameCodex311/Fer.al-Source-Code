/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class HexTile : MonoBehaviour // TypeDefIndex: 10812
{
	// Fields
	public HexCoord pos; // 0x20
	public RuneType runeType; // 0x28
	public Renderer runeRenderer; // 0x30
	public SpriteRenderer iconRenderer; // 0x38
	[EnumList] // 0x00000001801CEA10-0x00000001801CEA70
	public List<Sprite> icons; // 0x40
	public TextMeshPro textRenderer; // 0x48
	public GameObject aoeHighlight; // 0x50
	public DOTweenAnimator aoeTween; // 0x58
	public GameObject placementHighlight; // 0x60
	public GameObject placementOutline; // 0x68
	public DOTweenAnimator placementTween; // 0x70
	public Material sharedRuneMaterial; // 0x78
	private Material _runeMaterial; // 0x80
	private RuneType _prevRuneType; // 0x88
	private Vector3 _originalScale; // 0x8C
	private ObscuredInt _score; // 0x98
	private List<GameObject> _scoreIcons; // 0xB0
	private List<Sequence> _sequences; // 0xB8

	// Properties
	public bool IsEmpty { get; } // 0x000000018061E110-0x000000018061E130 
	public bool IsCyclone { get; } // 0x000000018061E0F0-0x000000018061E110 
	public bool IsStandardRune { get; } // 0x000000018061E150-0x000000018061E170 
	public bool IsPowerUp { get; } // 0x000000018061E130-0x000000018061E150 
	public int Score { get; set; } // 0x000000018061E170-0x000000018061E1A0 0x000000018061E1A0-0x000000018061E2E0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 10813
	{
		// Fields
		public Action<HexTile> onEffectFinished; // 0x10
		public HexTile <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_1 // TypeDefIndex: 10814
	{
		// Fields
		public GameObject scoreIcon; // 0x10
		public <>c__DisplayClass36_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass36_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoTileScoredEffect>b__1(); // 0x00000001806313F0-0x0000000180631490
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10815
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__36_0; // 0x08
		public static TweenCallback <>9__37_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001806316F0-0x0000000180631750
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoTileScoredEffect>b__36_0(); // 0x0000000180630520-0x0000000180630530
		internal void <DoRuneIconRestoreEffect>b__37_0(); // 0x0000000180630510-0x0000000180630520
	}

	// Constructors
	public HexTile(); // 0x000000018061E000-0x000000018061E0F0

	// Methods
	private void Start(); // 0x000000018061DB90-0x000000018061DD20
	public void SetPowerupAOEHighlight(bool inHighlighted); // 0x000000018061DA70-0x000000018061DB40
	public void SetPlacementHighlight(bool inHighlighted); // 0x000000018061D950-0x000000018061D9E0
	public void SetPlacementOutline(bool inOutlined); // 0x000000018061D9E0-0x000000018061DA70
	public void SetTileType(RuneType inRuneType); // 0x000000018061DB40-0x000000018061DB90
	public void RestorePreviousRuneType(); // 0x000000018061D900-0x000000018061D950
	public void UpdateFaceMaterial(); // 0x000000018061DD20-0x000000018061E000
	public void DoTileScoredEffect(int inCombo, Transform inAnimateTo, float delay, Action<HexTile> onEffectFinished); // 0x000000018061D090-0x000000018061D900
	public void DoRuneIconRestoreEffect(); // 0x000000018061CF30-0x000000018061D090
	[DeMethodButton] // 0x00000001801CECC0-0x00000001801CED40
	public void DebugUpdateScoreBy10(); // 0x000000018061CEF0-0x000000018061CF30
}

