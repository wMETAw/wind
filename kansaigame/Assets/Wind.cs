using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour {
	public float coefficient;   // 空気抵抗係数
	public Vector3 velocity;    // 風速

	void OnTriggerStay(Collider col) {
		if ( col.GetComponent<Rigidbody>() == null ) {
			return;
		}

		// 相対速度計算
		var relativeVelocity = velocity - col.GetComponent<Rigidbody>().velocity;

		// 空気抵抗を与える
		col.GetComponent<Rigidbody>().AddForce(coefficient * relativeVelocity);
	}


	public float speed = 0.4f;

	public void Update()
	{
		// 上下に対応する入力による上下移動
//		transform.GetComponent<Rigidbody>().velocity = new Vector3(0, Input.GetAxisRaw("Vertical") * speed, 0);

		if (Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0, 0, 1*0.1f));
		}
		if (Input.GetKey(KeyCode.E)){
			transform.Translate(new Vector3(0, 0, -1));
		}
		if (Input.GetKey(KeyCode.R)){
			transform.Translate(new Vector3(1, 0, 0));
		}
		if (Input.GetKey(KeyCode.Q)){
			transform.Translate(new Vector3(-1, 0, 0));
		}
	}
}