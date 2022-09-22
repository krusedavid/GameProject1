using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayer : MonoBehaviour
{
   private ActivePlayerManager manager;

   public void AssignManager(ActivePlayerManager theManager)
   {
      manager = theManager;
   }

   public FireWeapon()
   {
      GiveDamage();
      manager.ChangeTurn();
   }

   public void GiveDamage()
   {
      GetComponent<Health>().TakeDamage(1);
   }
   
}
