using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   public string playerName ;
   int health;
   public static int playerCount = 0;
   
   public void InitializePlayer(string name, int initialHealth){
      playerName = name;
      health = initialHealth;
      playerCount++;

   }

   public void Heal(int amount){

      health += amount;
      Debug.Log("health: "+health);

   }

   public void Heal(bool fullRestore)
   {
      if (fullRestore)
      {
         health = 100; 
         Debug.Log("fully restored, health:"+ health);
      }
   }

   public static void ShowPlayerCount()
   {
      Debug.Log("Count of players: "+playerCount);
   }

}
