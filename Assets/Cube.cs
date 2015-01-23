using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{

    public GameObject Prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            var r = Random.Range(0, 255) / 255.0f;
            var g = Random.Range(0, 255) / 255.0f;
            var b = Random.Range(0, 255) / 255.0f;

            Prefab.renderer.material.color = new Color(r, g, b);

            var clickPosition = Input.mousePosition;
            clickPosition.z = 10f;
            Instantiate(Prefab, Camera.main.ScreenToWorldPoint(clickPosition), Prefab.transform.rotation);
        }	
	}
}
