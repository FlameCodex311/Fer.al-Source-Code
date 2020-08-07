/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyTwiggleManager : MonoBehaviour // TypeDefIndex: 10504
{
	// Fields
	public BuildersFollyTwiggle twigglePrefab; // 0x20
	internal List<BuildersFollyData.BuildersFollyPath> paths; // 0x28
	internal bool levelEnded; // 0x30
	internal List<BuildersFollyTwiggle> activeTwiggles; // 0x38
	private List<BuildersFollyTwiggle> _cachedTwiggles; // 0x40
	private BuildersFollyGame _game; // 0x48

	// Constructors
	public BuildersFollyTwiggleManager(); // 0x0000000180ABB6A0-0x0000000180ABB720

	// Methods
	private void Start(); // 0x0000000180ABAAE0-0x0000000180ABAB80
	private void SpawnTwiggle(); // 0x0000000180ABA910-0x0000000180ABAAE0
	internal void SetupTwiggleManager(List<BuildersFollyData.BuildersFollyPath> inPaths); // 0x00000001803FA0C0-0x00000001803FA0D0
	internal void ActivateTwiggles(); // 0x0000000180AB93E0-0x0000000180ABA120
	internal void ClearTwiggles(); // 0x0000000180ABA390-0x0000000180ABA580
	private BuildersFollyTwiggle NeedsExitTwiggle(BuildersFollyData.Station inStation, int inIgnorePathIndex); // 0x0000000180ABA6C0-0x0000000180ABA910
	internal void StationPortChq(BuildersFollyData.Station inStation); // 0x0000000180ABAC80-0x0000000180ABB170
	internal void Celebrate(BuildersFollyTwiggle inTwiggle, BuildersFollyTwiggle.ECelebrateType inCelebrateType); // 0x0000000180ABA120-0x0000000180ABA390
	internal void StationBuildComplete(BuildersFollyData.Station inputStation); // 0x0000000180ABAB80-0x0000000180ABAC80
	internal bool EndLevelChq(); // 0x0000000180ABA580-0x0000000180ABA6C0
	internal void UpdateTwigglesMove(); // 0x0000000180ABB420-0x0000000180ABB6A0
	internal void UpdateTwiggleUnitMove(); // 0x0000000180ABB370-0x0000000180ABB420
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__6_0(); // 0x0000000180ABB170-0x0000000180ABB370
}

