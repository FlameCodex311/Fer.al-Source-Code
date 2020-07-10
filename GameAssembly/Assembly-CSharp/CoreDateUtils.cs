/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreDateUtils // TypeDefIndex: 13661
{
	// Fields
	public static readonly DateTime _unixTimestampEpoch; // 0x00

	// Properties
	public static long CurrentTimeTicks { get; } // 0x000000018130CF30-0x000000018130CFA0 
	public static DateTime Now { get; } // 0x000000018130CFA0-0x000000018130D0A0 

	// Constructors
	public CoreDateUtils(); // 0x000000018036B6C0-0x000000018036B6D0
	static CoreDateUtils(); // 0x000000018130CEB0-0x000000018130CF30

	// Methods
	public static bool IsNowInRange(long dateRangeStart, long dateRangeEnd); // 0x000000018130CCF0-0x000000018130CDC0
	public static bool IsDateInRange(long dateToCheck, long dateRangeStart, long dateRangeEnd); // 0x000000018130CCE0-0x000000018130CCF0
	public static int GetDaysUntilDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek); // 0x000000018130CBD0-0x000000018130CC10
	public static DateTime GetNextDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek); // 0x000000018130CC10-0x000000018130CCB0
	public static int GetDayOfMonth(long inDateTicks); // 0x000000018130CB50-0x000000018130CB90
	public static int GetDayOfYear(long inDateTicks); // 0x000000018130CB90-0x000000018130CBD0
	public static DateTime GetSpecificDay(long inDateTicks); // 0x000000018130CCB0-0x000000018130CCE0
	private static DateTime? GetDebugDateTime(); // 0x000000018079CEF0-0x000000018079CF00
	public static int DateToInt(); // 0x000000018130C9D0-0x000000018130CAD0
	public static DateTime FromUnixTimestampUtc(long milliseconds); // 0x000000018130CAD0-0x000000018130CB50
	public static long ToUnixTimestamp(DateTime time); // 0x000000018130CDC0-0x000000018130CEB0
}

