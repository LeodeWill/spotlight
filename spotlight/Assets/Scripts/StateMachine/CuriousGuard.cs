using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuriousGuard : GuardState {

    float timeBuffer;

    public GuardState Update(Watcher guard, Detectable target) {

        if (guard.radar.tracked != null) {
            timeBuffer += Time.deltaTime;
            if (timeBuffer >= guard.detectionDelay) {
                Debug.Log("HEY!!!");
                //return Chasing State
            }
        } else {
            timeBuffer -= Time.deltaTime;
            if (timeBuffer <= 0f) {
                guard.calmState.OnEnter(guard, target);
                return guard.calmState;
            }
        }

        return this;
    }

    public void OnEnter(Watcher guard, Detectable target) {
        timeBuffer = 0f;
    }
}
