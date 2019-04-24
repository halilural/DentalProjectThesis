using UnityEngine;
using System.Collections;

public class BracketManager : MonoBehaviour {

    [SerializeField]
    private GameObject _teeth;

	// Use this for initialization
	void Start () {
        this.transform.parent = _teeth.transform;
        //this.transform.localScale = new Vector3(1, 1, 1);
        this.transform.localPosition = new Vector3(0, 0, 0);
        //this.transform.localRotation = new Quaternion(0, 0, 0, 0);
        //this.transform.localScale = _teeth.transform.parent.localScale;
        //this.transform.rotation = _teeth.transform.localRotation;
        //this.transform.localScale = _teeth.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
