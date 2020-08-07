/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreDateUtils // TypeDefIndex: 11328
{
	// Fields
	public static readonly DateTime _unixTimestampEpoch; // 0x00

	// Properties
	public static long CurrentTimeTicks { get; } // 0x0000000180A675A0-0x0000000180A67610 
	public static DateTime Now { get; } // 0x0000000180A67610-0x0000000180A67710 

	// Constructors
	public CoreDateUtils(); // 0x0000000180373240-0x0000000180373250
	static CoreDateUtils(); // 0x0000000180A67520-0x0000000180A675A0

	// Methods
	public static bool IsNowInRange(long dateRangeStart, long dateRangeEnd); // 0x0000000180A67360-0x0000000180A67430
	public static bool IsDateInRange(long dateToCheck, long dateRangeStart, long dateRangeEnd); // 0x0000000180A67350-0x0000000180A67360
	public static int GetDaysUntilDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek); // 0x0000000180A67230-0x0000000180A67270
	public static DateTime GetNextDayOfWeek(DateTime startDate, DayOfWeek dayOfWeek); // 0x0000000180A67280-0x0000000180A67320
	public static int GetDayOfMonth(long inDateTicks); // 0x0000000180A671B0-0x0000000180A671F0
	public static int GetDayOfYear(long inDateTicks); // 0x0000000180A671F0-0x0000000180A67230
	public static DateTime GetSpecificDay(long inDateTicks); // 0x0000000180A67320-0x0000000180A67350
	private static DateTime? GetDebugDateTime(); // 0x0000000180A67270-0x0000000180A67280
	public static int DateToInt(); // 0x0000000180A67030-0x0000000180A67130
	public static DateTime FromUnixTimestampUtc(long milliseconds); // 0x0000000180A67130-0x0000000180A671B0
	public static long ToUnixTimestamp(DateTime time); // 0x0000000180A67430-0x0000000180A67520
}

