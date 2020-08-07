/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
public class Outline : MonoBehaviour // TypeDefIndex: 11452
{
	// Fields
	private static HashSet<Mesh> registeredMeshes; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Mode outlineMode; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color outlineColor; // 0x24
	[Range] // 0x00000001801EAD10-0x00000001801EAD50
	[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
	private float outlineWidth; // 0x34
	[Header] // 0x00000001801EAE70-0x00000001801EAEE0
	[SerializeField] // 0x00000001801EAE70-0x00000001801EAEE0
	[Tooltip] // 0x00000001801EAE70-0x00000001801EAEE0
	private bool precomputeOutline; // 0x38
	[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
	[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
	private List<Mesh> bakeKeys; // 0x40
	[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
	[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
	private List<ListVector3> bakeValues; // 0x48
	private Renderer[] renderers; // 0x50
	private Material outlineMaskMaterial; // 0x58
	private Material outlineFillMaterial; // 0x60
	private bool needsUpdate; // 0x68

	// Properties
	public Mode OutlineMode { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001806CEB00-0x00000001806CEB10
	public Color OutlineColor { get; set; } // 0x00000001806CEAD0-0x00000001806CEAE0 0x00000001806CEAF0-0x00000001806CEB00
	public float OutlineWidth { get; set; } // 0x00000001806CEAE0-0x00000001806CEAF0 0x00000001806CEB10-0x00000001806CEB20

	// Nested types
	public enum Mode // TypeDefIndex: 11453
	{
		OutlineAll = 0,
		OutlineVisible = 1,
		OutlineHidden = 2,
		OutlineAndSilhouette = 3,
		SilhouetteOnly = 4
	}

	[Serializable]
	private class ListVector3 // TypeDefIndex: 11454
	{
		// Fields
		public List<Vector3> data; // 0x10

		// Constructors
		public ListVector3(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11455
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__30_0; // 0x08
		public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__30_1; // 0x10

		// Constructors
		static <>c(); // 0x00000001806D9A60-0x00000001806D9AC0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal KeyValuePair<Vector3, int> <SmoothNormals>b__30_0(Vector3 vertex, int index); // 0x00000001806D9850-0x00000001806D98D0
		internal Vector3 <SmoothNormals>b__30_1(KeyValuePair<Vector3, int> pair); // 0x00000001806D98D0-0x00000001806D9920
	}

	// Constructors
	public Outline(); // 0x00000001806CEA30-0x00000001806CEAD0
	static Outline(); // 0x00000001806CE9D0-0x00000001806CEA30

	// Methods
	private void Awake(); // 0x00000001806CD730-0x00000001806CD830
	private void OnEnable(); // 0x00000001806CDE70-0x00000001806CDF90
	private void OnValidate(); // 0x00000001806CDF90-0x00000001806CE060
	private void Update(); // 0x00000001806CE9B0-0x00000001806CE9D0
	private void OnDisable(); // 0x00000001806CDD50-0x00000001806CDE70
	private void OnDestroy(); // 0x00000001806CDCE0-0x00000001806CDD50
	private void Bake(); // 0x00000001806CD830-0x00000001806CD9E0
	private void LoadSmoothNormals(); // 0x00000001806CD9E0-0x00000001806CDCE0
	private List<Vector3> SmoothNormals(Mesh mesh); // 0x00000001806CE060-0x00000001806CE6F0
	private void UpdateMaterialProperties(); // 0x00000001806CE6F0-0x00000001806CE9B0
}

