/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class UI_ImageThemeData // TypeDefIndex: 13589
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x00783EBB
	[DeDisabled] // 0x00000001800CEC30-0x00000001800CEC80
	[SerializeField] // 0x00000001800CEC30-0x00000001800CEC80
	private string _id; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001800CF4E0-0x00000001800CF510
	[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
	private Sprite _sprite; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _color; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useOverridePixelsPerUnit; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _overridePixelsPerUnit; // 0x3C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image.Type _type; // 0x40
	[DeHeader] // 0x00000001800D1A60-0x00000001800D1AC0
	[SerializeField] // 0x00000001800D1A60-0x00000001800D1AC0
	private bool _fillCenter; // 0x44
	[DeHeader] // 0x00000001800D1E00-0x00000001800D1E60
	[SerializeField] // 0x00000001800D1E00-0x00000001800D1E60
	private Image.FillMethod _fillMethod; // 0x48
	[DeRange] // 0x00000001800D2280-0x00000001800D22D0
	[SerializeField] // 0x00000001800D2280-0x00000001800D22D0
	private float _fillAmount; // 0x4C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _fillClockwise; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _fillOrigin; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _preserveAspect; // 0x58

	// Properties
	public string Id { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public string Name { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public Sprite Sprite { get; } // 0x000000018036AC70-0x000000018036AC80 
	public Color Color { get; } // 0x000000018036CB50-0x000000018036CB60 
	public bool UseOverridePixelsPerUnit { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
	public float OverridePixelsPerUnit { get; } // 0x0000000180E426C0-0x0000000180E426D0 
	public Image.Type Type { get; } // 0x000000018047AB20-0x000000018047AB30 
	public bool FillCenter { get; } // 0x000000018061F620-0x000000018061F630 
	public Image.FillMethod FillMethod { get; } // 0x0000000180384C10-0x0000000180384C20 
	public float FillAmount { get; } // 0x0000000180487D30-0x0000000180487D40 
	public bool FillClockwise { get; } // 0x0000000180619B50-0x0000000180619B60 
	public int FillOrigin { get; } // 0x0000000180369C60-0x0000000180369C70 
	public bool PreserveAspect { get; } // 0x0000000180369BC0-0x0000000180369BD0 

	// Constructors
	public UI_ImageThemeData(); // 0x0000000180E42510-0x0000000180E42550
	public UI_ImageThemeData(string inId, string inName, Sprite inSprite, Color inColor); // 0x0000000180E42650-0x0000000180E426C0
	public UI_ImageThemeData(string inId, string inName, WWImage inSrc); // 0x0000000180E42550-0x0000000180E42650

	// Methods
	[DeMethodButton] // 0x00000001800D2D60-0x00000001800D2DC0
	public void SetDefaults(); // 0x0000000180E42490-0x0000000180E42510
	public void SetDataFromSrc(WWImage inSrc); // 0x0000000180E423E0-0x0000000180E42490
}

