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


//attach this script to objects 
//IE
//  Doors
//  Shop NPCs
//  Chests
//  Drops from dead enemies
//  Quest objectives

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldAction : MonoBehaviour
{
  // Called when the player is within the interaction area of this object
  public void FocusGained()
  {
    gameObject.SendMessage("OnWorldActionActive");
  }

  // Called when the player has moved away from this object.
  public void FocusLost()
  {
    gameObject.SendMessage("OnWorldActionInactive");
  }

  // Called when the player has pressed the action button while within range of this object.
  public void Activate()
  {
    gameObject.SendMessage("OnWorldAction");
  }

  void OnDestroy()
  {
    //PlayerWorldActionController.RemoveAction(this);
  }
}
