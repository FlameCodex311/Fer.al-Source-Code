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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class HexTile : MonoBehaviour // TypeDefIndex: 13147
{
	// Fields
	public HexCoord pos; // 0x20
	public RuneType runeType; // 0x28
	public Renderer runeRenderer; // 0x30
	public SpriteRenderer iconRenderer; // 0x38
	[EnumList] // 0x00000001800FC120-0x00000001800FC180
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
	public bool IsEmpty { get; } // 0x0000000181060100-0x0000000181060120 
	public bool IsCyclone { get; } // 0x00000001810600E0-0x0000000181060100 
	public bool IsStandardRune { get; } // 0x0000000181060140-0x0000000181060160 
	public bool IsPowerUp { get; } // 0x0000000181060120-0x0000000181060140 
	public int Score { get; set; } // 0x0000000181060160-0x0000000181060190 0x0000000181060190-0x00000001810602D0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 13148
	{
		// Fields
		public Action<HexTile> onEffectFinished; // 0x10
		public HexTile <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_1 // TypeDefIndex: 13149
	{
		// Fields
		public GameObject scoreIcon; // 0x10
		public <>c__DisplayClass36_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass36_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoTileScoredEffect>b__1(); // 0x0000000181066030-0x00000001810660E0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13150
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__36_0; // 0x08
		public static TweenCallback <>9__37_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001810662F0-0x0000000181066350
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoTileScoredEffect>b__36_0(); // 0x0000000181065D90-0x0000000181065DA0
		internal void <DoRuneIconRestoreEffect>b__37_0(); // 0x0000000181065D80-0x0000000181065D90
	}

	// Constructors
	public HexTile(); // 0x000000018105FFF0-0x00000001810600E0

	// Methods
	private void Start(); // 0x000000018105FB70-0x000000018105FD00
	public void SetPowerupAOEHighlight(bool inHighlighted); // 0x000000018105FA50-0x000000018105FB20
	public void SetPlacementHighlight(bool inHighlighted); // 0x000000018105F930-0x000000018105F9C0
	public void SetPlacementOutline(bool inOutlined); // 0x000000018105F9C0-0x000000018105FA50
	public void SetTileType(RuneType inRuneType); // 0x000000018105FB20-0x000000018105FB70
	public void RestorePreviousRuneType(); // 0x000000018105F8E0-0x000000018105F930
	public void UpdateFaceMaterial(); // 0x000000018105FD00-0x000000018105FFF0
	public void DoTileScoredEffect(int inCombo, Transform inAnimateTo, float delay, Action<HexTile> onEffectFinished); // 0x000000018105F050-0x000000018105F8E0
	public void DoRuneIconRestoreEffect(); // 0x000000018105EEF0-0x000000018105F050
	[DeMethodButton] // 0x00000001800FC430-0x00000001800FC4B0
	public void DebugUpdateScoreBy10(); // 0x000000018105EEB0-0x000000018105EEF0
}

