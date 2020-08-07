/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 9367
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x00779727
		public const int elementId_positionY = 2; // Metadata: 0x0077972B
		public const int elementId_positionZ = 0; // Metadata: 0x0077972F
		public const int elementId_rotationX = 3; // Metadata: 0x00779733
		public const int elementId_rotationY = 5; // Metadata: 0x00779737
		public const int elementId_rotationZ = 4; // Metadata: 0x0077973B
		public const int elementId_throttle1Axis = 6; // Metadata: 0x0077973F
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x00779743
		public const int elementId_throttle2Axis = 7; // Metadata: 0x00779747
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x0077974B
		public const int elementId_extraAxis1 = 8; // Metadata: 0x0077974F
		public const int elementId_extraAxis2 = 9; // Metadata: 0x00779753
		public const int elementId_extraAxis3 = 10; // Metadata: 0x00779757
		public const int elementId_extraAxis4 = 11; // Metadata: 0x0077975B
		public const int elementId_button1 = 12; // Metadata: 0x0077975F
		public const int elementId_button2 = 13; // Metadata: 0x00779763
		public const int elementId_button3 = 14; // Metadata: 0x00779767
		public const int elementId_button4 = 15; // Metadata: 0x0077976B
		public const int elementId_button5 = 16; // Metadata: 0x0077976F
		public const int elementId_button6 = 17; // Metadata: 0x00779773
		public const int elementId_button7 = 18; // Metadata: 0x00779777
		public const int elementId_button8 = 19; // Metadata: 0x0077977B
		public const int elementId_button9 = 20; // Metadata: 0x0077977F
		public const int elementId_button10 = 21; // Metadata: 0x00779783
		public const int elementId_button11 = 22; // Metadata: 0x00779787
		public const int elementId_button12 = 23; // Metadata: 0x0077978B
		public const int elementId_button13 = 24; // Metadata: 0x0077978F
		public const int elementId_button14 = 25; // Metadata: 0x00779793
		public const int elementId_button15 = 26; // Metadata: 0x00779797
		public const int elementId_button16 = 27; // Metadata: 0x0077979B
		public const int elementId_button17 = 28; // Metadata: 0x0077979F
		public const int elementId_button18 = 29; // Metadata: 0x007797A3
		public const int elementId_button19 = 30; // Metadata: 0x007797A7
		public const int elementId_button20 = 31; // Metadata: 0x007797AB
		public const int elementId_button21 = 55; // Metadata: 0x007797AF
		public const int elementId_button22 = 56; // Metadata: 0x007797B3
		public const int elementId_button23 = 57; // Metadata: 0x007797B7
		public const int elementId_button24 = 58; // Metadata: 0x007797BB
		public const int elementId_button25 = 59; // Metadata: 0x007797BF
		public const int elementId_button26 = 60; // Metadata: 0x007797C3
		public const int elementId_button27 = 61; // Metadata: 0x007797C7
		public const int elementId_button28 = 62; // Metadata: 0x007797CB
		public const int elementId_button29 = 63; // Metadata: 0x007797CF
		public const int elementId_button30 = 64; // Metadata: 0x007797D3
		public const int elementId_button31 = 65; // Metadata: 0x007797D7
		public const int elementId_button32 = 66; // Metadata: 0x007797DB
		public const int elementId_hat1Up = 32; // Metadata: 0x007797DF
		public const int elementId_hat1UpRight = 33; // Metadata: 0x007797E3
		public const int elementId_hat1Right = 34; // Metadata: 0x007797E7
		public const int elementId_hat1DownRight = 35; // Metadata: 0x007797EB
		public const int elementId_hat1Down = 36; // Metadata: 0x007797EF
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x007797F3
		public const int elementId_hat1Left = 38; // Metadata: 0x007797F7
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x007797FB
		public const int elementId_hat2Up = 40; // Metadata: 0x007797FF
		public const int elementId_hat2UpRight = 41; // Metadata: 0x00779803
		public const int elementId_hat2Right = 42; // Metadata: 0x00779807
		public const int elementId_hat2DownRight = 43; // Metadata: 0x0077980B
		public const int elementId_hat2Down = 44; // Metadata: 0x0077980F
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x00779813
		public const int elementId_hat2Left = 46; // Metadata: 0x00779817
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x0077981B
		public const int elementId_hat1 = 48; // Metadata: 0x0077981F
		public const int elementId_hat2 = 49; // Metadata: 0x00779823
		public const int elementId_throttle1 = 52; // Metadata: 0x00779827
		public const int elementId_throttle2 = 53; // Metadata: 0x0077982B
		public const int elementId_stick = 54; // Metadata: 0x0077982F
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get; } // 0x00000001820C6EB0-0x00000001820C6EF0 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get; } // 0x00000001820C6EF0-0x00000001820C6F30 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get; } // 0x00000001820C6F30-0x00000001820C6F70 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get; } // 0x00000001820C6F70-0x00000001820C6FB0 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get; } // 0x00000001820C6930-0x00000001820C6970 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get; } // 0x00000001820C6BF0-0x00000001820C6C30 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get; } // 0x00000001820C6CF0-0x00000001820C6D30 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get; } // 0x00000001820C6D30-0x00000001820C6D70 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get; } // 0x00000001820C6D70-0x00000001820C6DB0 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get; } // 0x00000001820C6DB0-0x00000001820C6DF0 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get; } // 0x00000001820C6DF0-0x00000001820C6E30 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get; } // 0x00000001820C6E30-0x00000001820C6E70 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get; } // 0x00000001820C6E70-0x00000001820C6EB0 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get; } // 0x00000001820C66B0-0x00000001820C66F0 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get; } // 0x00000001820C66F0-0x00000001820C6730 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get; } // 0x00000001820C6730-0x00000001820C6770 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get; } // 0x00000001820C6770-0x00000001820C67B0 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get; } // 0x00000001820C67B0-0x00000001820C67F0 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get; } // 0x00000001820C67F0-0x00000001820C6830 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get; } // 0x00000001820C6830-0x00000001820C6870 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get; } // 0x00000001820C6870-0x00000001820C68B0 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get; } // 0x00000001820C68B0-0x00000001820C68F0 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get; } // 0x00000001820C68F0-0x00000001820C6930 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get; } // 0x00000001820C6970-0x00000001820C69B0 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get; } // 0x00000001820C69B0-0x00000001820C69F0 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get; } // 0x00000001820C69F0-0x00000001820C6A30 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get; } // 0x00000001820C6A30-0x00000001820C6A70 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get; } // 0x00000001820C6A70-0x00000001820C6AB0 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get; } // 0x00000001820C6AB0-0x00000001820C6AF0 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get; } // 0x00000001820C6AF0-0x00000001820C6B30 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get; } // 0x00000001820C6B30-0x00000001820C6B70 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get; } // 0x00000001820C6B70-0x00000001820C6BB0 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get; } // 0x00000001820C6BB0-0x00000001820C6BF0 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get; } // 0x00000001820C6C30-0x00000001820C6C70 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get; } // 0x00000001820C6C70-0x00000001820C6CB0 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get; } // 0x00000001820C6CB0-0x00000001820C6CF0 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get; } // 0x00000001820C6FB0-0x00000001820C6FF0 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get; } // 0x00000001820C6FF0-0x00000001820C7030 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get; } // 0x00000001820C7070-0x00000001820C70B0 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get; } // 0x00000001820C70B0-0x00000001820C70F0 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get; } // 0x00000001820C7030-0x00000001820C7070 
	
		// Constructors
		public SixDofControllerTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static SixDofControllerTemplate(); // 0x00000001820C70F0-0x00000001820C7150
	}
}
