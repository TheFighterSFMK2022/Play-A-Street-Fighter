using System.Collections;
using UnityEngine;

public class HitColider : MonoBehaviour
{
	public string punchName;
	public float punchWeak;
	public float punchUp;
	public Fighter owner;

	void OnTriggerEnter(Collider other)
	{
		Fighter somebody = other.gameObject.GetComponent<Fighter>();
		if (owner.attacking)
		{
			if (somebody != null && somebody != owner)
			{
				somebody.hurt(punchWeak);
			}
			
		}
		else if (owner.attackingVolar)
			if (somebody != null && somebody != owner)
			{
				somebody.hurt2(punchUp);
			}

	}

	
}
