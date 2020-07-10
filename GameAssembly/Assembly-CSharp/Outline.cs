/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
public class Outline : MonoBehaviour // TypeDefIndex: 13779
{
	// Fields
	private static HashSet<Mesh> registeredMeshes; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Mode outlineMode; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color outlineColor; // 0x24
	[Range] // 0x00000001800F93B0-0x00000001800F93F0
	[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
	private float outlineWidth; // 0x34
	[Header] // 0x000000018010D9E0-0x000000018010DA50
	[SerializeField] // 0x000000018010D9E0-0x000000018010DA50
	[Tooltip] // 0x000000018010D9E0-0x000000018010DA50
	private bool precomputeOutline; // 0x38
	[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
	[SerializeField] // 0x00000001800B4050-0x00000001800B4080
	private List<Mesh> bakeKeys; // 0x40
	[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
	[SerializeField] // 0x00000001800B4050-0x00000001800B4080
	private List<ListVector3> bakeValues; // 0x48
	private Renderer[] renderers; // 0x50
	private Material outlineMaskMaterial; // 0x58
	private Material outlineFillMaterial; // 0x60
	private bool needsUpdate; // 0x68

	// Properties
	public Mode OutlineMode { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x0000000180E98280-0x0000000180E98290
	public Color OutlineColor { get; set; } // 0x0000000180E98260-0x0000000180E98270 0x0000000180E98270-0x0000000180E98280
	public float OutlineWidth { get; set; } // 0x00000001804C16A0-0x00000001804C16B0 0x0000000180E98290-0x0000000180E982A0

	// Nested types
	public enum Mode // TypeDefIndex: 13780
	{
		OutlineAll = 0,
		OutlineVisible = 1,
		OutlineHidden = 2,
		OutlineAndSilhouette = 3,
		SilhouetteOnly = 4
	}

	[Serializable]
	private class ListVector3 // TypeDefIndex: 13781
	{
		// Fields
		public List<Vector3> data; // 0x10

		// Constructors
		public ListVector3(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13782
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__30_0; // 0x08
		public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__30_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9A990-0x0000000180E9A9F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal KeyValuePair<Vector3, int> <SmoothNormals>b__30_0(Vector3 vertex, int index); // 0x0000000180E9A8C0-0x0000000180E9A940
		internal Vector3 <SmoothNormals>b__30_1(KeyValuePair<Vector3, int> pair); // 0x0000000180E9A940-0x0000000180E9A990
	}

	// Constructors
	public Outline(); // 0x0000000180E981C0-0x0000000180E98260
	static Outline(); // 0x0000000180E98160-0x0000000180E981C0

	// Methods
	private void Awake(); // 0x0000000180E96E60-0x0000000180E96F60
	private void OnEnable(); // 0x0000000180E975D0-0x0000000180E97700
	private void OnValidate(); // 0x0000000180E97700-0x0000000180E977D0
	private void Update(); // 0x0000000180E98140-0x0000000180E98160
	private void OnDisable(); // 0x0000000180E974A0-0x0000000180E975D0
	private void OnDestroy(); // 0x0000000180E97430-0x0000000180E974A0
	private void Bake(); // 0x0000000180E96F60-0x0000000180E97120
	private void LoadSmoothNormals(); // 0x0000000180E97120-0x0000000180E97430
	private List<Vector3> SmoothNormals(Mesh mesh); // 0x0000000180E977D0-0x0000000180E97E80
	private void UpdateMaterialProperties(); // 0x0000000180E97E80-0x0000000180E98140
}

