/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CinematicManager : SingletonManagerBase<CinematicManager> // TypeDefIndex: 10295
{
	// Fields
	private const string _cutscenesGroup = "Cutscenes"; // Metadata: 0x00781B76
	private const string _availableCutscenesGroup = "Cutscenes/Available Cutscenes"; // Metadata: 0x00781B83
	private const string _allCutscenesGroup = "Cutscenes/All Cutscenes"; // Metadata: 0x00781BA4
	private const string _resetDataGroup = "Cutscenes/Reset"; // Metadata: 0x00781BBF
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static bool <Initialized>k__BackingField; // 0x00
	private readonly IDictionary<string, Cutscene> _cutsceneLookup; // 0x60
	private Cutscene _cutsceneToPlayOnLevelLoad; // 0x68
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsTestRunActive>k__BackingField; // 0x70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Cutscene <CurrentlyPlayingCutscene>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Cutscene[] <AvailableCutscenes>k__BackingField; // 0x80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Cutscene[] <AllCutsceneNames>k__BackingField; // 0x88

	// Properties
	public static bool Initialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018126A740-0x000000018126A780 0x000000018126A7E0-0x000000018126A820
	public bool IsAutoPlayFunctionalityEnabled { get; } // 0x00000001803C28F0-0x00000001803C2900 
	public bool IsCutsceneActive { get; } // 0x000000018126A780-0x000000018126A7E0 
	public bool IsTestRunActive { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180545D70-0x0000000180545D80 0x0000000180545DC0-0x0000000180545DD0
	public Cutscene CurrentlyPlayingCutscene { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	public Cutscene[] AvailableCutscenes { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
	public Cutscene[] AllCutsceneNames { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10296
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__42_0; // 0x08
		public static Func<Cutscene, bool> <>9__42_2; // 0x10

		// Constructors
		static <>c(); // 0x0000000181281F50-0x0000000181281FB0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Reload>b__42_0(); // 0x0000000180F1EFD0-0x0000000180F1EFF0
		internal bool <Reload>b__42_2(Cutscene c); // 0x0000000181281820-0x0000000181281840
	}

	// Constructors
	public CinematicManager(); // 0x000000018126A6B0-0x000000018126A740

	// Methods
	public override void MStart(); // 0x0000000181269C80-0x0000000181269D60
	public override void MOnDestroy(); // 0x0000000181269BA0-0x0000000181269C80
	public bool TryPlayCutscene(Cutscene cutscene); // 0x000000018126A260-0x000000018126A270
	[DebugButton] // 0x00000001800CEC80-0x00000001800CECE0
	public bool TryPlayCutscene(string cutscene); // 0x000000018126A110-0x000000018126A120
	[DebugButton] // 0x00000001800CF310-0x00000001800CF370
	public bool TryForcePlayCutscene(string cutscene); // 0x0000000181269EB0-0x0000000181269EC0
	[DebugButton] // 0x00000001800CF630-0x00000001800CF690
	public void TrySkipCutscene(); // 0x000000018126A310-0x000000018126A320
	[DebugButton] // 0x00000001800CF7A0-0x00000001800CF800
	public bool TryForceSkipCutscene(); // 0x0000000181269EC0-0x0000000181269ED0
	private bool TryPlayCutscene(string cutscene, bool force); // 0x000000018126A120-0x000000018126A260
	private bool TryPlayCutscene(Cutscene cutscene, bool force); // 0x000000018126A010-0x000000018126A110
	private bool TrySkipCutscene(bool force); // 0x000000018126A270-0x000000018126A310
	private bool TryGetCutscene(string cutscene, out Cutscene matchingCutscene, bool requireInitialization = true /* Metadata: 0x00781B75 */); // 0x0000000181269ED0-0x000000018126A010
	private void OnCutsceneEnded(CutscenePlaybackState playbackState); // 0x0000000181269D60-0x0000000181269D70
	private void Reload(Message message); // 0x0000000181269D70-0x0000000181269EB0
	private void InitializeCutscene(Cutscene cutscene); // 0x0000000181269AD0-0x0000000181269BA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Reload>b__42_1(); // 0x000000018126A320-0x000000018126A6B0
}

