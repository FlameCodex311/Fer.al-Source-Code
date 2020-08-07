/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public abstract class PurchasableDef : LocalizedNameBundledDef // TypeDefIndex: 11701
{
	// Fields
	public string saleCalendarRef; // 0x68
	public bool isRare; // 0x70
	private CurrencyType _currencyType; // 0x74
	protected int _recycleValue; // 0x78
	protected long _dateAdd; // 0x80
	protected long _dateRemove; // 0x88
	[Header] // 0x00000001802136B0-0x00000001802136E0
	public float uiScale; // 0x90
	public Vector3 uiRotation; // 0x94
	public Vector3 uiPosition; // 0xA0
	public bool cantTrade; // 0xAC
	public bool cantRecycle; // 0xAD
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <storePackStatusRequired>k__BackingField; // 0xAE
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <storeXPLevelRequirement>k__BackingField; // 0xB0
	[Header] // 0x000000018023FC20-0x000000018023FC50
	public SpecificOS specificOS; // 0xB4
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <rarity>k__BackingField; // 0xB8

	// Properties
	public CurrencyType CurrencyType { get; } // 0x00000001804428A0-0x00000001804428B0 
	public int RecycleValue { get; } // 0x00000001803959E0-0x00000001803959F0 
	public long DateAdd { get; } // 0x000000018040ED60-0x000000018040ED70 
	public long DateRemove { get; } // 0x0000000180476CE0-0x0000000180476CF0 
	public bool IsPremium { get; } // 0x0000000180A2BAD0-0x0000000180A2BAE0 
	public bool IsTicket { get; } // 0x0000000180A2BAE0-0x0000000180A2BAF0 
	public virtual bool canTrade { get; } // 0x0000000180A2BB00-0x0000000180A2BB10 
	public virtual bool canRecycle { get; } // 0x0000000180A2BAF0-0x0000000180A2BB00 
	public bool storePackStatusRequired { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180A2BB10-0x0000000180A2BB20 0x0000000180A2BB40-0x0000000180A2BB50
	public int storeXPLevelRequirement { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180A2BB20-0x0000000180A2BB30 0x0000000180A2BB50-0x0000000180A2BB60
	public int rarity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180833FD0-0x0000000180833FE0 0x0000000180A2BB30-0x0000000180A2BB40

	// Constructors
	protected PurchasableDef(); // 0x0000000180A2BA20-0x0000000180A2BAD0

	// Methods
	public override void LoadEntry(); // 0x0000000180A2B820-0x0000000180A2BA20
}

