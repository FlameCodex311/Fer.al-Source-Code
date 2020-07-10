/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ColorUtils // TypeDefIndex: 13219
{
	// Constructors
	public ColorUtils(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public static string ColorToCSV(Color inColor); // 0x0000000181470570-0x00000001814709E0
	public static Color FullRGBToColor(Color inColor); // 0x0000000181470B00-0x0000000181470BA0
	public static Color FullRGBToColor(float inR, float inG, float inB, float inA); // 0x0000000181470A70-0x0000000181470B00
	public static Color CSVToColor(string inCSV); // 0x0000000181470290-0x0000000181470550
	public static string ColorToHex(Color32 color); // 0x00000001814709E0-0x0000000181470A70
	public static Color HexToColor(string hex); // 0x0000000181470BA0-0x0000000181470D30
	public static void HsvToRgb(double h, double S, double V, out int r, out int g, out int b); // 0x0000000181470D30-0x0000000181470F50
	private static int Clamp(int i); // 0x0000000181470550-0x0000000181470570
}

