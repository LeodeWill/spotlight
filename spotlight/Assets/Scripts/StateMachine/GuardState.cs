using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GuardState {
    GuardState Update(Watcher guard, Detectable target);

    void OnEnter(Watcher guard, Detectable target);

}
