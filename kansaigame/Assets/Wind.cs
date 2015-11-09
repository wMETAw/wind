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


	public float speed = 6.0f;

	public void Update()
	{
		// 上下に対応する入力による上下移動
//		transform.GetComponent<Rigidbody>().velocity = new Vector3(0, Input.GetAxisRaw("Vertical") * speed, 0);

		if (Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(transform.forward * 1);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(transform.forward * -1);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(transform.right * 1);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(transform.right * -1);
		}
	}
}