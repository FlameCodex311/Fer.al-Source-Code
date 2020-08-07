/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CinematicManager : SingletonManagerBase<CinematicManager> // TypeDefIndex: 11784
{
	// Fields
	private const string _cutscenesGroup = "Cutscenes"; // Metadata: 0x007B9211
	private const string _availableCutscenesGroup = "Cutscenes/Available Cutscenes"; // Metadata: 0x007B921E
	private const string _allCutscenesGroup = "Cutscenes/All Cutscenes"; // Metadata: 0x007B923F
	private const string _resetDataGroup = "Cutscenes/Reset"; // Metadata: 0x007B925A
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static bool <Initialized>k__BackingField; // 0x00
	private readonly IDictionary<string, Cutscene> _cutsceneLookup; // 0x60
	private Cutscene _cutsceneToPlayOnLevelLoad; // 0x68
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsTestRunActive>k__BackingField; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Cutscene <CurrentlyPlayingCutscene>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Cutscene[] <AvailableCutscenes>k__BackingField; // 0x80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Cutscene[] <AllCutsceneNames>k__BackingField; // 0x88

	// Properties
	public static bool Initialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180522F00-0x0000000180522F40 0x0000000180522FB0-0x0000000180522FF0
	public bool IsAutoPlayFunctionalityEnabled { get; } // 0x0000000180380950-0x0000000180380960 
	public bool IsCutsceneActive { get; } // 0x0000000180522F40-0x0000000180522FA0 
	public bool IsTestRunActive { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180522FA0-0x0000000180522FB0 0x0000000180522FF0-0x0000000180523000
	public Cutscene CurrentlyPlayingCutscene { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
	public Cutscene[] AvailableCutscenes { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
	public Cutscene[] AllCutsceneNames { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11785
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__42_0; // 0x08
		public static Func<Cutscene, bool> <>9__42_2; // 0x10

		// Constructors
		static <>c(); // 0x0000000180538A80-0x0000000180538AE0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Reload>b__42_0(); // 0x00000001805382B0-0x00000001805382D0
		internal bool <Reload>b__42_2(Cutscene c); // 0x00000001805382D0-0x00000001805382F0
	}

	// Constructors
	public CinematicManager(); // 0x0000000180522E70-0x0000000180522F00

	// Methods
	public override void MStart(); // 0x00000001805224B0-0x0000000180522590
	public override void MOnDestroy(); // 0x00000001805223D0-0x00000001805224B0
	public bool TryPlayCutscene(Cutscene cutscene); // 0x0000000180522A90-0x0000000180522AA0
	[DebugButton] // 0x000000018025F4F0-0x000000018025F550
	public bool TryPlayCutscene(string cutscene); // 0x0000000180522940-0x0000000180522950
	[DebugButton] // 0x000000018025F690-0x000000018025F6F0
	public bool TryForcePlayCutscene(string cutscene); // 0x00000001805226E0-0x00000001805226F0
	[DebugButton] // 0x000000018025F9A0-0x000000018025FA00
	public void TrySkipCutscene(); // 0x0000000180522B40-0x0000000180522B50
	[DebugButton] // 0x000000018025FAC0-0x000000018025FB20
	public bool TryForceSkipCutscene(); // 0x00000001805226F0-0x0000000180522700
	private bool TryPlayCutscene(string cutscene, bool force); // 0x0000000180522950-0x0000000180522A90
	private bool TryPlayCutscene(Cutscene cutscene, bool force); // 0x0000000180522840-0x0000000180522940
	private bool TrySkipCutscene(bool force); // 0x0000000180522AA0-0x0000000180522B40
	private bool TryGetCutscene(string cutscene, out Cutscene matchingCutscene, bool requireInitialization = true /* Metadata: 0x007B9210 */); // 0x0000000180522700-0x0000000180522840
	private void OnCutsceneEnded(CutscenePlaybackState playbackState); // 0x0000000180522590-0x00000001805225A0
	private void Reload(Message message); // 0x00000001805225A0-0x00000001805226E0
	private void InitializeCutscene(Cutscene cutscene); // 0x0000000180522300-0x00000001805223D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Reload>b__42_1(); // 0x0000000180522B50-0x0000000180522E70
}

