using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmGuardState : GuardState {

    public GuardState Update(Watcher guard, Detectable target){

        if (target != null) {
            Debug.Log("What was that??");
            guard.target.OnNoticed(guard);
            guard.curiousState.OnEnter(guard, target);
            return guard.curiousState;
        }

        return this;
    }

    public void OnEnter(Watcher guard, Detectable target) {
      
    }
}
