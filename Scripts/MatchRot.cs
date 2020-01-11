using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchRot : MonoBehaviour {

    public Transform target;

    private void Update() {
        transform.rotation = target.rotation;
    }

}
