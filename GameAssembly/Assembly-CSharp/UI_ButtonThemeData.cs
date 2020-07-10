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
public class UI_ButtonThemeData // TypeDefIndex: 13587
{
	// Fields
	public const bool DISABLE_ID_IN_INSPECTOR = false; // Metadata: 0x00783EBA
	[DeDisabled] // 0x00000001800CEC30-0x00000001800CEC80
	[SerializeField] // 0x00000001800CEC30-0x00000001800CEC80
	private string _id; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _name; // 0x18
	[DeEndDisabled] // 0x00000001800CF4E0-0x00000001800CF510
	[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
	private Selectable.Transition _transition; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ColorBlock _colorBlock; // 0x24
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SpriteState _spriteState; // 0x80

	// Properties
	public string Id { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public string Name { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public Selectable.Transition Transition { get; } // 0x00000001803C2700-0x00000001803C2710 
	public ColorBlock ColorBlock { get; } // 0x0000000180FBA0D0-0x0000000180FBA110 
	public SpriteState SpriteState { get; } // 0x0000000180FBA110-0x0000000180FBA130 

	// Constructors
	public UI_ButtonThemeData(); // 0x0000000180FB9FD0-0x0000000180FBA020
	public UI_ButtonThemeData(string inId, string inName); // 0x0000000180FB9F60-0x0000000180FB9FD0
	public UI_ButtonThemeData(string inId, string inName, WWButton inSrc); // 0x0000000180FBA020-0x0000000180FBA0D0

	// Methods
	[DeMethodButton] // 0x00000001800CFC00-0x00000001800CFC60
	public void SetDefaults(); // 0x0000000180FB9F20-0x0000000180FB9F60
	public void SetDataFromSrc(WWButton inSrc, bool inIgnoreSizeSettings = false /* Metadata: 0x00783EB9 */); // 0x0000000180FB9EB0-0x0000000180FB9F20
}

