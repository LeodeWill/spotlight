using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectable : MonoBehaviour {
    protected bool noticed, chased;

    public virtual void OnNoticed(Watcher watcher){
        noticed = true;
    }

    public virtual void OnChased(Watcher watcher){
        chased = true;
    }

    public virtual void OnForgotten(Watcher watcher){
        noticed = false;
    }

    public virtual void OnLost(Watcher watcher) {
        chased = false;
    }
}
