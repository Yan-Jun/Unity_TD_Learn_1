using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public NavMeshAgent player;
	public Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("end").transform; //怪物的終點,位子
	}
	
	// Update is called once per frame
	void Update () {
		player.destination = target.position;//怪物目標=終點
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "end") {     //怪物碰到終點消失
			Destroy (gameObject);
		}
		if (other.tag == "bullet") {   //怪物碰到子彈消失，子彈也消失
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
}
