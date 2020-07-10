/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PickupsController // TypeDefIndex: 13735
{
	// Fields
	public static UnityAction<string, string, float> NotifyHud; // 0x00

	// Constructors
	public PickupsController(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public static void Collect(string inDefId, bool inShowNotification = true /* Metadata: 0x0078400C */, int inCount = 1 /* Metadata: 0x0078400D */); // 0x0000000181158C90-0x0000000181158CA0
	private static void SendHudNotification(string inDefId, bool inShowNotification = true /* Metadata: 0x00784011 */, int inCount = 1 /* Metadata: 0x00784012 */); // 0x0000000181158CA0-0x0000000181158EB0
	public static string StyleItemName(ERarity inRarity, string inNameString); // 0x0000000181158EB0-0x00000001811590E0
}

