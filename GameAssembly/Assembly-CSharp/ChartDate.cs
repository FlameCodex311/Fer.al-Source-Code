/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ChartDate // TypeDefIndex: 13031
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ChartDateRepeatMode _repeatMode; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _dateStart; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _dateEnd; // 0x20

	// Properties
	public ChartDateRepeatMode RepeatMode { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
	public bool UseDateStart { get; } // 0x000000018049F910-0x000000018049F950 
	public bool DateStartValid { get; } // 0x000000018049F690-0x000000018049F710 
	public DateTime? DateStartAsDateTime { get; } // 0x000000018049F550-0x000000018049F580 
	public string DateStart { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public long DateStartTicks { get; } // 0x000000018049F580-0x000000018049F690 
	public bool UseDateEnd { get; } // 0x000000018049F8D0-0x000000018049F910 
	public bool DateEndValid { get; } // 0x000000018049F4D0-0x000000018049F550 
	public DateTime? DateEndAsDateTime { get; } // 0x000000018049F370-0x000000018049F3A0 
	public string DateEnd { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public long DateEndTicks { get; } // 0x000000018049F3A0-0x000000018049F4D0 
	public bool IsAvailable { get; } // 0x000000018049F790-0x000000018049F7F0 
	public bool IsAvailableTomorrow { get; } // 0x000000018049F710-0x000000018049F790 
	private bool TodayMatchesRepeatingDay { get; } // 0x000000018049F7F0-0x000000018049F850 
	private bool TomorrowMatchesRepeatingDay { get; } // 0x000000018049F850-0x000000018049F8D0 

	// Constructors
	public ChartDate(); // 0x000000018049F320-0x000000018049F370

	// Methods
	public bool IsDateTimeAvailable(string inDateString); // 0x000000018049EE90-0x000000018049EF20
	public bool IsDateTimeAvailable(DateTime inDateTime); // 0x000000018049EF20-0x000000018049F240
	public static DateTime? ParseDateOrNull(string inDateString); // 0x000000018049F240-0x000000018049F320
	private bool DateTimeMatchesRepeatingDay(DateTime inDateTime); // 0x000000018049ECA0-0x000000018049EE90
}

