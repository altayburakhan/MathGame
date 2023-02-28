using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] protected int wallBreakCount;
   [SerializeField] GameObject gameOverText;

   private void Update()
   {
      if (wallBreakCount == 4)
      {
         var img4 = Instantiate(gameOverText);
      }
   }
}
