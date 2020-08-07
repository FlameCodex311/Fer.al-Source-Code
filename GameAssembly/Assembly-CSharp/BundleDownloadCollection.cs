/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BundleDownloadCollection : QRoutineCollection // TypeDefIndex: 11226
{
	// Fields
	private GameObject _targetGameObject; // 0x20

	// Constructors
	public BundleDownloadCollection(GameObject inTargetGameObject); // 0x00000001804953D0-0x0000000180495400

	// Methods
	public QRoutine AddBundleLoadIfExists<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C903 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C907 */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleLoad<T>(string inBundleID, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C90B */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C90F */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleInstantiateIfExists<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C913 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C917 */)
		where T : UnityEngine.Object;
	public QRoutine AddBundleInstantiate<T>(string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResultAction, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C91B */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C91F */)
		where T : UnityEngine.Object;
}

