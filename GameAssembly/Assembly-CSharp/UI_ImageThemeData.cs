/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class UI_ImageThemeData // TypeDefIndex: 11256
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x0077C97A
	[DeDisabled] // 0x0000000180268E70-0x0000000180268EC0
	[SerializeField] // 0x0000000180268E70-0x0000000180268EC0
	private string _id; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001801E0E00-0x00000001801E0E30
	[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
	private Sprite _sprite; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _color; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useOverridePixelsPerUnit; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _overridePixelsPerUnit; // 0x3C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image.Type _type; // 0x40
	[DeHeader] // 0x000000018026B0A0-0x000000018026B100
	[SerializeField] // 0x000000018026B0A0-0x000000018026B100
	private bool _fillCenter; // 0x44
	[DeHeader] // 0x000000018026B330-0x000000018026B390
	[SerializeField] // 0x000000018026B330-0x000000018026B390
	private Image.FillMethod _fillMethod; // 0x48
	[DeRange] // 0x000000018026B530-0x000000018026B580
	[SerializeField] // 0x000000018026B530-0x000000018026B580
	private float _fillAmount; // 0x4C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _fillClockwise; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _fillOrigin; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _preserveAspect; // 0x58

	// Properties
	public string Id { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public string Name { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public Sprite Sprite { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public Color Color { get; } // 0x0000000180379E90-0x0000000180379EA0 
	public bool UseOverridePixelsPerUnit { get; } // 0x0000000180379B20-0x0000000180379B30 
	public float OverridePixelsPerUnit { get; } // 0x0000000180379EF0-0x0000000180379F00 
	public Image.Type Type { get; } // 0x0000000180379F10-0x0000000180379F20 
	public bool FillCenter { get; } // 0x0000000180379EB0-0x0000000180379EC0 
	public Image.FillMethod FillMethod { get; } // 0x0000000180379ED0-0x0000000180379EE0 
	public float FillAmount { get; } // 0x0000000180379EA0-0x0000000180379EB0 
	public bool FillClockwise { get; } // 0x0000000180379EC0-0x0000000180379ED0 
	public int FillOrigin { get; } // 0x0000000180379EE0-0x0000000180379EF0 
	public bool PreserveAspect { get; } // 0x0000000180379F00-0x0000000180379F10 

	// Constructors
	public UI_ImageThemeData(); // 0x0000000180379CE0-0x0000000180379D20
	public UI_ImageThemeData(string inId, string inName, Sprite inSprite, Color inColor); // 0x0000000180379E20-0x0000000180379E90
	public UI_ImageThemeData(string inId, string inName, WWImage inSrc); // 0x0000000180379D20-0x0000000180379E20

	// Methods
	[DeMethodButton] // 0x000000018026BC90-0x000000018026BCF0
	public void SetDefaults(); // 0x0000000180379C60-0x0000000180379CE0
	public void SetDataFromSrc(WWImage inSrc); // 0x0000000180379BB0-0x0000000180379C60
}

