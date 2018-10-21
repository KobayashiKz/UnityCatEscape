using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 時間差取得
        this.delta += Time.deltaTime;
        if (this.delta > this.span) {
            // 0.1秒間隔で、x軸が-6~6の場所にランダムにArrowを生成する
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
	}
}
