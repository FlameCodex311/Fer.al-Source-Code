/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PickupsController // TypeDefIndex: 11408
{
	// Fields
	public static UnityAction<string, string, float> NotifyHud; // 0x00

	// Constructors
	public PickupsController(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public static void Collect(string inDefId, bool inShowNotification = true /* Metadata: 0x0077CACB */, int inCount = 1 /* Metadata: 0x0077CACC */); // 0x00000001804E1F00-0x00000001804E1F10
	private static void SendHudNotification(string inDefId, bool inShowNotification = true /* Metadata: 0x0077CAD0 */, int inCount = 1 /* Metadata: 0x0077CAD1 */); // 0x00000001804E1F10-0x00000001804E2120
	public static string StyleItemName(ERarity inRarity, string inNameString); // 0x00000001804E2120-0x00000001804E2340
}

