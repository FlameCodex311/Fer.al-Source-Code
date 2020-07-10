/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class UI_TextThemeData // TypeDefIndex: 13591
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x00783EBD
	[DeDisabled] // 0x00000001800CEC30-0x00000001800CEC80
	[SerializeField] // 0x00000001800CEC30-0x00000001800CEC80
	private string _id; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001800CF4E0-0x00000001800CF510
	[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
	private Color _color; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_FontAsset _fontAsset; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Material _fontMaterial; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _fontSize; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _autoSize; // 0x44
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _minFontSize; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxFontSize; // 0x4C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _fontStyle; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useGradient; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private VertexGradient _vertexGradient; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_ColorGradient _gradientPreset; // 0x98

	// Properties
	public string Id { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public string Name { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public Color Color { get; } // 0x0000000180CC6480-0x0000000180CC6490 
	public TMP_FontAsset FontAsset { get; } // 0x0000000180397720-0x0000000180397730 
	public Material FontMaterial { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public float FontSize { get; } // 0x0000000180487DB0-0x0000000180487DC0 
	public bool AutoSize { get; } // 0x000000018061F620-0x000000018061F630 
	public float MinFontSize { get; } // 0x0000000180487CC0-0x0000000180487CD0 
	public float MaxFontSize { get; } // 0x0000000180487D30-0x0000000180487D40 
	public int FontStyle { get; } // 0x0000000180369BA0-0x0000000180369BB0 
	public bool UseGradient { get; } // 0x0000000180F6A9C0-0x0000000180F6A9D0 
	public VertexGradient VertexGradient { get; } // 0x0000000180F94C00-0x0000000180F94C30 
	public TMP_ColorGradient GradientPreset { get; } // 0x0000000180369B70-0x0000000180369B80 

	// Constructors
	public UI_TextThemeData(); // 0x0000000180F94900-0x0000000180F949A0
	public UI_TextThemeData(string inId, string inName); // 0x0000000180F94B40-0x0000000180F94C00
	public UI_TextThemeData(string inId, string inName, WWTextMeshProUGUI inSrc); // 0x0000000180F949A0-0x0000000180F94B40

	// Methods
	[DeMethodButton] // 0x00000001800D5300-0x00000001800D5360
	public void SetDefaults(); // 0x0000000180F94840-0x0000000180F94900
	public void SetDataFromSrc(WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings = false /* Metadata: 0x00783EBC */); // 0x0000000180F94740-0x0000000180F94840
}

