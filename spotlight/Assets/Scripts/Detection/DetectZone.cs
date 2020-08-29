using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectZone : MonoBehaviour {
    
    [HideInInspector] public Detector detector;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (detector == null) return;

        Detectable target = other.GetComponent<Detectable>();
        detector.OnTargetInSight(target);
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (detector == null) return;

        Detectable target = other.GetComponent<Detectable>();
        detector.OnTargetOutSight(target);
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
