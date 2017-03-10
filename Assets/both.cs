using UnityEngine;
using System.Collections;

public class both : MonoBehaviour {

	public GameObject enamy;  //怪物物件
	public float tiem;  

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiem += Time.deltaTime;   //依照每frame 增加秒數

		if (tiem >= 1.5f) {
			GameObject obj = Instantiate (enamy, transform.position, transform.rotation) as GameObject; //生成怪物為位子方向，轉型
			tiem = 0;
		}
	}
}
