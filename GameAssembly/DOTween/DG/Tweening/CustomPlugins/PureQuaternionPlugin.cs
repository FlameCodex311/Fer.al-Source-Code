/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 5660
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin(); // 0x0000000180BD09D0-0x0000000180BD0AA0
	
		// Methods
		public static PureQuaternionPlugin Plug(); // 0x0000000180BD06A0-0x0000000180BD0740
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative); // 0x0000000180BD0800-0x0000000180BD0920
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately); // 0x0000000180BD0770-0x0000000180BD0800
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value); // 0x0000000180BC0D10-0x0000000180BC0D20
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000180BD0920-0x0000000180BD09D0
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000180BD0740-0x0000000180BD0770
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue); // 0x0000000180BD0640-0x0000000180BD06A0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BD0510-0x0000000180BD0640
	}
}
