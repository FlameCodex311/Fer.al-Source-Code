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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 5819
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin(); // 0x0000000181793AC0-0x0000000181793B90
	
		// Methods
		public static PureQuaternionPlugin Plug(); // 0x00000001817937A0-0x0000000181793840
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative); // 0x0000000181793900-0x0000000181793A10
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately); // 0x0000000181793870-0x0000000181793900
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value); // 0x0000000181784430-0x0000000181784440
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000181793A10-0x0000000181793AC0
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000181793840-0x0000000181793870
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue); // 0x0000000181793740-0x00000001817937A0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000181793620-0x0000000181793740
	}
}
