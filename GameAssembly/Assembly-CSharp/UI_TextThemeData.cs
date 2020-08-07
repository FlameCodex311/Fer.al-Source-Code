/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class UI_TextThemeData // TypeDefIndex: 11258
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x0077C97C
	[DeDisabled] // 0x0000000180268E70-0x0000000180268EC0
	[SerializeField] // 0x0000000180268E70-0x0000000180268EC0
	private string _id; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001801E0E00-0x00000001801E0E30
	[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
	private Color _color; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_FontAsset _fontAsset; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Material _fontMaterial; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _fontSize; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _autoSize; // 0x44
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _minFontSize; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxFontSize; // 0x4C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _fontStyle; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useGradient; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private VertexGradient _vertexGradient; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_ColorGradient _gradientPreset; // 0x98

	// Properties
	public string Id { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public string Name { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public Color Color { get; } // 0x00000001804A4210-0x00000001804A4220 
	public TMP_FontAsset FontAsset { get; } // 0x00000001803745C0-0x00000001803745D0 
	public Material FontMaterial { get; } // 0x00000001803743D0-0x00000001803743E0 
	public float FontSize { get; } // 0x00000001804D5800-0x00000001804D5810 
	public bool AutoSize { get; } // 0x0000000180379EB0-0x0000000180379EC0 
	public float MinFontSize { get; } // 0x00000001804D5810-0x00000001804D5820 
	public float MaxFontSize { get; } // 0x0000000180379EA0-0x0000000180379EB0 
	public int FontStyle { get; } // 0x00000001803F8270-0x00000001803F8280 
	public bool UseGradient { get; } // 0x00000001804D5820-0x00000001804D5830 
	public VertexGradient VertexGradient { get; } // 0x00000001804D5830-0x00000001804D5860 
	public TMP_ColorGradient GradientPreset { get; } // 0x0000000180418990-0x00000001804189A0 

	// Constructors
	public UI_TextThemeData(); // 0x00000001804D5500-0x00000001804D55A0
	public UI_TextThemeData(string inId, string inName); // 0x00000001804D5740-0x00000001804D5800
	public UI_TextThemeData(string inId, string inName, WWTextMeshProUGUI inSrc); // 0x00000001804D55A0-0x00000001804D5740

	// Methods
	[DeMethodButton] // 0x000000018026FF30-0x000000018026FF90
	public void SetDefaults(); // 0x00000001804D5440-0x00000001804D5500
	public void SetDataFromSrc(WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings = false /* Metadata: 0x0077C97B */); // 0x00000001804D5350-0x00000001804D5440
}

