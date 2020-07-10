/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ChartDate // TypeDefIndex: 11507
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ChartDateRepeatMode _repeatMode; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _dateStart; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _dateEnd; // 0x20

	// Properties
	public ChartDateRepeatMode RepeatMode { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
	public bool UseDateStart { get; } // 0x0000000181026FB0-0x0000000181026FF0 
	public bool DateStartValid { get; } // 0x0000000181026D30-0x0000000181026DB0 
	public DateTime? DateStartAsDateTime { get; } // 0x0000000181026BF0-0x0000000181026C20 
	public string DateStart { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public long DateStartTicks { get; } // 0x0000000181026C20-0x0000000181026D30 
	public bool UseDateEnd { get; } // 0x0000000181026F70-0x0000000181026FB0 
	public bool DateEndValid { get; } // 0x0000000181026B70-0x0000000181026BF0 
	public DateTime? DateEndAsDateTime { get; } // 0x0000000181026A10-0x0000000181026A40 
	public string DateEnd { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public long DateEndTicks { get; } // 0x0000000181026A40-0x0000000181026B70 
	public bool IsAvailable { get; } // 0x0000000181026E30-0x0000000181026E90 
	public bool IsAvailableTomorrow { get; } // 0x0000000181026DB0-0x0000000181026E30 
	private bool TodayMatchesRepeatingDay { get; } // 0x0000000181026E90-0x0000000181026EF0 
	private bool TomorrowMatchesRepeatingDay { get; } // 0x0000000181026EF0-0x0000000181026F70 

	// Constructors
	public ChartDate(); // 0x00000001810269C0-0x0000000181026A10

	// Methods
	public bool IsDateTimeAvailable(string inDateString); // 0x0000000181026530-0x00000001810265C0
	public bool IsDateTimeAvailable(DateTime inDateTime); // 0x00000001810265C0-0x00000001810268E0
	public static DateTime? ParseDateOrNull(string inDateString); // 0x00000001810268E0-0x00000001810269C0
	private bool DateTimeMatchesRepeatingDay(DateTime inDateTime); // 0x0000000181026340-0x0000000181026530
}

