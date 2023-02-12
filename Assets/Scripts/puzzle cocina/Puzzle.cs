using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
   private void OnEnable()
   {
      CutleryControl.onResolved += Resolve;
   }

   private void OnDisable()
   {
      CutleryControl.onResolved -= Resolve;
   }

   public void Resolve(CutleryControl obj)
   {
      Debug.Log(obj);
   }
}
