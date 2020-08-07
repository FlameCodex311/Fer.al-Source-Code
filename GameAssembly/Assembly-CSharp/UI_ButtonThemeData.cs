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
public class UI_ButtonThemeData // TypeDefIndex: 11254
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x0077C979
	[DeDisabled] // 0x0000000180268E70-0x0000000180268EC0
	[SerializeField] // 0x0000000180268E70-0x0000000180268EC0
	private string _id; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001801E0E00-0x00000001801E0E30
	[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
	private Selectable.Transition _transition; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ColorBlock _colorBlock; // 0x24
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SpriteState _spriteState; // 0x80

	// Properties
	public string Id { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public string Name { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public Selectable.Transition Transition { get; } // 0x00000001803FB670-0x00000001803FB680 
	public ColorBlock ColorBlock { get; } // 0x000000018051EF40-0x000000018051EF80 
	public SpriteState SpriteState { get; } // 0x000000018051EF80-0x000000018051EFA0 

	// Constructors
	public UI_ButtonThemeData(); // 0x000000018051EE40-0x000000018051EE90
	public UI_ButtonThemeData(string inId, string inName); // 0x000000018051EDD0-0x000000018051EE40
	public UI_ButtonThemeData(string inId, string inName, WWButton inSrc); // 0x000000018051EE90-0x000000018051EF40

	// Methods
	[DeMethodButton] // 0x0000000180269AC0-0x0000000180269B20
	public void SetDefaults(); // 0x000000018051ED90-0x000000018051EDD0
	public void SetDataFromSrc(WWButton inSrc, bool inIgnoreSizeSettings = false /* Metadata: 0x0077C978 */); // 0x000000018051ED20-0x000000018051ED90
}

