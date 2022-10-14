using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadokenStateBehavior : FighterStageBehavior
{
	override public void OnStateEnter(Animator animator,
									  AnimatorStateInfo stateInfo, int layerIndex)
	{
		base.OnStateEnter(animator, stateInfo, layerIndex);

		float fighterX = fighter.transform.position.x;

		GameObject instance = Object.Instantiate(
			Resources.Load("Sfx/HADOKEN"),
			new Vector3(fighterX, 4, -2),
			Quaternion.Euler(0, 0, 0)
			) as GameObject;

		Hadoken hadoken = instance.GetComponent<Hadoken>();
		hadoken.caster = fighter;
	}
}
