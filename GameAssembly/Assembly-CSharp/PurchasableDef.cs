/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public abstract class PurchasableDef : LocalizedNameBundledDef // TypeDefIndex: 10210
{
	// Fields
	public string saleCalendarRef; // 0x68
	public bool isRare; // 0x70
	private CurrencyType _currencyType; // 0x74
	protected int _recycleValue; // 0x78
	protected long _dateAdd; // 0x80
	protected long _dateRemove; // 0x88
	[Header] // 0x0000000180126FD0-0x0000000180127000
	public float uiScale; // 0x90
	public Vector3 uiRotation; // 0x94
	public Vector3 uiPosition; // 0xA0
	public bool cantTrade; // 0xAC
	public bool cantRecycle; // 0xAD
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <storePackStatusRequired>k__BackingField; // 0xAE
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <storeXPLevelRequirement>k__BackingField; // 0xB0
	[Header] // 0x000000018016ABB0-0x000000018016ABE0
	public SpecificOS specificOS; // 0xB4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <rarity>k__BackingField; // 0xB8

	// Properties
	public CurrencyType CurrencyType { get; } // 0x00000001803DAD10-0x00000001803DAD20 
	public int RecycleValue { get; } // 0x00000001803DAE10-0x00000001803DAE20 
	public long DateAdd { get; } // 0x000000018035FCB0-0x000000018035FCC0 
	public long DateRemove { get; } // 0x0000000180424200-0x0000000180424210 
	public bool IsPremium { get; } // 0x00000001815EDED0-0x00000001815EDEE0 
	public bool IsTicket { get; } // 0x00000001815EDEE0-0x00000001815EDEF0 
	public virtual bool canTrade { get; } // 0x00000001815EDF00-0x00000001815EDF10 
	public virtual bool canRecycle { get; } // 0x00000001815EDEF0-0x00000001815EDF00 
	public bool storePackStatusRequired { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001815EDF10-0x00000001815EDF20 0x00000001815EDF20-0x00000001815EDF30
	public int storeXPLevelRequirement { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180A246D0-0x0000000180A246E0 0x00000001815EDF30-0x00000001815EDF40
	public int rarity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180428830-0x0000000180428840 0x0000000180E3A1C0-0x0000000180E3A1D0

	// Constructors
	protected PurchasableDef(); // 0x00000001815EDE20-0x00000001815EDED0

	// Methods
	public override void LoadEntry(); // 0x00000001815EDC20-0x00000001815EDE20
}

