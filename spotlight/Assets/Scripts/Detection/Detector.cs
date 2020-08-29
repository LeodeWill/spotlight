using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour {

    [HideInInspector] public Watcher watcher;
    List<DetectZone> sight;

    public Detectable tracked = null;

    private void Awake() {
        sight = new List<DetectZone>();
        DetectZone[] zones = GetComponentsInChildren<DetectZone>();

        foreach(DetectZone z in zones){
            z.detector = this;
            sight.Add(z);
        }
    }

    public void OnTargetInSight(Detectable target){
        tracked = target;
        watcher.OnSeeingThings(target);
    }

    public void OnTargetOutSight(Detectable target) {
        tracked = null;
        watcher.OnLostSight(target);
    }
}
