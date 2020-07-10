/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

[CreateAssetMenu] // 0x00000001800B7C20-0x00000001800B7C50
public class BakeryLightmapGroup : ScriptableObject // TypeDefIndex: 8961
{
	// Fields
	[Range] // 0x00000001800B7EF0-0x00000001800B7F30
	[SerializeField] // 0x00000001800B7EF0-0x00000001800B7F30
	public int resolution; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int bitmask; // 0x1C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int id; // 0x20
	public int sortingID; // 0x24
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public bool isImplicit; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public float area; // 0x2C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int totalVertexCount; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int vertexCounter; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int sceneLodLevel; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public string sceneName; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public bool containsTerrains; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public bool probes; // 0x49
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public ftLMGroupMode mode; // 0x4C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public RenderMode renderMode; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public RenderDirMode renderDirMode; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public bool computeSSS; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public int sssSamples; // 0x5C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public float sssDensity; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public Color sssColor; // 0x64

	// Nested types
	public enum ftLMGroupMode // TypeDefIndex: 8962
	{
		OriginalUV = 0,
		PackAtlas = 1,
		Vertex = 2
	}

	public enum RenderMode // TypeDefIndex: 8963
	{
		FullLighting = 0,
		Indirect = 1,
		Shadowmask = 2,
		Auto = 1000
	}

	public enum RenderDirMode // TypeDefIndex: 8964
	{
		None = 0,
		BakedNormalMaps = 1,
		DominantDirection = 2,
		RNM = 3,
		SH = 4,
		ProbeSH = 5,
		Auto = 1000
	}

	// Constructors
	public BakeryLightmapGroup(); // 0x00000001822BDA20-0x00000001822BDA90

	// Methods
	public BakeryLightmapGroupPlain GetPlainStruct(); // 0x00000001822BD980-0x00000001822BDA20
}

