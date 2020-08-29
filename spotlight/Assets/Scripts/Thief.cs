using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Detectable {

    protected bool hidden = false;
    public Watcher guard = null;

    public int state = 0;

    public override void OnNoticed(Watcher watcher){
        base.OnNoticed(watcher);
        guard = watcher;
        state = 1;
    }

    public override void OnLost(Watcher watcher){
        base.OnForgotten(watcher);
        guard = null;
        state = 0;
    }

    public override void OnChased(Watcher watcher){
        base.OnChased(watcher);
        guard = watcher;
        state = 2;
    }

    public void SwitchHide(){
        if (state < 2) {
            hidden = !hidden;
            if(guard != null) guard.SetHiddenThief(hidden);
            
        }
    }
}
