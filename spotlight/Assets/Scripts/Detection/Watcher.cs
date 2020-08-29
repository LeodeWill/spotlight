﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watcher : MonoBehaviour {

    public Detector radar;
    public GuardState state;

    GuardState calmState;
    Thief target = null;

    public bool alert = false;

    public float chaseDelay = 3f, loseRate = 0.1f;

    private void Awake() {
        radar.watcher = this;
        calmState = new CalmGuardState();
    }

    private void Update() {
        state = state.Update(this, target);
    }

    public void OnSeeingThings(Detectable target) {
        if (target is Thief){

        }
    }

    public void OnLostSight(Detectable target) {
        if (target is Thief) {
            //search
        }
    }

    public void SetHiddenThief(bool value){
    }
}
