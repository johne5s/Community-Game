// Copyright 2021 Boppy Games, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWorldActionController : MonoBehaviour
{
  // The list of WorldActions that we're within range of. Only one of these actions is in "focus".
  readonly List<WorldAction> actions = new List<WorldAction>();
  // The action that we are focused on right now, this can be null if nothing is in focus.
  WorldAction focusedAction;


  void SetFocusedAction(WorldAction newAction)
  {
    if (focusedAction != null)
      focusedAction.FocusLost();
    focusedAction = newAction;
    if (focusedAction != null)
      focusedAction.FocusGained();
  }

  // Check to see if collider contains a WorldAction, if it does add it to the WorldAction list. if we have no
  // focused action, then this action becomes focused.
  void OnTriggerEnter(Collider collider) 
  {
    return;
  }

  // Check to see if collider contains a WorldAction, if it does, call RemoveWorldAction(WorldAction action)
  void OnTriggerExit(Collider collider) 
  {
    return;
  }

  public void RemoveWorldAction(WorldAction action)
  {
    actions.Remove(action);
    //if (activeAction == action)
      SetFocusedAction(null);
  }

  public WorldAction GetFocus() => focusedAction;

  // This is called by the player input manager when the player presses the activate button.
  public void Activate()
  {
    if (focusedAction != null)
      focusedAction.Activate();
  }
}
