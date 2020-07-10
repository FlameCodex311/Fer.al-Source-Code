/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
public class ftLightmapsStorage : UnityEngine.MonoBehaviour // TypeDefIndex: 8974
{
	// Fields
	public List<Texture2D> maps; // 0x18
	public List<Texture2D> masks; // 0x20
	public List<Texture2D> dirMaps; // 0x28
	public List<Texture2D> rnmMaps0; // 0x30
	public List<Texture2D> rnmMaps1; // 0x38
	public List<Texture2D> rnmMaps2; // 0x40
	public List<int> mapsMode; // 0x48
	public List<MeshRenderer> bakedRenderers; // 0x50
	public List<int> bakedIDs; // 0x58
	public List<Vector4> bakedScaleOffset; // 0x60
	public List<Mesh> bakedVertexColorMesh; // 0x68
	public List<MeshRenderer> nonBakedRenderers; // 0x70
	public List<Light> bakedLights; // 0x78
	public List<int> bakedLightChannels; // 0x80
	public List<Terrain> bakedRenderersTerrain; // 0x88
	public List<int> bakedIDsTerrain; // 0x90
	public List<Vector4> bakedScaleOffsetTerrain; // 0x98
	public List<string> assetList; // 0xA0
	public List<int> uvOverlapAssetList; // 0xA8
	public int[] idremap; // 0xB0
	public bool usesRealtimeGI; // 0xB8
	public Texture2D emptyDirectionTex; // 0xC0

	// Constructors
	public ftLightmapsStorage(); // 0x00000001822BDCF0-0x00000001822BDFD0

	// Methods
	private void Awake(); // 0x00000001822BDB70-0x00000001822BDC00
	private void Start(); // 0x00000001822BDC60-0x00000001822BDCF0
	private void OnDestroy(); // 0x00000001822BDC00-0x00000001822BDC60
}

