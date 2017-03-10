using UnityEngine;
using System.Collections;

public class firebullet : MonoBehaviour {

	public Transform enamy; // 敵人位置
	public GameObject bullet; // 砲彈物件
	public float tiem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		tiem += Time.deltaTime;

		if (enamy != null) {

			if (tiem >= 0.5f) {
				GameObject _bull = Instantiate (bullet, transform.position, transform.rotation) as GameObject; // 建立砲彈
				_bull.transform.LookAt (enamy); // 面向敵人
				Destroy(_bull, 5f); // 五秒內自動刪除子彈
				tiem = 0;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		enamy = other.transform; // 敵人進入範圍內，就設定敵人物件

	}

}
