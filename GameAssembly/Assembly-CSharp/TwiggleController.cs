/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TwiggleController : ManagedBehaviour // TypeDefIndex: 13453
{
	// Fields
	private static TwiggleController _instance; // 0x00
	private ETwiggleState _desiredTwiggleState; // 0x50
	private ETwiggleState _currentTwiggleState; // 0x54

	// Properties
	public static TwiggleController instance { get; } // 0x0000000180514220-0x0000000180514390 
	public ETwiggleState currentTwiggleState { get; } // 0x0000000180379EE0-0x0000000180379EF0 

	// Nested types
	public enum ETwiggleState // TypeDefIndex: 13454
	{
		None = 0,
		WorkingSanctuary = 1,
		WorkingOtherSanctuary = 2,
		FinishedSanctuary = 3,
		FinishedOtherSanctuary = 4
	}

	// Constructors
	public TwiggleController(); // 0x00000001805141C0-0x0000000180514220
	static TwiggleController(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public override void MUpdate(); // 0x0000000180513D10-0x0000000180513E50
	private double GetSecondsRemaining(TwiggleItemComponent inComponent); // 0x00000001805121C0-0x0000000180512310
	private bool ValidTwiggleInfo(TwiggleItemComponent inTwiggleItemComponent, string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3A5 */, int inWorkerType = -1 /* Metadata: 0x007BA3A9 */); // 0x00000001805140E0-0x00000001805141C0
	public int GetTwiggleCount(); // 0x00000001805125C0-0x0000000180512770
	private bool GetTwiggleWorking(TwiggleItemComponent inComponent); // 0x0000000180513090-0x0000000180513130
	private bool GetTwiggleJobDone(TwiggleItemComponent inComponent); // 0x0000000180512E40-0x0000000180512E80
	public string GetTwiggleJobDoneId(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3AD */, int inWorkerType = -1 /* Metadata: 0x007BA3B1 */); // 0x0000000180512930-0x0000000180512BF0
	public TwiggleItemComponent GetTwiggleItemComponent(string inId); // 0x0000000180512770-0x0000000180512930
	public TwiggleItemComponent GetTwiggleComponentJobDone(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3B5 */, int inWorkerType = -1 /* Metadata: 0x007BA3B9 */); // 0x0000000180512310-0x00000001805125C0
	public bool GetTwiggleJobDone(string inId = null, string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3BD */, int inWorkerType = -1 /* Metadata: 0x007BA3C1 */); // 0x0000000180512BF0-0x0000000180512E40
	public TwiggleItemComponent GetFirstTwiggleComponentFinished(); // 0x0000000180511990-0x0000000180511B60
	public TwiggleItemComponent GetFirstTwiggleComponentWorking(); // 0x0000000180511B60-0x0000000180511D50
	public string GetFirstTwiggleWorkingId(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3C5 */, int inWorkerType = -1 /* Metadata: 0x007BA3C9 */); // 0x0000000180511D50-0x0000000180512030
	public List<string> GetAllTwiggleWorkingIds(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3CD */, int inWorkerType = -1 /* Metadata: 0x007BA3D1 */); // 0x0000000180510C70-0x0000000180510FD0
	public bool GetTwiggleWorking(string inId = null, string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3D5 */, int inWorkerType = -1 /* Metadata: 0x007BA3D9 */); // 0x0000000180513130-0x0000000180513420
	public int GetTwigglesWorking(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3DD */, int inWorkerType = -1 /* Metadata: 0x007BA3E1 */); // 0x0000000180513A10-0x0000000180513D10
	public int GetAllTwigglesWorking(); // 0x0000000180511430-0x0000000180511670
	public int GetAllTwigglesFinished(); // 0x0000000180511210-0x0000000180511430
	public int GetAllTwigglesAvailable(); // 0x0000000180510FD0-0x0000000180511210
	public int GetTwigglesAvailable(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3E5 */, int inWorkerType = -1 /* Metadata: 0x007BA3E9 */); // 0x0000000180513420-0x0000000180513730
	public int GetTwigglesJobsDone(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3ED */, int inWorkerType = -1 /* Metadata: 0x007BA3F1 */); // 0x0000000180513730-0x0000000180513A10
	public bool TwigglesFinished(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3F5 */, int inWorkerType = -1 /* Metadata: 0x007BA3F9 */); // 0x0000000180513E50-0x00000001805140E0
	public double GetTwiggleTimeSeconds(string inId); // 0x0000000180512E80-0x0000000180513090
	public string GetAvailableTwiggleId(string inSanctuaryClassItemId = "" /* Metadata: 0x007BA3FD */, int inWorkerType = -1 /* Metadata: 0x007BA401 */); // 0x0000000180511670-0x0000000180511990
	public string GetSanctuaryWorkingOnName(TwiggleItemComponent inTwiggleItemComponent); // 0x0000000180512030-0x00000001805121C0
}

