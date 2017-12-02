// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ToolType : ScriptableObject 
{
	[Tooltip("The material can be broken by this tool.")]
	public List<MaterialType> breakableTypeList = new List<MaterialType>();

	public Sprite sprite;

	public bool IsBreakable(MaterialType type) {
		return breakableTypeList.Contains (type);
	}
}