/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreTransformExtensions // TypeDefIndex: 13413
{
	// Fields
	private static List<Transform> _splitMaterialsTracked; // 0x00

	// Constructors
	static CoreTransformExtensions(); // 0x0000000180F3B7A0-0x0000000180F3B800

	// Extension methods
	public static void SetParentAndResetToZero(this Transform inTransform, Transform inParent); // 0x0000000180F3A900-0x0000000180F3AA10
	public static void ResetToZero(this Transform inTransform); // 0x0000000180F392D0-0x0000000180F393D0
	public static Transform FindChildByName(this Transform inParent, string inFindName, bool inExcludeParent = false /* Metadata: 0x00783CA1 */, bool inExactName = false /* Metadata: 0x00783CA2 */, bool inCaseSensitive = false /* Metadata: 0x00783CA3 */); // 0x0000000180F37E70-0x0000000180F38150
	public static Transform FindRootParent(this Transform inParent); // 0x0000000180F385E0-0x0000000180F386A0
	public static Transform FindParentContainingName(this Transform inParent, string inName); // 0x0000000180F384B0-0x0000000180F385E0
	public static Transform FindSkinnedMeshObject(this Transform inParent, bool InExcludeParent = false /* Metadata: 0x00783CA4 */); // 0x0000000180F38830-0x0000000180F38990
	public static Transform FindSkinnedMeshObjectContainingName(this Transform inParent, string inContaining, bool InExcludeParent = false /* Metadata: 0x00783CA5 */); // 0x0000000180F386A0-0x0000000180F38830
	public static List<Transform> FindChildrenByName(this Transform inParent, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] inName); // 0x0000000180F38150-0x0000000180F384B0
	public static void SetLayer(this Transform InParent, int InLayer); // 0x0000000180F3A7E0-0x0000000180F3A900
	public static void SetStatic(this Transform InParent, bool InStatic); // 0x0000000180F3ACF0-0x0000000180F3AEF0
	public static void SetAllChildColors(this Transform inParent, string inMatParam, Color inColor, bool inShared = true /* Metadata: 0x00783CA6 */); // 0x0000000180F394D0-0x0000000180F39940
	public static void SplitAllMaterialsTracked(this Transform inParent); // 0x0000000180F3B0A0-0x0000000180F3B4C0
	public static void SplitAllMaterials(this Transform inParent); // 0x0000000180F3B4C0-0x0000000180F3B7A0
	public static void DisableGlobalAmbientColor(this Transform inParent, bool inForceDisable = false /* Metadata: 0x00783CA7 */); // 0x0000000180F37BD0-0x0000000180F37E70
	public static List<Material> GetAllMaterials(this Transform inParent, string inShaderName = "" /* Metadata: 0x00783CA8 */); // 0x0000000180F38E10-0x0000000180F390A0
	public static void SetTexture(this Transform inParent, string inMatParam, Texture2D inTexture); // 0x0000000180F3AEF0-0x0000000180F3B0A0
	public static void SetAllChildTextures(this Transform inParent, string inMatParam, Texture2D inTexture); // 0x0000000180F3A660-0x0000000180F3A7E0
	public static T GetChildComponentOfType<T>(this Transform inTransform)
		where T : Component;
	public static List<T> GetAllComponentsOfType<T>(this Transform inParent)
		where T : Component;
	public static List<MeshCollider> GetAllChildMeshColliders(this Transform inParent, bool inVerifyRigidbody = false /* Metadata: 0x00783CAC */); // 0x0000000180F38990-0x0000000180F38CB0
	public static T GetComponentInParentWW<T>(this Transform inParent)
		where T : Component;
	public static List<Transform> GetAllChildTransforms(this Transform inParent); // 0x0000000180F38CB0-0x0000000180F38E10
	public static List<T> GetAllComponentsInChildren<T>(this Transform inParent);
	public static void SetAllChildShaders(this Transform inParent, Shader inShader, string inIgnoreName = null); // 0x0000000180F3A4A0-0x0000000180F3A660
	public static void SetAllChildShaderLODs(this Transform inParent, int inLOD, string inIgnoreName = null); // 0x0000000180F3A150-0x0000000180F3A330
	public static void SetAllChildShaderColor(this Transform inParent, string inColorName, Color inColor, string inIgnoreName = null); // 0x0000000180F39CB0-0x0000000180F39EB0
	public static void SetAllChildShaderKeywords(this Transform inParent, string[] inEnableKeywords, string[] inDisableKeywords, string inIgnoreName = null); // 0x0000000180F39EB0-0x0000000180F3A150
	public static void SetAllChildMultiShaderQuality(this Transform inParent, AssetQualityLevel inQuality); // 0x0000000180F39C00-0x0000000180F39CB0
	public static void SetAllChildMultiShaderDirty(this Transform inParent, bool inEnabled); // 0x0000000180F39940-0x0000000180F399F0
	public static void SetAllChildMultiShaderKeyword(this Transform inParent, string inEnableKeyword, string inDisableKeyword, string inIgnoreName = null); // 0x0000000180F399F0-0x0000000180F39C00
	public static void SetAllChildShaders(this Transform inParent, string inShader); // 0x0000000180F3A330-0x0000000180F3A4A0
	public static void ReplaceAllChildShaders(this Transform inParent, string inReplaceShader, string inShader); // 0x0000000180F390A0-0x0000000180F392D0
	public static void SetRecursiveEmission(this Transform inParent, bool inEnabled); // 0x0000000180F3ABC0-0x0000000180F3ACF0
	public static void SetActiveFXRecursively(this Transform inParent, bool active); // 0x0000000180F393D0-0x0000000180F394D0
	public static void SetParentUI(this Transform inTransform, Transform inParent); // 0x0000000180F3AA10-0x0000000180F3ABC0
	public static void Clear(this Transform inTransform); // 0x0000000180F37AD0-0x0000000180F37BD0
	public static float AngleTo(this Transform inTransform, Transform inOther); // 0x0000000180F378B0-0x0000000180F379F0
	public static float AngleTo(this Transform inTransform, Vector3 inPosition); // 0x0000000180F379F0-0x0000000180F37AD0
}

