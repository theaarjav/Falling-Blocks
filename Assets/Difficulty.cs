using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty{

	static float secToMax = 60;

	public static float GetDiffPer(){
		
		return Mathf.Clamp01(Time.timeSinceLevelLoad / secToMax);
			}

}
