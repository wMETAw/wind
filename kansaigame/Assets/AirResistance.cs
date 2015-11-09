using UnityEngine;
using System.Collections;

public class AirResistance : MonoBehaviour {

	public float coefficient;   // 空気抵抗係数

	void FixedUpdate() {

		// 空気抵抗を与える
		this.GetComponent<Rigidbody>().AddForce(-coefficient * GetComponent<Rigidbody>().velocity);
	}
}