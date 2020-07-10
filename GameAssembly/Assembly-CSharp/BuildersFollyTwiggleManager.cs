/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyTwiggleManager : MonoBehaviour // TypeDefIndex: 12846
{
	// Fields
	public BuildersFollyTwiggle twigglePrefab; // 0x20
	internal List<BuildersFollyData.BuildersFollyPath> paths; // 0x28
	internal bool levelEnded; // 0x30
	internal List<BuildersFollyTwiggle> activeTwiggles; // 0x38
	private List<BuildersFollyTwiggle> _cachedTwiggles; // 0x40
	private BuildersFollyGame _game; // 0x48

	// Constructors
	public BuildersFollyTwiggleManager(); // 0x00000001813CB6D0-0x00000001813CB750

	// Methods
	private void Start(); // 0x00000001813CAAB0-0x00000001813CAB50
	private void SpawnTwiggle(); // 0x00000001813CA8D0-0x00000001813CAAB0
	internal void SetupTwiggleManager(List<BuildersFollyData.BuildersFollyPath> inPaths); // 0x0000000180422D30-0x0000000180422D40
	internal void ActivateTwiggles(); // 0x00000001813C92E0-0x00000001813CA0A0
	internal void ClearTwiggles(); // 0x00000001813CA320-0x00000001813CA520
	private BuildersFollyTwiggle NeedsExitTwiggle(BuildersFollyData.Station inStation, int inIgnorePathIndex); // 0x00000001813CA660-0x00000001813CA8D0
	internal void StationPortChq(BuildersFollyData.Station inStation); // 0x00000001813CAC60-0x00000001813CB190
	internal void Celebrate(BuildersFollyTwiggle inTwiggle, BuildersFollyTwiggle.ECelebrateType inCelebrateType); // 0x00000001813CA0A0-0x00000001813CA320
	internal void StationBuildComplete(BuildersFollyData.Station inputStation); // 0x00000001813CAB50-0x00000001813CAC60
	internal bool EndLevelChq(); // 0x00000001813CA520-0x00000001813CA660
	internal void UpdateTwigglesMove(); // 0x00000001813CB440-0x00000001813CB6D0
	internal void UpdateTwiggleUnitMove(); // 0x00000001813CB390-0x00000001813CB440
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__6_0(); // 0x00000001813CB190-0x00000001813CB390
}

