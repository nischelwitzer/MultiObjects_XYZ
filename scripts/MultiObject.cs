using UnityEngine;
using System.Collections;

public class MultiObject : MonoBehaviour {

    public GameObject showALot;
    private Renderer   rend;

    // Use this for initialization
    void Start () {

        int runx;
        int runy;
        int runz;

        // gameObject.GetComponent<Renderer>().material.color = Color.green;

        for (runx = -5; runx<5; runx++)
            for (runy = 1; runy < 20; runy++)
                for (runz = -5; runz < 5; runz++)
                {

                    // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    // cube.AddComponent<Rigidbody>();
                    // cube.transform.position = new Vector3(x, y, 0);

                    GameObject clone;
                    Vector3 goVector = new Vector3(runx, (runy+5)/5F, runz);
                    clone = (GameObject) Instantiate(showALot, goVector, Quaternion.identity);

                    rend = clone.GetComponent<Renderer>();

                    Color aColor = new Vector4((runx+5)/10F, (runy-1)/20F, (runz+5)/10F, 1);
                    rend.material.SetColor("_Color", aColor);

                    // transform.position = goVector;
                }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
