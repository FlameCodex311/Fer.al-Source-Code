/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BundleDownloadCollection : QRoutineCollection // TypeDefIndex: 13555
{
	// Fields
	private GameObject _targetGameObject; // 0x20

	// Constructors
	public BundleDownloadCollection(GameObject inTargetGameObject); // 0x00000001813DCE30-0x00000001813DCE60

	// Methods
	public QRoutine AddBundleLoadIfExists<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783E44 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783E48 */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleLoad<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783E4C */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783E50 */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleInstantiateIfExists<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783E54 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783E58 */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleInstantiate<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783E5C */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783E60 */)
		where T : UnityEngine.Object;
}

