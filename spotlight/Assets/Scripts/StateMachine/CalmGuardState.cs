using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmGuardState : GuardState {

    public GuardState Update(Watcher guard, Detectable target){
        return this;
    }
    
}
