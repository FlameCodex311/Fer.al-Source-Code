/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ColorUtils // TypeDefIndex: 10885
{
	// Constructors
	public ColorUtils(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public static string ColorToCSV(Color inColor); // 0x000000018077BCC0-0x000000018077C100
	public static Color FullRGBToColor(Color inColor); // 0x000000018077C220-0x000000018077C2C0
	public static Color FullRGBToColor(float inR, float inG, float inB, float inA); // 0x000000018077C190-0x000000018077C220
	public static Color CSVToColor(string inCSV); // 0x000000018077B9F0-0x000000018077BCA0
	public static string ColorToHex(Color32 color); // 0x000000018077C100-0x000000018077C190
	public static Color HexToColor(string hex); // 0x000000018077C2C0-0x000000018077C440
	public static void HsvToRgb(double h, double S, double V, out int r, out int g, out int b); // 0x000000018077C440-0x000000018077C660
	private static int Clamp(int i); // 0x000000018077BCA0-0x000000018077BCC0
}

