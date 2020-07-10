/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TwiggleController : ManagedBehaviour // TypeDefIndex: 11917
{
	// Fields
	private static TwiggleController _instance; // 0x00
	private ETwiggleState _desiredTwiggleState; // 0x50
	private ETwiggleState _currentTwiggleState; // 0x54

	// Properties
	public static TwiggleController instance { get; } // 0x0000000180FAEEA0-0x0000000180FAF010 
	public ETwiggleState currentTwiggleState { get; } // 0x0000000180369C60-0x0000000180369C70 

	// Nested types
	public enum ETwiggleState // TypeDefIndex: 11918
	{
		None = 0,
		WorkingSanctuary = 1,
		WorkingOtherSanctuary = 2,
		FinishedSanctuary = 3,
		FinishedOtherSanctuary = 4
	}

	// Constructors
	public TwiggleController(); // 0x0000000180FAEE40-0x0000000180FAEEA0
	static TwiggleController(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public override void MUpdate(); // 0x0000000180FAE970-0x0000000180FAEAB0
	private double GetSecondsRemaining(TwiggleItemComponent inComponent); // 0x0000000180FACDF0-0x0000000180FACF40
	private bool ValidTwiggleInfo(TwiggleItemComponent inTwiggleItemComponent, string inSanctuaryClassItemId = "" /* Metadata: 0x00782C97 */, int inWorkerType = -1 /* Metadata: 0x00782C9B */); // 0x0000000180FAED50-0x0000000180FAEE40
	public int GetTwiggleCount(); // 0x0000000180FAD1F0-0x0000000180FAD3A0
	private bool GetTwiggleWorking(TwiggleItemComponent inComponent); // 0x0000000180FADCE0-0x0000000180FADD80
	private bool GetTwiggleJobDone(TwiggleItemComponent inComponent); // 0x0000000180FADA90-0x0000000180FADAD0
	public string GetTwiggleJobDoneId(string inSanctuaryClassItemId = "" /* Metadata: 0x00782C9F */, int inWorkerType = -1 /* Metadata: 0x00782CA3 */); // 0x0000000180FAD570-0x0000000180FAD840
	public TwiggleItemComponent GetTwiggleItemComponent(string inId); // 0x0000000180FAD3A0-0x0000000180FAD570
	public TwiggleItemComponent GetTwiggleComponentJobDone(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CA7 */, int inWorkerType = -1 /* Metadata: 0x00782CAB */); // 0x0000000180FACF40-0x0000000180FAD1F0
	public bool GetTwiggleJobDone(string inId = null, string inSanctuaryClassItemId = "" /* Metadata: 0x00782CAF */, int inWorkerType = -1 /* Metadata: 0x00782CB3 */); // 0x0000000180FAD840-0x0000000180FADA90
	public TwiggleItemComponent GetFirstTwiggleComponentFinished(); // 0x0000000180FAC590-0x0000000180FAC760
	public TwiggleItemComponent GetFirstTwiggleComponentWorking(); // 0x0000000180FAC760-0x0000000180FAC960
	public string GetFirstTwiggleWorkingId(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CB7 */, int inWorkerType = -1 /* Metadata: 0x00782CBB */); // 0x0000000180FAC960-0x0000000180FACC50
	public List<string> GetAllTwiggleWorkingIds(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CBF */, int inWorkerType = -1 /* Metadata: 0x00782CC3 */); // 0x0000000180FAB830-0x0000000180FABBA0
	public bool GetTwiggleWorking(string inId = null, string inSanctuaryClassItemId = "" /* Metadata: 0x00782CC7 */, int inWorkerType = -1 /* Metadata: 0x00782CCB */); // 0x0000000180FADD80-0x0000000180FAE070
	public int GetTwigglesWorking(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CCF */, int inWorkerType = -1 /* Metadata: 0x00782CD3 */); // 0x0000000180FAE660-0x0000000180FAE970
	public int GetAllTwigglesWorking(); // 0x0000000180FAC010-0x0000000180FAC260
	public int GetAllTwigglesFinished(); // 0x0000000180FABDF0-0x0000000180FAC010
	public int GetAllTwigglesAvailable(); // 0x0000000180FABBA0-0x0000000180FABDF0
	public int GetTwigglesAvailable(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CD7 */, int inWorkerType = -1 /* Metadata: 0x00782CDB */); // 0x0000000180FAE070-0x0000000180FAE380
	public int GetTwigglesJobsDone(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CDF */, int inWorkerType = -1 /* Metadata: 0x00782CE3 */); // 0x0000000180FAE380-0x0000000180FAE660
	public bool TwigglesFinished(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CE7 */, int inWorkerType = -1 /* Metadata: 0x00782CEB */); // 0x0000000180FAEAB0-0x0000000180FAED50
	public double GetTwiggleTimeSeconds(string inId); // 0x0000000180FADAD0-0x0000000180FADCE0
	public string GetAvailableTwiggleId(string inSanctuaryClassItemId = "" /* Metadata: 0x00782CEF */, int inWorkerType = -1 /* Metadata: 0x00782CF3 */); // 0x0000000180FAC260-0x0000000180FAC590
	public string GetSanctuaryWorkingOnName(TwiggleItemComponent inTwiggleItemComponent); // 0x0000000180FACC50-0x0000000180FACDF0
}

