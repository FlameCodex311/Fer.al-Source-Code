/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class CoreTransformExtensions // TypeDefIndex: 11084
{
	// Fields
	private static List<Transform> _splitMaterialsTracked; // 0x00

	// Constructors
	static CoreTransformExtensions(); // 0x0000000180AA82F0-0x0000000180AA8350

	// Extension methods
	public static void SetParentAndResetToZero(this Transform inTransform, Transform inParent); // 0x0000000180AA74B0-0x0000000180AA75C0
	public static void ResetToZero(this Transform inTransform); // 0x0000000180AA5FC0-0x0000000180AA60C0
	public static Transform FindChildByName(this Transform inParent, string inFindName, bool inExcludeParent = false /* Metadata: 0x0077C75C */, bool inExactName = false /* Metadata: 0x0077C75D */, bool inCaseSensitive = false /* Metadata: 0x0077C75E */); // 0x0000000180AA4B90-0x0000000180AA4E60
	public static Transform FindRootParent(this Transform inParent); // 0x0000000180AA52F0-0x0000000180AA53B0
	public static Transform FindParentContainingName(this Transform inParent, string inName); // 0x0000000180AA51B0-0x0000000180AA52F0
	public static Transform FindSkinnedMeshObject(this Transform inParent, bool InExcludeParent = false /* Metadata: 0x0077C75F */); // 0x0000000180AA5540-0x0000000180AA56A0
	public static Transform FindSkinnedMeshObjectContainingName(this Transform inParent, string inContaining, bool InExcludeParent = false /* Metadata: 0x0077C760 */); // 0x0000000180AA53B0-0x0000000180AA5540
	public static List<Transform> FindChildrenByName(this Transform inParent, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inName); // 0x0000000180AA4E60-0x0000000180AA51B0
	public static void SetLayer(this Transform InParent, int InLayer); // 0x0000000180AA73A0-0x0000000180AA74B0
	public static void SetStatic(this Transform InParent, bool InStatic); // 0x0000000180AA7880-0x0000000180AA7A70
	public static void SetAllChildColors(this Transform inParent, string inMatParam, Color inColor, bool inShared = true /* Metadata: 0x0077C761 */); // 0x0000000180AA61C0-0x0000000180AA6560
	public static void SplitAllMaterialsTracked(this Transform inParent); // 0x0000000180AA7C10-0x0000000180AA8020
	public static void SplitAllMaterials(this Transform inParent); // 0x0000000180AA8020-0x0000000180AA82F0
	public static void DisableGlobalAmbientColor(this Transform inParent, bool inForceDisable = false /* Metadata: 0x0077C762 */); // 0x0000000180AA4900-0x0000000180AA4B90
	public static List<Material> GetAllMaterials(this Transform inParent, string inShaderName = "" /* Metadata: 0x0077C763 */); // 0x0000000180AA5B10-0x0000000180AA5DA0
	public static void SetTexture(this Transform inParent, string inMatParam, Texture2D inTexture); // 0x0000000180AA7A70-0x0000000180AA7C10
	public static void SetAllChildTextures(this Transform inParent, string inMatParam, Texture2D inTexture); // 0x0000000180AA7220-0x0000000180AA73A0
	public static T GetChildComponentOfType<T>(this Transform inTransform)
		where T : Component;
	public static List<T> GetAllComponentsOfType<T>(this Transform inParent)
		where T : Component;
	public static List<MeshCollider> GetAllChildMeshColliders(this Transform inParent, bool inVerifyRigidbody = false /* Metadata: 0x0077C767 */); // 0x0000000180AA56A0-0x0000000180AA59B0
	public static T GetComponentInParentWW<T>(this Transform inParent)
		where T : Component;
	public static List<Transform> GetAllChildTransforms(this Transform inParent); // 0x0000000180AA59B0-0x0000000180AA5B10
	public static List<T> GetAllComponentsInChildren<T>(this Transform inParent);
	public static void SetAllChildShaders(this Transform inParent, Shader inShader, string inIgnoreName = null); // 0x0000000180AA7070-0x0000000180AA7220
	public static void SetAllChildShaderLODs(this Transform inParent, int inLOD, string inIgnoreName = null); // 0x0000000180AA6D30-0x0000000180AA6F00
	public static void SetAllChildShaderColor(this Transform inParent, string inColorName, Color inColor, string inIgnoreName = null); // 0x0000000180AA68C0-0x0000000180AA6AB0
	public static void SetAllChildShaderKeywords(this Transform inParent, string[] inEnableKeywords, string[] inDisableKeywords, string inIgnoreName = null); // 0x0000000180AA6AB0-0x0000000180AA6D30
	public static void SetAllChildMultiShaderQuality(this Transform inParent, AssetQualityLevel inQuality); // 0x0000000180AA6810-0x0000000180AA68C0
	public static void SetAllChildMultiShaderDirty(this Transform inParent, bool inEnabled); // 0x0000000180AA6560-0x0000000180AA6610
	public static void SetAllChildMultiShaderKeyword(this Transform inParent, string inEnableKeyword, string inDisableKeyword, string inIgnoreName = null); // 0x0000000180AA6610-0x0000000180AA6810
	public static void SetAllChildShaders(this Transform inParent, string inShader); // 0x0000000180AA6F00-0x0000000180AA7070
	public static void ReplaceAllChildShaders(this Transform inParent, string inReplaceShader, string inShader); // 0x0000000180AA5DA0-0x0000000180AA5FC0
	public static void SetRecursiveEmission(this Transform inParent, bool inEnabled); // 0x0000000180AA7760-0x0000000180AA7880
	public static void SetActiveFXRecursively(this Transform inParent, bool active); // 0x0000000180AA60C0-0x0000000180AA61C0
	public static void SetParentUI(this Transform inTransform, Transform inParent); // 0x0000000180AA75C0-0x0000000180AA7760
	public static void Clear(this Transform inTransform); // 0x0000000180AA4800-0x0000000180AA4900
	public static float AngleTo(this Transform inTransform, Transform inOther); // 0x0000000180AA45E0-0x0000000180AA4720
	public static float AngleTo(this Transform inTransform, Vector3 inPosition); // 0x0000000180AA4720-0x0000000180AA4800
}

